using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CS4790TeamProject.Data;
using CS4790TeamProject.Models;
using CS4790TeamProject.Models.ViewModels;
using Microsoft.AspNetCore.Http;

namespace CS4790TeamProject.Controllers
{
    public class InventoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ItemViewModel ItemVM { get; set; }

        public InventoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string searchString)
        {
            
            var items = from i in _context.Item
                        select i;

            if (!String.IsNullOrEmpty(searchString))
            {
                items = items.Where(s => s.ItemName.Contains(searchString));
            }

            return View(await items.ToListAsync());
        }

        // GET: Inventory/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.Item
                .FirstOrDefaultAsync(m => m.ItemId == id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // GET: Inventory/Create
        public IActionResult Create()
        {
            LoadViewData();
            return View();
        }

        // POST: Inventory/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ItemId,ItemName,Description,OnhandQty,ListRetailCost,ReorderQty,MaxQty,MeasureID,MeasureAmnt,LastModifiedBy,LastModifiedDate")] Item item)
        {
            if (ModelState.IsValid)
            {
                //item.MeasureID = Convert.ToInt32(Request.Form["measureID"]);


                _context.Add(item);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(item);
        }

        // GET: Inventory/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.Item.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }

            LoadViewData();

            return View(item);
        }

        // POST: Inventory/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ItemId,ItemName,Description,OnhandQty,ListRetailCost,ReorderQty,MaxQty,MeasureID,MeasureAmnt,LastModifiedBy,LastModifiedDate")] Item item)
        {
            if (id != item.ItemId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(item);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemExists(item.ItemId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(item);
        }

        // GET: Inventory/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.Item
                .FirstOrDefaultAsync(m => m.ItemId == id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // POST: Inventory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var item = await _context.Item.FindAsync(id);
            _context.Item.Remove(item);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Inventory/Details/5
        public async Task<IActionResult> Assemble(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipe = await _context.AssemblyRecipe
                .FirstOrDefaultAsync(m => m.AssemblyRecipeId == id);
            if (recipe == null)
            {
                return NotFound();
            }

            return View(recipe);
        }

        private bool ItemExists(int id)
        {
            return _context.Item.Any(e => e.ItemId == id);
        }


        public async Task<IActionResult> Reorder(int? id)
        {
            return View(await _context.Item.ToListAsync());
        }

        public ItemViewModel itemToVM(Item item)
        {
            ItemVM = new ItemViewModel();

            ItemVM.itemID = item.ItemId;
            ItemVM.ItemName = item.ItemName;
            ItemVM.Description = item.Description;
            ItemVM.OnhandQty = item.OnhandQty;
            ItemVM.ListRetailCost = item.ListRetailCost;
            ItemVM.ReorderQty = item.ReorderQty;
            ItemVM.MaxQty = item.MaxQty;
            ItemVM.measureID = item.MeasureID;
            ItemVM.IsAssemblyItem = item.IsAssemblyItem;
            ItemVM.measureAmount = item.MeasureAmnt;

            getMeasureList();

            return ItemVM;
        }

        public void getMeasureList()
        {
            ViewData["measureID"] = new SelectList(_context.Measures, "measureID", "measureName");
            ItemVM.Measures = new List<Measures>();

            List<Measures> tempList = new List<Measures>();
            tempList = _context.Measures.ToList();

            foreach (Measures measure in tempList)
            {
                ItemVM.Measures.Add(measure);
            }
        }

        private void LoadViewData()
        {
            ViewData["measureID"] = new SelectList(_context.Measures, "MeasureId", "MeasureName");
        }
    }
}


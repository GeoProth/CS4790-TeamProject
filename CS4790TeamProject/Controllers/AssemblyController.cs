using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CS4790TeamProject.Data;
using CS4790TeamProject.Models;
using CS4790TeamProject.Models.ViewModels;

namespace CS4790TeamProject.Controllers
{
    public class AssemblyController : Controller
    {
        private readonly ApplicationDbContext _context;

        public int testVal { get; set; }

        public AssemblyRecipeViewModel AssemblyRecipeVM { get; set; }

        public AssemblyController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Assembly
        public async Task<IActionResult> Index()
        {

            return View(await _context.AssemblyRecipe.ToListAsync());
        }

        public ActionResult Assemble(int? recipeID)
        {
            if (recipeID != null)
            {
                var recipe = _context.AssemblyRecipe.FirstOrDefault(r => r.AssemblyRecipeId == recipeID);
                if (recipe == null)
                {
                    return NotFound();
                }

                return View(recipe);
            }

            return NotFound();
        }

        // GET: Assembly/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assemblyRecipe = await _context.AssemblyRecipe
                .FirstOrDefaultAsync(m => m.AssemblyRecipeId == id);
            if (assemblyRecipe == null)
            {
                return NotFound();
            }

            return View(assemblyRecipe);
        }

        // GET: Assembly/Create
        public IActionResult Create()
        {
            ViewData["ItemID"] = new SelectList(_context.Item, "ItemId", "ItemName");
            AssemblyRecipeVM = new AssemblyRecipeViewModel();
            AssemblyRecipeVM.allItems = _context.Item.ToList();
            return View(AssemblyRecipeVM);
        }

        // POST: Assembly/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AssemblyRecipeViewModel newVM)
        {
            //[Bind("AssemblyRecipeId,RecipeName,ItemID")] AssemblyRecipe assemblyRecipe
            if (ModelState.IsValid)
            {
                var newRecipe = new AssemblyRecipe();
                newRecipe.ItemID = newVM.itemID;
                var temp = await _context.Item.FirstOrDefaultAsync(i => i.ItemId == newVM.itemID);
                newRecipe.RecipeName = temp.ItemName;
                newRecipe.RecipeLines = newVM.recipeLines;

                _context.Add(newRecipe);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            //return View(newVM.AssemblyRecipe);
            return View();
        }

        // GET: Assembly/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assemblyRecipe = await _context.AssemblyRecipe.FindAsync(id);
            if (assemblyRecipe == null)
            {
                return NotFound();
            }
            return View(assemblyRecipe);
        }

        // POST: Assembly/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AssemblyRecipeId,RecipeName,ItemID")] AssemblyRecipe assemblyRecipe)
        {
            if (id != assemblyRecipe.AssemblyRecipeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(assemblyRecipe);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AssemblyRecipeExists(assemblyRecipe.AssemblyRecipeId))
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
            return View(assemblyRecipe);
        }

        // GET: Assembly/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assemblyRecipe = await _context.AssemblyRecipe
                .FirstOrDefaultAsync(m => m.AssemblyRecipeId == id);
            if (assemblyRecipe == null)
            {
                return NotFound();
            }

            return View(assemblyRecipe);
        }

        // POST: Assembly/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var assemblyRecipe = await _context.AssemblyRecipe.FindAsync(id);
            _context.AssemblyRecipe.Remove(assemblyRecipe);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AssemblyRecipeExists(int id)
        {
            return _context.AssemblyRecipe.Any(e => e.AssemblyRecipeId == id);
        }
    }
}

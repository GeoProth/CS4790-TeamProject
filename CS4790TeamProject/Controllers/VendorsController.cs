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

namespace CS4790TeamProject.Views.Vendors
{
    public class VendorsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VendorHistoryViewModel VendorHistoryVM { get; set; }

        public VendorsController(ApplicationDbContext context)
        {
            _context = context;

            VendorHistoryVM = new VendorHistoryViewModel()
            {
                Vendors = new Models.Vendor(),
                PurchaseOrders = _context.PurchaseOrder
                    .ToList()
            };
        }

        // GET: Vendors
        public async Task<IActionResult> Index()
        {
            return View(await _context.Vendor.ToListAsync());
        }

        // GET: Vendors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendor = await _context.Vendor
                .FirstOrDefaultAsync(m => m.VendorId == id);
            if (vendor == null)
            {
                return NotFound();
            }

            return View(vendor);
        }

        public async Task<IActionResult> History(int id)
        {
            VendorHistoryVM.Vendors = await _context.Vendor
                .Include(m => m.PurchaseOrders)
                .SingleOrDefaultAsync(n => n.VendorId == id);

            if (VendorHistoryVM.Vendors == null)
            {
                return NotFound();
            }

            return View(VendorHistoryVM);
        }

        /*
        public async Task History(int? id)
        {
            var Vendor = new VendorHistoryViewModel();
            Vendor.Vendors = await _context.Vendor
                .Include(v => v.PurchaseOrders)
                .AsNoTracking()
                .OrderBy(i => v.PurchaseDate)
                .ToListAsync();
            /*
            var vendor = await _context.Vendor
                .FirstOrDefaultAsync(m => m.VendorId == id);

            var orders = new List<PurchaseOrder>();
            */
        //var orders = new List<PurchaseOrder>(await _context.PurchaseOrder.Where(n => n.VendorID == id));

        /****
        var order = await _context.PurchaseOrder
            .FirstOrDefaultAsync(n => n.VendorID == id);
            ****/

        /***
        var orders = await _context.PurchaseOrder
            .Where(VendorId == id);
            ***/

        /*
        var VendorHistoryViewModel = new VendorHistoryViewModel
        {
            Vendors = vendor,
            PurchaseOrders = orders
        };
        */

        //return View(Vendor);
        /*
    }
    */

        // GET: Vendors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vendors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VendorId,VendorName,VendorAddress")] Vendor vendor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vendor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vendor);
        }

        // GET: Vendors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendor = await _context.Vendor.FindAsync(id);
            if (vendor == null)
            {
                return NotFound();
            }
            return View(vendor);
        }

        // POST: Vendors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VendorId,VendorName,VendorAddress")] Vendor vendor)
        {
            if (id != vendor.VendorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vendor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VendorExists(vendor.VendorId))
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
            return View(vendor);
        }

        // GET: Vendors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendor = await _context.Vendor
                .FirstOrDefaultAsync(m => m.VendorId == id);
            if (vendor == null)
            {
                return NotFound();
            }

            return View(vendor);
        }

        // POST: Vendors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vendor = await _context.Vendor.FindAsync(id);
            _context.Vendor.Remove(vendor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VendorExists(int id)
        {
            return _context.Vendor.Any(e => e.VendorId == id);
        }
    }
}

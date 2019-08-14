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

            VendorHistoryVM = new VendorHistoryViewModel()
            {
                Vendors = new Models.Vendor(),
                PurchaseOrders = _context.PurchaseOrder
                    .Where(m => m.VendorID == id)
                    .ToList(),
            };


            VendorHistoryVM.Vendors = await _context.Vendor
                .Include(m => m.PurchaseOrders)
                .AsNoTracking()
                .SingleOrDefaultAsync(n => n.VendorId == id);

            if (VendorHistoryVM.Vendors == null)
            {
                return NotFound();
            }

            return View(VendorHistoryVM);
        }

        /*
        public async Task<IActionResult> HistoryDetails(int id)
        {

            var OrdersViewModels = new PurchaseOrder()
            {
                //PurchaseOrder = new Models.PurchaseOrder(),
                OrderItems = _context.OrderItem
                    .Where(m => m.PurchaseOrderID == id).ToList()

            };

            //OrdersViewModels.PurchaseOrder = await _context.PurchaseOrder
            OrdersViewModels = await _context.PurchaseOrder
                .Include(m => m.OrderItems)
                .AsNoTracking()
                .SingleOrDefaultAsync(n => n.PurchaseOrderId == id);


            return View(OrdersViewModels);

        }
       */

        public async Task<IActionResult> HistoryDetails(int id)
        {
            var purchaseOrder = await _context.PurchaseOrder
                .Include(p => p.Vendor)
                .Include(p => p.OrderItems)
                    .ThenInclude(o => o.Item)
                .FirstOrDefaultAsync(m => m.PurchaseOrderId == id);
            if (purchaseOrder == null)
            {
                return NotFound();
            }

            return View(purchaseOrder);
        }

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
        public async Task<IActionResult> Create([Bind("VendorId,VendorName,VendorWebAddress,VendorPhoneNumber")] Vendor vendor)
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
        public async Task<IActionResult> Edit(int id, [Bind("VendorId,VendorName,VendorWebAddress,VendorPhoneNumber")] Vendor vendor)
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

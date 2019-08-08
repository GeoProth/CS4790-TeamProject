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
    public class PurchaseOrdersController : Controller
    {
        private readonly ApplicationDbContext _context;

        [BindProperty]
        public PurchaseOrder PurchaseOrder { get; set; }

        public PurchaseOrdersController(ApplicationDbContext context)
        {
            _context = context;

        }
        // GET: PurchaseOrders
        public async Task<IActionResult> Index()
        {

            var applicationDbContext = await _context.PurchaseOrder.Include(p => p.Vendor)
                                                  .Include(p => p.OrderItems)
                                                    .ThenInclude(o => o.RecievedItems)
                                                  .Include(p => p.OrderItems)
                                                    .ThenInclude(o => o.Item)
                                                  .ToListAsync();


            return View(applicationDbContext);

        }

        // GET: PurchaseOrders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchaseOrder = await _context.PurchaseOrder
                .Include(p => p.Vendor)
                .FirstOrDefaultAsync(m => m.PurchaseOrderId == id);
            if (purchaseOrder == null)
            {
                return NotFound();
            }

            return View(purchaseOrder);
        }
        // GET: PurchaseOrders/Create
        public IActionResult Create()
        {

            LoadViewDataForPurchaseOrder();
            return View();
        }
        
              [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PurchaseOrder purchaseOrder)
        {
            //get data from form, update, and send to new view
            purchaseOrder.VendorID = Convert.ToInt32(Request.Form["VendorID"]);
            purchaseOrder.Vendor = await _context.Vendor.FirstOrDefaultAsync(v => v.VendorId == purchaseOrder.VendorID);
            purchaseOrder.DateOrdered = Convert.ToDateTime(Request.Form["DateOrdered"]);
            purchaseOrder.DeliveryDate = Convert.ToDateTime(Request.Form["DeliveryDate"]);
            _context.PurchaseOrder.Add(purchaseOrder);
            int PoID = await _context.SaveChangesAsync();
            return RedirectToAction("AddOrderItems", PoID);

        }
        /// <summary>
        /// Add ORder ITems after Order is Created
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult AddOrderItems(int id)
        {
            PurchaseOrder = _context.PurchaseOrder.FirstOrDefault(p => p.PurchaseOrderId == id);
            ViewData["ItemID"] = new SelectList(_context.Item, "ItemId", "ItemName");
            ViewData["MeasureID"] = new SelectList(_context.Measures, "MeasureID", "MeasureName");
            return View(PurchaseOrder);
        }

        public JsonResult InsertOrderItems(List<OrderItem> orderitems)
        { 
            //Check for NULL.
            if (orderitems == null)
            {
                orderitems = new List<OrderItem>();
            }
            if(PurchaseOrder.OrderItems == null)
            {
                PurchaseOrder.OrderItems = new List<OrderItem>();
            }
            //Loop and insert records.
            foreach (OrderItem item in orderitems)
            {
                PurchaseOrder.OrderItems.Add(item);
                _context.PurchaseOrder.Update(PurchaseOrder);
            }

            int insertedRecords = _context.SaveChanges();

            return Json(insertedRecords);

        }
        // GET: PurchaseOrders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchaseOrder = await _context.PurchaseOrder.FindAsync(id);
            if (purchaseOrder == null)
            {
                return NotFound();
            }

            return View(purchaseOrder);
        }

        // POST: PurchaseOrders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PurchaseOrderId,VendorID,DateOrdered,VendorPO,Received,LastModifiedBy,LastModifiedDate")] PurchaseOrder purchaseOrder)
        {
            if (id != purchaseOrder.PurchaseOrderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(purchaseOrder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PurchaseOrderExists(purchaseOrder.PurchaseOrderId))
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
            ViewData["VendorID"] = new SelectList(_context.Vendor, "VendorId", "VendorId", purchaseOrder.VendorID);
            return View(purchaseOrder);
        }

        // GET: PurchaseOrders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchaseOrder = await _context.PurchaseOrder
                .Include(p => p.Vendor)
                .FirstOrDefaultAsync(m => m.PurchaseOrderId == id);
            if (purchaseOrder == null)
            {
                return NotFound();
            }

            return View(purchaseOrder);
        }

        // POST: PurchaseOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var purchaseOrder = await _context.PurchaseOrder.FindAsync(id);
            _context.PurchaseOrder.Remove(purchaseOrder);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool PurchaseOrderExists(int id)
        {
            return _context.PurchaseOrder.Any(e => e.PurchaseOrderId == id);
        }


        public async Task<IActionResult> Receive(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchaseOrder = await _context.PurchaseOrder
                .Include(p => p.Vendor)
                .FirstOrDefaultAsync(m => m.PurchaseOrderId == id);
            if (purchaseOrder == null)
            {
                return NotFound();
            }

            return View(purchaseOrder);
        }

        private void LoadViewDataForPurchaseOrder()
        {
            ViewData["VendorID"] = new SelectList(_context.Vendor, "VendorId", "VendorName");

        }

        

    }
}

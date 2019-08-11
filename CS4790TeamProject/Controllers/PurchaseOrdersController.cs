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
        public OrdersViewModel OrdersVM { get; set; }
        public PurchaseOrdersController(ApplicationDbContext context)
        {
            _context = context;
            OrdersVM = new OrdersViewModel()
            {
                PurchaseOrder = new PurchaseOrder(),
                OrderItems = new List<OrderItem>(),
                TempOrderItem = new OrderItem(),
                Vendor = new Vendor()

            };
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
            
            LoadViewData();
            return View(OrdersVM);
        }
       
        [HttpPost]
        public async Task<IActionResult> Create(OrdersViewModel model, string submitButton)
        {
            if (!ModelState.IsValid) {
                return View("Create", model);
            }
            if (submitButton == "Add Part")
            {
                if (model.TempOrderItem == null)
                {
                    model.TempOrderItem = new OrderItem();
                }
                model.TempOrderItem.ItemID = Convert.ToInt32(Request.Form["ItemID"]);
                model.TempOrderItem.Item = _context.Item.FirstOrDefault(i => i.ItemId == model.TempOrderItem.ItemID);
                model.TempOrderItem.Item.MeasureID = Convert.ToInt32(Request.Form["MeasureID"]);
                model.TempOrderItem.Price = Convert.ToDecimal(Request.Form["Price"]);
                model.TempOrderItem.QuantityOrdered = Convert.ToInt32(Request.Form["QntyOrdered"]);
                model.TempOrderItem.LastModifiedBy = User.Identity.Name;
                model.TempOrderItem.LastModifiedDate = DateTime.Now;

                //_context.OrderItem.Add(model.TempOrderItem);
                // await _context.SaveChangesAsync();
                if (OrdersVM.OrderItems == null)
                {
                    OrdersVM.OrderItems = new List<OrderItem>();
                }
                OrdersVM.OrderItems.Add(model.TempOrderItem);
                LoadViewData();
                return View(OrdersVM);
                }
                else if(submitButton == "Remove")
                {

                }
                else if(submitButton == "Create Order")
                {
                    await _context.SaveChangesAsync();
                }
            

            return View(nameof(Index));
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

        private void LoadViewData()
        {
            ViewData["Vendors"] = new SelectList(_context.Vendor, "VendorId", "VendorName");
            ViewData["Items"] = new SelectList(_context.Item, "ItemId", "ItemName");
            ViewData["Measures"] = new SelectList(_context.Measures, "MeasureId", "MeasureName");
        }
        private async Task GetDataFromViewBag()
        {
            
            OrdersVM.TempOrderItem.ItemID = Convert.ToInt32(Request.Form["ItemID"]);
            //OrdersVM.TempOrderItem.PurchaseOrderID = OrdersVM.PurchaseOrder.PurchaseOrderId; //is this needed? creating a new order, don't know the new PO ID yet
            OrdersVM.TempOrderItem.VendorSKU = Convert.ToString(Request.Form["VendorSKU"]);
            OrdersVM.TempOrderItem.Price = Convert.ToDecimal(Request.Form["Price"]);
            OrdersVM.TempOrderItem.QuantityOrdered = Convert.ToInt32(Request.Form["QuantityOrdered"]);
    
            OrdersVM.TempOrderItem.LastModifiedBy = User.Identity.Name;
            OrdersVM.TempOrderItem.LastModifiedDate = DateTime.Now;
            OrdersVM.TempOrderItem.PurchaseOrder = await _context.PurchaseOrder.FirstOrDefaultAsync(id => id.PurchaseOrderId == Convert.ToInt32(Request.Form["PurchaseOrderID"])); //no PO ID yetv
            OrdersVM.TempOrderItem.Item = await _context.Item.FirstOrDefaultAsync(id => id.ItemId == Convert.ToInt32(Request.Form["ItemID"]));

            OrdersVM.OrderItems = await _context.OrderItem.Where(id => id.VendorSKU == OrdersVM.TempOrderItem.VendorSKU).ToListAsync(); //need to find orderitems for this purchase order - need to maintain purchase order

           OrdersVM.Vendor.VendorId = Convert.ToInt32(Request.Form["VendorID"]);
          
            OrdersVM.PurchaseOrder.DeliveryDate = Convert.ToDateTime(Request.Form["DeliveryDate"]);
            OrdersVM.PurchaseOrder.DateOrdered = Convert.ToDateTime(Request.Form["DateOrdered"]);
            OrdersVM.PurchaseOrder.VendorPO = Request.Form["VendorSKU"];
            OrdersVM.PurchaseOrder.Vendor = await _context.Vendor.FirstOrDefaultAsync(a => a.VendorId == Convert.ToInt32(Request.Form["VendorID"]));
            OrdersVM.PurchaseOrder.VendorID = Convert.ToInt32(Request.Form["VendorID"]);
        }
    }
}

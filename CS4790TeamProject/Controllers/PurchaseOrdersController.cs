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
using Newtonsoft.Json;
using System.Web;


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
        public async Task<JsonResult> SaveOrder(OrdersViewModel model)
        {
            string result;
            if(model.Vendor.VendorId == 0 || model.PurchaseOrder.DateOrdered == null || model.PurchaseOrder.DeliveryDate == null || model.OrderItems == null)
            {
                result = "Error! Form not Complete!";
                return Json(result);
            }
            //get the purchase Order and add its properties
            var purchase = model.PurchaseOrder;
            purchase.LastModifiedBy = User.Identity.Name;
            purchase.LastModifiedDate = DateTime.Now;
            purchase.Vendor = await _context.Vendor.FirstOrDefaultAsync(v => v.VendorId == purchase.VendorID);
            //store purchase order and get Id
            _context.PurchaseOrder.Add(purchase);
             await _context.SaveChangesAsync();//new purchase order id

            //Now add OrderItems with Purchase Id
            foreach (OrderItem oi in model.OrderItems)
            {
                //add the purchase order Id
                oi.PurchaseOrderID = purchase.PurchaseOrderId;
                //add the Item
                oi.Item = await _context.Item.FirstOrDefaultAsync(i => i.ItemId == oi.ItemID);
                oi.Price = Convert.ToDecimal(oi.Price);
                oi.LastModifiedBy = User.Identity.Name;
                oi.LastModifiedDate = DateTime.Now;
                _context.OrderItem.Add(oi);
                await _context.SaveChangesAsync();

            }
            // save changes
            result = "Purchase Order# " + purchase.PurchaseOrderId.ToString() + " Confirmed.";
            return Json(result);
            
        }

       /*
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(OrdersViewModel OrdersVM, string submitButton)
        {
            if (!ModelState.IsValid) {
                return View("Create", OrdersVM);
            }
            if (submitButton == "Add Part")
            {
                if (OrdersVM.TempOrderItem == null)
                {
                    OrdersVM.TempOrderItem = new OrderItem();
                }
                OrdersVM.TempOrderItem.ItemID = Convert.ToInt32(Request.Form["ItemID"]);
                OrdersVM.TempOrderItem.Item = _context.Item.FirstOrDefault(i => i.ItemId == OrdersVM.TempOrderItem.ItemID);
                OrdersVM.TempOrderItem.Item.MeasureID = Convert.ToInt32(Request.Form["MeasureID"]);
                OrdersVM.TempOrderItem.Price = Convert.ToDecimal(Request.Form["Price"]);
                OrdersVM.TempOrderItem.QuantityOrdered = Convert.ToInt32(Request.Form["QntyOrdered"]);
                OrdersVM.TempOrderItem.LastModifiedBy = User.Identity.Name;
                OrdersVM.TempOrderItem.LastModifiedDate = DateTime.Now;

                //_context.OrderItem.Add(model.TempOrderItem);
                // await _context.SaveChangesAsync();
                if (OrdersVM.OrderItems == null)
                {
                    OrdersVM.OrderItems = new List<OrderItem>();
                }
                OrdersVM.OrderItems.Add(OrdersVM.TempOrderItem);
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
   */
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

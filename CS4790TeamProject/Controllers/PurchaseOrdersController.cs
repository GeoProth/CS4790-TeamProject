﻿using System;
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

        [BindProperty]
        public ReceiveViewModel ReceiveVM { get; set; }
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
                .Include(p => p.OrderItems)
                    .ThenInclude(o => o.Item).ThenInclude(i => i.Measure)
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
            OrdersVM = new OrdersViewModel()
            {
                PurchaseOrder = new PurchaseOrder(),
                OrderItems = new List<OrderItem>(),
                TempOrderItem = new OrderItem(),
                Vendor = new Vendor(),
                Item = new Item()//for getting the measureId

            };

            LoadViewData();
            return View(OrdersVM);
        }
        [HttpPost]// SaveOrder takes in a ViewModel from AJAX and processes the Data
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
            purchase.DateOrdered = Convert.ToDateTime(Request.Form["PurchaseOrder.DateOrdered"]);
            purchase.DeliveryDate = Convert.ToDateTime(Request.Form["DeliveryDate"]);
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
                oi.Item.Measure = await _context.Measures.FirstOrDefaultAsync(m => m.MeasureId == oi.Item.MeasureID); 
                oi.Price = Convert.ToDecimal(oi.Price);
                oi.LastModifiedBy = User.Identity.Name;
                oi.LastModifiedDate = DateTime.Now;
                _context.OrderItem.Add(oi);
                
            }
            await _context.SaveChangesAsync();
            // save changes
            result = "Purchase Order# " + purchase.PurchaseOrderId.ToString() + " Confirmed.";
            return Json(result);
            
        }

        public async Task<IActionResult> Receive(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var order = await _context.PurchaseOrder.FirstOrDefaultAsync(o => o.PurchaseOrderId == id);
            order.Received = true;
            await _context.SaveChangesAsync();
           
            return RedirectToAction("Index");
        }
    
       // GET: PurchaseOrders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            OrdersVM = new OrdersViewModel()
            {
                PurchaseOrder = await _context.PurchaseOrder.FirstOrDefaultAsync(p => p.PurchaseOrderId == id),
                OrderItems = await _context.OrderItem.Where(o => o.PurchaseOrderID == id)
                                                        .Include(i => i.Item).ToListAsync(),
                TempOrderItem = new OrderItem(),
                Vendor = new Vendor(),
                Item = new Item()//for getting the measureId

            };
           
            if (OrdersVM.PurchaseOrder == null)
            {
                return NotFound();
            }

            ViewData["Vendors"] = new SelectList(_context.Vendor, "VendorId", "VendorName", OrdersVM.PurchaseOrder.VendorID);
            ViewData["Items"] = new SelectList(_context.Item, "ItemId", "ItemName");
            ViewData["Measures"] = new SelectList(_context.Measures, "MeasureId", "MeasureName");

            return View(OrdersVM);
        }


        [HttpPost]// SaveOrder takes in a ViewModel from AJAX and processes the Data
        public async Task<JsonResult> EditOrder(OrdersViewModel model)
        {
            string result;
            if (model.Vendor.VendorId == 0 || model.PurchaseOrder.DateOrdered == null || model.PurchaseOrder.DeliveryDate == null || model.OrderItems == null)
            {
                result = "Error! Form not Complete!";
                return Json(result);
            }
            //get the purchase Order and add its properties
            var purchase = await _context.PurchaseOrder.FindAsync(model.PurchaseOrder.PurchaseOrderId);
            _context.PurchaseOrder.Remove(purchase);
            await _context.SaveChangesAsync();


            purchase = model.PurchaseOrder;
            purchase.PurchaseOrderId = 0;
           
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
                oi.Item.Measure = await _context.Measures.FirstOrDefaultAsync(m => m.MeasureId == oi.Item.MeasureID);
                oi.Price = Convert.ToDecimal(oi.Price);
                oi.LastModifiedBy = User.Identity.Name;
                oi.LastModifiedDate = DateTime.Now;
                _context.OrderItem.Add(oi);

            }
            await _context.SaveChangesAsync();
            // save changes
            result = "Purchase Order# " + purchase.PurchaseOrderId.ToString() + " Updated.";
            return Json(result);

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
                .Include(p => p.OrderItems)
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
        /*  Possible incorporation of receiving Items individually (if have time)
        [HttpGet]      
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
        */
        private void LoadViewData()
        {
            ViewData["Vendors"] = new SelectList(_context.Vendor, "VendorId", "VendorName");
            ViewData["Items"] = new SelectList(_context.Item, "ItemId", "ItemName");
            ViewData["Measures"] = new SelectList(_context.Measures, "MeasureId", "MeasureName");
        }
       
    }
}

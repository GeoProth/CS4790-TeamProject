using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS4790TeamProject.Data;
using CS4790TeamProject.Models;
using CS4790TeamProject.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CS4790TeamProject.Pages.Orders
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        [BindProperty]
        public OrdersViewModel OrdersVM { get; set; }
        public CreateModel(ApplicationDbContext context)
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
        public IActionResult OnGet()
        {
            LoadViewData();
            return Page();

        }

        public async Task<IActionResult> OnPostAddOrderAsync(string submit)
        {
            LoadViewData();
            switch (submit)
            {
                case "Create Order":
                    if (!ModelState.IsValid)
                    {
                        return Page();
                    }

                    await GetDataFromViewBag();

                    OrdersVM.PurchaseOrder.LastModifiedBy = User.Identity.Name;
                    OrdersVM.PurchaseOrder.LastModifiedDate = DateTime.Now;
                    _context.PurchaseOrder.Add(OrdersVM.PurchaseOrder);
                    await _context.SaveChangesAsync();

                    return RedirectToPage("./Index");
                case "Add Part":
                    if (OrdersVM.OrderItems == null)
                        OrdersVM.OrderItems = new List<OrderItem>();

                    await GetDataFromViewBag();

                    OrdersVM.OrderItems.Append(OrdersVM.TempOrderItem);
                    OrdersVM.TempOrderItem = new OrderItem();

                    return Page();
                default:
                    return Page();
            }
        }

       

        public ActionResult OnPostAddList(List<OrderItem> itemList)
        {
            if(itemList == null)
            {
                itemList = new List<OrderItem>();
            }

            foreach(var i in itemList)
            {
                _context.OrderItem.Add(i);
            }

            int id = _context.SaveChanges();
            return new JsonResult(id.ToString());
        }
        private async Task GetDataFromViewBag()
        {
            OrdersVM.TempOrderItem.ItemID = Convert.ToInt32(Request.Form["ItemID"]);
            OrdersVM.TempOrderItem.PurchaseOrderID = OrdersVM.PurchaseOrder.PurchaseOrderId; //is this needed? creating a new order, don't know the new PO ID yet
            OrdersVM.TempOrderItem.VendorSKU = Convert.ToString(Request.Form["VendorSKU"]);
            OrdersVM.TempOrderItem.Price = Convert.ToDecimal(Request.Form["Price"]);
            OrdersVM.TempOrderItem.QuantityOrdered = Convert.ToInt32(Request.Form["QuantityOrdered"]);
            OrdersVM.TempOrderItem.LastModifiedBy = User.Identity.Name;
            OrdersVM.TempOrderItem.LastModifiedDate = DateTime.Now;
            OrdersVM.PurchaseOrder.Vendor = await _context.Vendor.FirstOrDefaultAsync(a => a.VendorId == Convert.ToInt32(Request.Form["Vendors"]));
            OrdersVM.PurchaseOrder.VendorID = Convert.ToInt32(Request.Form["VendorID"]);
            OrdersVM.TempOrderItem.Item = await _context.Item.FirstOrDefaultAsync(id => id.ItemId == Convert.ToInt32(Request.Form["Items"]));
            OrdersVM.OrderItems = await _context.OrderItem.Where(id => id.VendorSKU == OrdersVM.TempOrderItem.VendorSKU).ToListAsync(); //need to find orderitems for this purchase order - need to maintain purchase order
            OrdersVM.Vendor.VendorId = Convert.ToInt32(Request.Form["VendorID"]);
            OrdersVM.TempOrderItem.PurchaseOrder = await _context.PurchaseOrder.FirstOrDefaultAsync(id => id.PurchaseOrderId == Convert.ToInt32(Request.Form["PurchaseOrderID"])); //no PO ID yet
            OrdersVM.PurchaseOrder.DeliveryDate = Convert.ToDateTime(Request.Form["DeliveryDate"]);
            OrdersVM.PurchaseOrder.DateOrdered = Convert.ToDateTime(Request.Form["DateOrdered"]);
            OrdersVM.PurchaseOrder.VendorPO = Request.Form["VendorSKU"];
        }

        private void LoadViewData()
        {
            ViewData["Vendors"] = new SelectList(_context.Vendor, "VendorId", "VendorName");
            ViewData["Items"] = new SelectList(_context.Item, "ItemId", "ItemName");
            ViewData["Measures"] = new SelectList(_context.Measures, "MeasureId", "MeasureName");
        }
    }


}
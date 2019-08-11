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
        public PurchaseOrder PurchaseOrder { get; set; }
        [BindProperty]
        public List<OrderItem> OrderItems { get; set; }
        [BindProperty]
        public OrderItem TempOrderItem { get; set; }
        [BindProperty]
        public Vendor Vendor { get; set; }
        [BindProperty]
        public Item Item { get; set; }

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
            if (OrderItems is null)
                OrderItems = new List<OrderItem>();
        }

        public IActionResult OnGet()
        {
            
            LoadViewData();
            return Page();
        }

        public async Task OnPostAddItemAsync()
        {
            //await GetDataFromViewBag();
            TempOrderItem.ItemID = Convert.ToInt32(Request.Form["ItemID"]);
            TempOrderItem.PurchaseOrderID = PurchaseOrder.PurchaseOrderId; 
            TempOrderItem.VendorSKU = Convert.ToString(Request.Form["VendorSKU"]);
            TempOrderItem.Price = Convert.ToDecimal(Request.Form["Price"]);
            TempOrderItem.QuantityOrdered = Convert.ToInt32(Request.Form["QuantityOrdered"]);
            TempOrderItem.Item = await _context.Item.FirstOrDefaultAsync(id => id.ItemId == Convert.ToInt32(Request.Form["ItemID"]));

            TempOrderItem.LastModifiedBy = User.Identity.Name;
            TempOrderItem.LastModifiedDate = DateTime.Now;

            TempOrderItem.PurchaseOrder = PurchaseOrder;
            OrderItems.Add(TempOrderItem);
            _context.OrderItem.Add(TempOrderItem);
           
            await _context.SaveChangesAsync();
            OrderItems = _context.OrderItem.Where(o => o.PurchaseOrderID == TempOrderItem.PurchaseOrderID).ToList();
            TempOrderItem = new OrderItem();
            LoadViewData();
        }

        public async Task OnPostRemoveItemAsync(int index)
        {
            await _context.OrderItem.FirstOrDefaultAsync(id => id.OrderItemId == index);
            await _context.SaveChangesAsync();
            await GetDataFromViewBag();
            LoadViewData();
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

                    PurchaseOrder.LastModifiedBy = User.Identity.Name;
                    PurchaseOrder.LastModifiedDate = DateTime.Now;
                    _context.PurchaseOrder.Add(PurchaseOrder);
                    await _context.SaveChangesAsync();

                    return RedirectToPage("./Index");
                case "Add Part":
                    if (OrderItems == null)
                        OrderItems = new List<OrderItem>();

                    await GetDataFromViewBag();

                    OrderItems.Add(TempOrderItem);
                    TempOrderItem = new OrderItem();

                    return Page();
                default:
                    return Page();
            }
        }


        private void LoadViewData()
        {
            ViewData["Vendors"] = new SelectList(_context.Vendor, "VendorId", "VendorName");
            ViewData["Items"] = new SelectList(_context.Item, "ItemId", "ItemName");
            ViewData["Measures"] = new SelectList(_context.Measures, "MeasureId", "MeasureName");
        }
        private async Task GetDataFromViewBag()
        {
            TempOrderItem.ItemID = Convert.ToInt32(Request.Form["ItemID"]);
            TempOrderItem.PurchaseOrderID = PurchaseOrder.PurchaseOrderId; //is this needed? creating a new order, don't know the new PO ID yet
            TempOrderItem.VendorSKU = Convert.ToString(Request.Form["VendorSKU"]);
            TempOrderItem.Price = Convert.ToDecimal(Request.Form["Price"]);
            TempOrderItem.QuantityOrdered = Convert.ToInt32(Request.Form["QuantityOrdered"]);
           
            TempOrderItem.LastModifiedBy = User.Identity.Name;
            TempOrderItem.LastModifiedDate = DateTime.Now;
            TempOrderItem.PurchaseOrder = await _context.PurchaseOrder.FirstOrDefaultAsync(id => id.PurchaseOrderId == Convert.ToInt32(Request.Form["PurchaseOrderID"])); //no PO ID yetv
            TempOrderItem.Item = await _context.Item.FirstOrDefaultAsync(id => id.ItemId == Convert.ToInt32(Request.Form["ItemID"]));

            OrderItems = await _context.OrderItem.Where(id => id.VendorSKU == TempOrderItem.VendorSKU).ToListAsync(); //need to find orderitems for this purchase order - need to maintain purchase order

            Vendor.VendorId = Convert.ToInt32(Request.Form["VendorID"]);

            PurchaseOrder.DeliveryDate = Convert.ToDateTime(Request.Form["DateDelivered"]);
            PurchaseOrder.DateOrdered = Convert.ToDateTime(Request.Form["DateOrdered"]);
            PurchaseOrder.VendorPO = Request.Form["VendorSKU"];
            PurchaseOrder.Vendor = await _context.Vendor.FirstOrDefaultAsync(a => a.VendorId == Convert.ToInt32(Request.Form["VendorID"]));
            PurchaseOrder.VendorID = Convert.ToInt32(Request.Form["VendorID"]);
        }
    }
}
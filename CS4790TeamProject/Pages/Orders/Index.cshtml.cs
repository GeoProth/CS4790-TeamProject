using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS4790TeamProject.Data;
using CS4790TeamProject.Models;
using CS4790TeamProject.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CS4790TeamProject.Pages.Orders
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public IList<PurchaseOrder> PurchaseOrder { get; set; }
        public string SearchString { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            var purchaseOrders = from i in _context.PurchaseOrder select i;

            PurchaseOrder = await _context.PurchaseOrder.Include(i => i.Vendor).ToListAsync();
            return Page();
        }

        public async Task<IActionResult> OnPostReceiveAsync(int id)
        {
            var order = await _context.PurchaseOrder.FirstOrDefaultAsync(a => a.PurchaseOrderId == id);
            order.Received = true;
            await _context.SaveChangesAsync();
            PurchaseOrder = await _context.PurchaseOrder.Include(i => i.Vendor).ToListAsync();
            return Page();
        }
    }
}
  
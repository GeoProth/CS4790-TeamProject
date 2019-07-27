using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS4790TeamProject.Models.ViewModels
{
    public class VendorHistoryViewModel
    {
        public Vendor Vendors { get; set; }

        public List<PurchaseOrder> PurchaseOrders { get; set; }

        public List<OrderItem> OrderDetails { get; set; }
    }
}

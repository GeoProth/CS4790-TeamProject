using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS4790TeamProject.Models.ViewModels
{
    public class OrdersViewModel
    {
        
        public PurchaseOrder PurchaseOrder { get; set; }

        public List<OrderItem> OrderItems { get; set; }

        public OrderItem TempOrderItem { get; set; }

        public Vendor Vendor { get; set; }

        //public Item Item { get; set; }
        //public IEnumerable<RecievedItems> RecievedItems { get; set; }
    }
}

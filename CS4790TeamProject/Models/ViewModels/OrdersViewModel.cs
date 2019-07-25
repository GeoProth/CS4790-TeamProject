using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS4790TeamProject.Models.ViewModels
{
    public class OrdersViewModel
    {
        public IEnumerable<PurchaseOrder> PurchaseOrders { get; set; }

        public IEnumerable<OrderItem> OrderItems { get; set; }

        public IEnumerable<RecievedItems> RecievedItems { get; set; }
    }
}

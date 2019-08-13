using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS4790TeamProject.Models.ViewModels
{
    public class RecieveViewModel
    {
        public PurchaseOrder PurchaseOrder { get; set; }
        public List<OrderItem> OrderItems { get; set; }

        public List<RecievedItems> RecievedItems { get; set; }
    }
}

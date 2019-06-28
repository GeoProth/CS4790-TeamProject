using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS4790TeamProject.Models
{
    public class PurchaseOrder
    {
        public int PurchaseOrderID { get; set; }
        public int VendorID { get; set; }
        public DateTime DateOrdered { get; set; }
        public string VendorPO { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}

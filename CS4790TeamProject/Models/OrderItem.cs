using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CS4790TeamProject.Models
{
    public class OrderItem
    {
        [Key]
        public int OrderItemId { get; set; }
        public int ItemID { get; set; }
        public int PurchaseOrderID { get; set; }
        public string VendorSKU { get; set; }
        public decimal Price { get; set; }
        public int QuantityOrdered { get; set; }
        public DateTime DateDelivered { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}

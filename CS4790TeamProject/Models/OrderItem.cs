using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CS4790TeamProject.Models
{
    public class OrderItem
    {
        [Key]
        public int OrderItemId { get; set; }
        //foreign key
        public int ItemID { get; set; }
        //foreign key
        public int PurchaseOrderID { get; set; }
        [Display(Name="Vendor SKU")]
        public string VendorSKU { get; set; }
        [Display(Name="Price")]
        public decimal Price { get; set; }
        [Display(Name="Qnty Ordered")]
        public int QuantityOrdered { get; set; }
        public DateTime DateDelivered { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        [ForeignKey("ItemID")]//local key (singular) that points to the Primary key in  Item table (plural)
        public virtual Item Items { get; set; }
        [ForeignKey("PurchaseOrderID")]//local key (singular) that points to the Primary key in  PurchaseOrder table (Singular)
        public virtual PurchaseOrder PurchaseOrder { get; set; }
    }
}

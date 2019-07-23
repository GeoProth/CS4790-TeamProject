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
        [Display(Name="Qty Ordered")]
        public int QuantityOrdered { get; set; }
        [DataType(DataType.Date)]
       
        [Display(Name="Last Updated By:")]
        public string LastModifiedBy { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime LastModifiedDate { get; set; }
        [ForeignKey("ItemID")]//local key (singular) that points to the Primary key in  Item table (singular)
        public virtual Item Item { get; set; }
        [ForeignKey("PurchaseOrderID")]//local key (singular) that points to the Primary key in  PurchaseOrder table (Singular)
        public virtual PurchaseOrder PurchaseOrder { get; set; }

        public ICollection<RecievedItems> RecievedItems { get; set; }
    }
}

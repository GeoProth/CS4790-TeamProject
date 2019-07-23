using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CS4790TeamProject.Models
{
    public class PurchaseOrder
    {
        [Key]
        public int PurchaseOrderId { get; set; }
        //foreign key
        [Display(Name="Vendor ID")]
        public int VendorID { get; set; }
        [Display(Name="Order Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOrdered { get; set; }
        [Display(Name="Vendor PO")]
        public string VendorPO { get; set; }

        public bool Received { get; set; }
        public string LastModifiedBy { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime LastModifiedDate { get; set; }

        [ForeignKey("VendorID")] //local key (singular) that points to the Primary key in  Vendor table 
        public virtual Vendor Vendor { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
        
    }
}

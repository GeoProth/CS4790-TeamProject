using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CS4790TeamProject.Models
{
    public class Vendor
    {
        [Key]
        public int VendorId { get; set; }
        [Display(Name="Vendor Name")]
        public string VendorName { get; set; }
        [Display(Name="Vendor Address")]
        public string VendorAddress { get; set; }
        public string LastModifiedBy { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime LastModifiedDate { get; set; }


        public ICollection<PurchaseOrder> PurchaseOrders { get; set; }
    }
}

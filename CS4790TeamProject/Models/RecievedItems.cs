using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CS4790TeamProject.Models
{
    public class RecievedItems
    {
        [Key]
        public int ReceivedId { get; set; }
        //foreign key
        public int OrderItemID { get; set; }
        [Display(Name="Qty Received")]
        public int QuantityReceived { get; set; }
        [Display(Name="Notes")]
        public string Notes { get; set; }
        public string LastModifiedBy { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/YYYY}", ApplyFormatInEditMode = true)]
        public DateTime LastModifiedDate { get; set; }
        [ForeignKey("OrderItemID")]//local key (singular) that points to the Primary key in  OrderItem table 
        public virtual OrderItem OrderItem { get; set; }
    }
}

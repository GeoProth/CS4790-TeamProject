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
        public int QuantityReceived { get; set; }
        public string Notes { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        [ForeignKey("OrderItemID")]//local key (singular) that points to the Primary key in  OrderItem table 
        public virtual OrderItem OrderItem { get; set; }
    }
}

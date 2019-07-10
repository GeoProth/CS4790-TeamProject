using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CS4790TeamProject.Models
{
    public class InventoryLog
    {
        [Key]
        public int LogId { get; set; }
        //Foreign Key
        public int ItemID { get; set; }
        [Display(Name="Previous Qty")]
        public int PreviousQty { get; set; }
        [Display(Name="New Qty")]
        public int NewQty { get; set; }
        //data type is 'bit'. Not sure what to code for that
        public bool Reconciled { get; set; } 

        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        [ForeignKey("ItemID")]
        public virtual Item Item { get; set; }
    }
}

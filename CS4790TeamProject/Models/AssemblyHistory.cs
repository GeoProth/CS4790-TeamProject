using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CS4790TeamProject.Models
{
    public class AssemblyHistory
    {
        [Key]
        public int AssemblyHistoryId { get; set; }
        //foreign key
        public int ItemID { get; set; }
        public DateTime AssemblyDate { get; set; }
        public int QtyAssembled { get; set; }
        [Display(Name="Notes")]
        public string Notes { get; set; }
        public string LastModifiedBy { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime LastModifiedDate { get; set; }

        [ForeignKey("ItemID")]
        public virtual Item Item { get; set; }
    }
}

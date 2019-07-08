using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CS4790TeamProject.Models
{
    public class AssemblyHistory
    {
        [Key]
        public int AssemblyHistoryId { get; set; }
        public int ItemID { get; set; }
        public DateTime AssemblyDate { get; set; }
        public int QtyAssembled { get; set; }
        public string Notes { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}

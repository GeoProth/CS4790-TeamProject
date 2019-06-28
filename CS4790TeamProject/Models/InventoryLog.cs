using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS4790TeamProject.Models
{
    public class InventoryLog
    {
        public int LogID { get; set; }
        public int ItemID { get; set; }
        public int PreviousQty { get; set; }
        public int NewQty { get; set; }


        //data type is 'bit'. Not sure what to code for that



        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}

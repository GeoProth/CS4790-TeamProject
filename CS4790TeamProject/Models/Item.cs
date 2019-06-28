﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS4790TeamProject.Models
{
    public class Item
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public int OnhandQty { get; set; }
        public decimal ListRetailCost { get; set; }
        public int ReorderQty { get; set; }
        public int MaxQty { get; set; }
        public int MeasureID { get; set; }
        public decimal MeasureAmnt { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}

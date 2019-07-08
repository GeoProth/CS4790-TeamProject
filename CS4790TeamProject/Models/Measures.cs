using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CS4790TeamProject.Models
{
    public class Measures
    {
        [Key]
        public int MeasureId { get; set; }
        public string MeasureName { get; set; }
    }
}

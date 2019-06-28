using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS4790TeamProject.Models
{
    public class RecipeLine
    {
        public int RecipeLineID { get; set; }
        public int AssemblyRecipeID { get; set; }
        public int ItemID { get; set; }
        public int RequiredItemQuantity { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}

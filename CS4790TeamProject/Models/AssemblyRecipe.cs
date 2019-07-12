using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CS4790TeamProject.Models
{
    public class AssemblyRecipe
    {
        [Key]
        public int AssemblyRecipeId { get; set; }
        [Display(Name = "Assembly Name")]
        public string RecipeName { get; set; }
        [Display(Name = "Assembly Item")]
        public int ItemID { get; set; }
    }
}

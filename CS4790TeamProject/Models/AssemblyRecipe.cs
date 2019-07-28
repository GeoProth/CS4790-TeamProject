using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public int ItemID { get; set; }

        public virtual ICollection<RecipeLine> RecipeLines { get; set; }

        [ForeignKey("ItemID")]
        public virtual Item Item { get; set; }
    }
}


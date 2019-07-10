using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS4790TeamProject.Models.ViewModels
{
    public class AssemblyRecipeViewModel
    {
        public Item items { get; set; }
        public IEnumerable<AssemblyRecipe> AssemblyRecipe { get; set; }
        public List<RecipeLine> recipeLines { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CS4790TeamProject.Models.ViewModels
{
    public class AssemblyRecipeViewModel
    {
        [Display(Name = "Assembly Recipe Name")]
        public string RecipeName { get; set; }

        [Display(Name = "Assembly Recipe ID")]
        public int AssemblyRecipeID { get; set; }

        [Display(Name = "Item")]
        public int itemID { get; set; }

        public List<Item> allItems { get; set; }

        public List<AssemblyRecipe> assemblyRecipe { get; set; }

        public List<RecipeLine> recipeLines { get; set; }

        public bool IsAssemblyRecipe { get; set; }

        //public IEnumerable<AssemblyRecipe> AssemblyRecipe { get; set; }
        //public IEnumerable<Item> Item { get; set; }
    }
}

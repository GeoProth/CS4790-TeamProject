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
        //foreign Key
        public int ItemID { get; set; }
       
    }
}

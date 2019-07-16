using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CS4790TeamProject.Models
{
    public class RecipeLine
    {
        [Key]
        public int RecipeLineId { get; set; }
        //Foreign Key
        public int? AssemblyRecipeID { get; set; }
        //Foreign Key
        public int ItemID { get; set; }
        [Display(Name="Qty Required")]
        public int RequiredItemQuantity { get; set; }
        public string LastModifiedBy { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/YYYY}", ApplyFormatInEditMode = true)]
        public DateTime LastModifiedDate { get; set; }
        [ForeignKey("AssemblyRecipeID")]//local key (singular) that points to the Primary key in  AssemblyRecipe table 
        public virtual AssemblyRecipe AssemblyRecipe { get; set; }
        [ForeignKey("ItemID")]//local key (singular) that points to the Primary key in  Item table 
        public virtual Item Item { get; set; }
    }
}

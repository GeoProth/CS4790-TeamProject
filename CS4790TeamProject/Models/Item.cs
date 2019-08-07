using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CS4790TeamProject.Models
{
    public class Item
    {
        [Key]
        public int ItemId { get; set; }
        [Display(Name = "Name")]
        public string ItemName { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "On Hand")]
        public int OnhandQty { get; set; }
        [Display(Name = "Retail Cost")]
        public decimal ListRetailCost { get; set; }
        [Display(Name = "Reorder Quantity")]
        public int ReorderQty { get; set; }
        [Display(Name = "Max Quantity")]
        public int MaxQty { get; set; }
        public int MeasureID { get; set; }
        [Display(Name = "Is this an Assembly item?")]
        public bool IsAssemblyItem { get; set; }
        [Display(Name = "Measure Amount")]
        public decimal MeasureAmnt { get; set; }
        [Display(Name = "Last Modified By")]
        public string LastModifiedBy { get; set; }
        [Display(Name = "Last Modified Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime LastModifiedDate { get; set; }

       [ForeignKey("MeasureID")]
       public virtual Measures Measure { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
        public ICollection<AssemblyHistory> AssemblyHistories { get; set; }

        public ICollection<InventoryLog> InventoryLogs { get; set; }
        public ICollection<AssemblyRecipe> AssemblyRecipes { get; set; }

        public ICollection<RecipeLine> RecipeLines { get; set; }
        
    }
}

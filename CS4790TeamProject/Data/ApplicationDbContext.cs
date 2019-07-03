using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CS4790TeamProject.Models;

namespace CS4790TeamProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        DbSet<AssemblyHistory> AssemblyHistory { get; set; }
        DbSet<AssemblyRecipe> AssemblyRecipe { get; set; }
        DbSet<InventoryLog> InventoryLog { get; set; }
        DbSet<Item> Item { get; set; }
        DbSet<Measures> Measures { get; set; }
        DbSet<OrderItem> OrderItem { get; set; }
        DbSet<PurchaseOrder> PurchaseOrder { get; set; }
        DbSet<RecievedItems> RecievedItems { get; set; }
        DbSet<RecipeLine> RecipeLine { get; set; }
        DbSet<Vendor> Vendor { get; set; }
    }
}

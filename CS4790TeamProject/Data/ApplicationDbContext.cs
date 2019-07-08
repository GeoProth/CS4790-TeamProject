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

        public DbSet<AssemblyHistory> AssemblyHistory { get; set; }
        public DbSet<AssemblyRecipe> AssemblyRecipe { get; set; }
        public DbSet<InventoryLog> InventoryLog { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<Measures> Measures { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrder { get; set; }
        public DbSet<RecievedItems> RecievedItems { get; set; }
        public DbSet<RecipeLine> RecipeLine { get; set; }
        public DbSet<Vendor> Vendor { get; set; }
    }
}

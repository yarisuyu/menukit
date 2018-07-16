using WebUI.Models.Entities;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Models.Concrete
{
    public class MenuContext : DbContext
    {
        public DbSet<Ingredient> Ingredients { get; set; }

        public MenuContext(): base(nameOrConnectionString: "MenuContext") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }

    }
}
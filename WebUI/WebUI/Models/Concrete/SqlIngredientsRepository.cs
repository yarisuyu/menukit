using WebUI.Models.Abstract;
using WebUI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using Npgsql;
using System.Data;

namespace WebUI.Models.Concrete
{
    public class SqlIngredientsRepository : IIngredientsRepository
    {
        //public DbSet<Ingredient> IngredientTable { get; set; }
        MenuContext ctx = new MenuContext();
        
        public SqlIngredientsRepository()
        { }

        
        public IQueryable<Ingredient> Ingredients
        {
            get { return ctx.Ingredients; }
        }
    }    
}

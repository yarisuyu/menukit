using WebUI.Models.Abstract;
using WebUI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebUI.Models.Concrete
{
    public class FakeIngredientsRepository : IIngredientsRepository
    {
        private static IQueryable<Ingredient> fakeIngredients = new List<Ingredient> {
            new Ingredient {Name = "Гречка", Category = "Крупы"},
            new Ingredient {Name = "Рис", Category = "Крупы"},
            new Ingredient {Name = "Курица", Category = "Крупы"},
            new Ingredient {Name = "Говядина", Category = "Мясо"},
            new Ingredient {Name = "Творог", Category = "Молочка"},
            new Ingredient {Name = "Яйцо", Category = "Яйца"}
        }.AsQueryable();

        public IQueryable<Ingredient> Ingredients
        {
            get { return fakeIngredients; }
        }
    }
}

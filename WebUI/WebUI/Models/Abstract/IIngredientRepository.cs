using WebUI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebUI.Models.Abstract
{
    public interface IIngredientsRepository
    {
        IQueryable<Ingredient> Ingredients { get; }
    }
}

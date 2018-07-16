using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Linq.Mapping;

namespace WebUI.Models.Entities
{
    [Table(Name = "ingredients")]
    public class Ingredient
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.OnInsert)]
        public int IngredientID { get; set; }
        [Column] public string Name { get; set; }
        [Column] public string Category { get; set; }
    }
}

using Model.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core
{
    public class Recipe
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public TypeOfMeal Type { get; set; }
        public List<ProductForRecipe>? Products { get; set; }
    }
}

using DietSLi.Model.Core.Submodels;
using DietSLi.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietSLi.Model.Core
{
    public class Recipe
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public TypeOfMeal Type { get; set; }
        public List<ProductForRecipe>? Products { get; set; }
    }
}

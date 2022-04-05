using Model.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core
{
    public class OneDayDiet
    {
        public Dictionary<TypeOfMeal, Recipe>? Meals { get; set; }
    }
}

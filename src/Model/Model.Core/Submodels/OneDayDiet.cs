﻿using DietSLi.Model.Core;
using DietSLi.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietSLi.Model.Core.Submodels
{
    public class OneDayDiet
    {
        public Dictionary<TypeOfMeal, Recipe>? Meals { get; set; }
    }
}
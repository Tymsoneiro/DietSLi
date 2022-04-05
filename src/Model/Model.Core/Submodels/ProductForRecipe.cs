﻿using DietSLi.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietSLi.Model.Core.Submodels
{
    public class ProductForRecipe
    {
        public Product? Product { get; set; }
        public int Quantity { get; set; }
        public MeasurementUnit MeasurementUnit { get; set; }
    }
}

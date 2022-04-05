using DietSLi.Shared.Enums;

namespace DietSLi.Model.Core.Submodels
{
    public class ProductForRecipe
    {
        public Product? Product { get; set; }
        public int Quantity { get; set; }
        public MeasurementUnit MeasurementUnit { get; set; }
    }
}

using DietSLi.Shared.Enums;

namespace DietSLi.Model.Core.Submodels
{
    public class OneDayDiet
    {
        public Dictionary<TypeOfMeal, Recipe>? Meals { get; set; }
    }
}

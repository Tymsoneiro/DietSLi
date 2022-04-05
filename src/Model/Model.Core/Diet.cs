using DietSLi.Model.Core.Submodels;

namespace DietSLi.Model.Core
{
    public class Diet
    {
        public string? Name { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public Dictionary<DateOnly, OneDayDiet>? DailyDiet { get; set; }
    }
}

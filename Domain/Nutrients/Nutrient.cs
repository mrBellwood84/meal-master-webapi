using Domain.Measures;

namespace Domain.Nutrients
{
    public class Nutrient
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int DisplayIndex { get; set; }
        public Measure Measure { get; set; }
        public NutrientType Type { get; set; }
    }
}

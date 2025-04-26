using Domain.Messures;

namespace Domain.Nutrients
{
    public class NutrientType
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Messure Messure { get; set; }
        public int DisplayIndex { get; set; }
        public bool Mandatory { get; set; }
    }
}

namespace Domain.Nutrients
{
    public class NutrientIngredient
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public float Value { get; set; }
        public string Messure { get; set; }
        public int DisplayIndex { get; set; }
        public bool Mandatory { get; set; }
    }
}

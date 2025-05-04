using Domain.Ingredients;

namespace Domain.Nutrients
{
    public class NutrientIngredient
    {
        public string Id { get; set; }
        public float Value { get; set; }
        public NutrientType NutrientType { get; set; }
    }
}

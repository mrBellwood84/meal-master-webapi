using Domain.Nutrients;

namespace Domain.Ingredients
{
    public class IngredientNutrient
    {
        public string Id { get; set; }
        public float Value { get; set; }
        public Nutrient Nutrient { get; set; }

    }
}

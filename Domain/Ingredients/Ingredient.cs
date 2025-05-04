using Domain.Messures;
using Domain.Misc;
using Domain.Nutrients;

namespace Domain.Ingredients
{
    public class Ingredient
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public float VolumeWeightRatio { get; set; }
        public Messure Messure { get; set; }
        public List<IngredientCategory> Categories { get; set; } = new();
        public List<NutrientIngredient> Nutrients { get; set; } = new();
        public Source NutrientSource { get; set; }
    }
}

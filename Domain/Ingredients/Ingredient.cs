using Domain.Messures;
using Domain.Nutrients;

namespace Domain.Ingredients
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<IngredientCategory> Categories { get; set; }
        public MessureType MessureType{ get; set; }
        public float WeightVolumeRatio { get; set; }
        public List<NutrientIngredient> Nutrients { get; set; }
        public string NutritionDataSource { get; set; }
    }
}

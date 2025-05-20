using Domain.Misc;

namespace Domain.Ingredients
{
    public class Ingredient
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string NamePlural { get; set; }
        public List<IngredientMessure> Messures { get; set; } = new();
        public List<IngredientCategory> Categories { get; set; } = new();
        public List<IngredientNutrient> Nutrients { get; set; } = new();
        public Source NutrientSource { get; set; }
    }
}

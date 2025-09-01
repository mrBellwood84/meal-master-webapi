using Domain.Ingredients;
using Domain.Measures;

namespace Domain.Recipes
{
    public class RecipeIngredient
    {
        public string Id { get; set; }
        public float Amount { get; set; }
        public Ingredient Ingredient { get; set; }
        public Measure Measure { get; set; }
    }
}

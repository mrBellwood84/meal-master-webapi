using Domain.Ingredients;
using Domain.Messures;

namespace Domain.Recipe
{
    public class RecipeIngredient
    {
        public string Id { get; set; }
        public float Amount { get; set; }
        public Ingredient Ingredient { get; set; }
        public Messure Messure { get; set; }
    }
}

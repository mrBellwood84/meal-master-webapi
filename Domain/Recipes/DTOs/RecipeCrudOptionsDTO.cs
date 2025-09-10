using Domain.Ingredients;
using Domain.Recipes;

namespace Domain.Recipes.DTOs
{
    public class RecipeCrudOptionsDTO
    {
        public List<RecipeType> RecipeTypes { get; set; } = new List<RecipeType>();
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
    }
}

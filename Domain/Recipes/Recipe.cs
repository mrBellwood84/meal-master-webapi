using Domain.Misc;

namespace Domain.Recipes
{
    public class Recipe
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Portions { get; set; }
        public List<RecipeIngredient> Ingredients { get; set; }
        public List<RecipeStep> Steps { get; set; }
        public List<RecipeCategory> Categories { get; set; }
        public Source Source { get; set; }
    }
}

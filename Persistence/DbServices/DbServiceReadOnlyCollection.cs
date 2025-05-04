using Domain.Ingredients;
using Domain.Messures;
using Domain.Nutrients;
using Domain.Recipes;

namespace Persistence.DbService
{
    public class DbServiceReadOnlyCollection : IDbServiceReadOnlyCollection
    {
        private readonly IDbServiceReadOnly<IngredientCategory> _ingredientCategory;
        private readonly IDbServiceReadOnly<Messure> _messure;
        private readonly IDbServiceReadOnly<NutrientType> _nutrientType;
        private readonly IDbServiceReadOnly<RecipeCategory> _recipeCategory;
        private readonly IDbServiceReadOnly<RecipeType> _recipeType;


        public DbServiceReadOnlyCollection(
            IDbServiceReadOnly<IngredientCategory> ingredientCategory,
            IDbServiceReadOnly<Messure> messure,
            IDbServiceReadOnly<NutrientType> nutrientType,
            IDbServiceReadOnly<RecipeCategory> recipeCategory,
            IDbServiceReadOnly<RecipeType> recipeType)
        {
            _ingredientCategory = ingredientCategory;
            _messure = messure;
            _nutrientType = nutrientType;
            _recipeCategory = recipeCategory;
            _recipeType = recipeType;
        }

        public Task<List<IngredientCategory>> IngredientCategoriesGetAllAsync() => _ingredientCategory.GetAllAsync();
        public Task<List<Messure>> MessureGetAllAsync() => _messure.GetAllAsync();
        public Task<List<NutrientType>> NutrientTypesGetAllAsync() => _nutrientType.GetAllAsync();
        public Task<List<RecipeCategory>> RecipeCategoriesGetAllAsync() => _recipeCategory.GetAllAsync();
        public Task<List<RecipeType>> RecipeTypesGetAllAsync() => _recipeType.GetAllAsync();
    }
}

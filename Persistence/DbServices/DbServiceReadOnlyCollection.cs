using Domain.Ingredients;
using Domain.Messures;
using Domain.Misc;
using Domain.Nutrients;
using Domain.Recipes;
using Persistence.DbServices.Interfaces;

namespace Persistence.DbService
{
    /// <summary>
    /// Provides a centralized collection of read-only database services for retrieving various domain entities.
    /// </summary>
    public class DbServiceReadOnlyCollection : IDbServiceReadOnlyCollection
    {
        private readonly IDbServiceReadOnly<IngredientCategory> _ingredientCategory;
        private readonly IDbServiceReadOnly<Messure> _messure;
        private readonly IDbServiceReadOnly<MessureType> _messureType;
        private readonly IDbServiceReadOnly<Nutrient> _nutrient;
        private readonly IDbServiceReadOnly<NutrientType> _nutrientType;
        private readonly IDbServiceReadOnly<RecipeCategory> _recipeCategory;
        private readonly IDbServiceReadOnly<RecipeType> _recipeType;
        private readonly IDbServiceReadOnly<SourceType> _sourceType;

        public DbServiceReadOnlyCollection(
            IDbServiceReadOnly<IngredientCategory> ingredientCategory,
            IDbServiceReadOnly<Messure> messure,
            IDbServiceReadOnly<MessureType> messureType,
            IDbServiceReadOnly<Nutrient> nutrient,
            IDbServiceReadOnly<NutrientType> nutrientType,
            IDbServiceReadOnly<RecipeCategory> recipeCategory,
            IDbServiceReadOnly<RecipeType> recipeType,
            IDbServiceReadOnly<SourceType> sourceType)

        {
            _ingredientCategory = ingredientCategory;
            _messure = messure;
            _messureType = messureType;
            _nutrient = nutrient;
            _nutrientType = nutrientType;
            _recipeCategory = recipeCategory;
            _recipeType = recipeType;
            _sourceType = sourceType;
        }

        public Task<List<IngredientCategory>> IngredientCategoriesGetAllAsync() => _ingredientCategory.GetAllAsync();
        public Task<List<Messure>> MessureGetAllAsync() => _messure.GetAllAsync();
        public Task<List<MessureType>> MessureTypeGetAllAsync() => _messureType.GetAllAsync();
        public Task<List<Nutrient>> NutrientGetAllAsync() => _nutrient.GetAllAsync();
        public Task<List<NutrientType>> NutrientTypeGetAllAsync() => _nutrientType.GetAllAsync();
        public Task<List<RecipeCategory>> RecipeCategoryGetAllAsync() => _recipeCategory.GetAllAsync();
        public Task<List<RecipeType>> RecipeTypeGetAllAsync() => _recipeType.GetAllAsync();
        public Task<List<SourceType>> SourceTypeGetAllAsync() => _sourceType.GetAllAsync();
    }
}

using Domain.Ingredients;
using Domain.Measures;
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
        private readonly IDbServiceReadOnly<Measure> _measure;
        private readonly IDbServiceReadOnly<MeasureType> _measureType;
        private readonly IDbServiceReadOnly<Nutrient> _nutrient;
        private readonly IDbServiceReadOnly<NutrientType> _nutrientType;
        private readonly IDbServiceReadOnly<RecipeCategory> _recipeCategory;
        private readonly IDbServiceReadOnly<RecipeType> _recipeType;

        public DbServiceReadOnlyCollection(
            IDbServiceReadOnly<IngredientCategory> ingredientCategory,
            IDbServiceReadOnly<Measure> measure,
            IDbServiceReadOnly<MeasureType> measureType,
            IDbServiceReadOnly<Nutrient> nutrient,
            IDbServiceReadOnly<NutrientType> nutrientType,
            IDbServiceReadOnly<RecipeCategory> recipeCategory,
            IDbServiceReadOnly<RecipeType> recipeType)
        {
            _ingredientCategory = ingredientCategory;
            _measure = measure;
            _measureType = measureType;
            _nutrient = nutrient;
            _nutrientType = nutrientType;
            _recipeCategory = recipeCategory;
            _recipeType = recipeType;
        }

        public Task<List<IngredientCategory>> IngredientCategoriesGetAllAsync() => _ingredientCategory.GetAllAsync();
        public Task<List<Measure>> MeasureGetAllAsync() => _measure.GetAllAsync();
        public Task<List<MeasureType>> MeasureTypeGetAllAsync() => _measureType.GetAllAsync();
        public Task<List<Nutrient>> NutrientGetAllAsync() => _nutrient.GetAllAsync();
        public Task<List<NutrientType>> NutrientTypeGetAllAsync() => _nutrientType.GetAllAsync();
        public Task<List<RecipeCategory>> RecipeCategoryGetAllAsync() => _recipeCategory.GetAllAsync();
        public Task<List<RecipeType>> RecipeTypeGetAllAsync() => _recipeType.GetAllAsync();
    }
}

using Domain.Recipes.DTOs;

namespace Application.DataService.Recipes.Interfaces
{
    public interface IRecipeDataService
    {
        Task<RecipeCrudOptionsDTO> GetCrudOptionsAsync();
    }
}
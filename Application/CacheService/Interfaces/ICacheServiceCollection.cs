using Domain.Ingredients;
using Domain.Messures;

namespace Application.CacheService.Interfaces
{
    public interface ICacheServiceCollection
    {
        ICacheService<IngredientCategory> IngredientCategory { get; }
        ICacheService<Messure> Messure { get; }
        ICacheService<MessureType> MessureType { get; set; }
    }
}
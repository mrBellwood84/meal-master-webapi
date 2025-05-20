using Domain.Ingredients;
using Domain.Messures;

namespace Application.CacheService
{
    public interface ICacheServiceCollection
    {
        ICacheService<IngredientCategory> IngredientCategory { get; }
        ICacheService<Messure> Messure { get; }
    }
}
using Domain.Measures;

namespace Domain.Ingredients
{
    public class IngredientMeasure
    {
        public string Id { get; set; }
        public float Quantity { get; set; }
        public Measure Measure { get; set; }
    }
}

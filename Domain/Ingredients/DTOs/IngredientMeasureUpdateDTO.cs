namespace Domain.Ingredients.DTOs
{
    public class IngredientMeasureUpdateDTO
    {
        public string Id { get; set; }
        public string IngredientId { get; set; }
        public string MeasureId { get; set; }
        public float Quantity { get; set; }
    }
}
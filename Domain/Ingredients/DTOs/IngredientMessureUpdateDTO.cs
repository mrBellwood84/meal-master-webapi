namespace Domain.Ingredients.DTOs
{
    public class IngredientMessureUpdateDTO
    {
        public string Id { get; set; }
        public string IngredientId { get; set; }
        public string MessureId { get; set; }
        public float Quantity { get; set; }
    }
}
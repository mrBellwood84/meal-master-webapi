namespace Domain.Messures
{
    public class Messure
    {
        public string Id { get; set; }
        public MessureType MessureType { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public float RelativeSize { get; set; }
    }
}

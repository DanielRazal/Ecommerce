namespace Ecommerce_Task.Entities
{
    public class Site
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public Site[]? SubData { get; set; }
    }
}

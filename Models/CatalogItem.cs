namespace CatalogService.Models
{
    public class CatalogItem
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public decimal Price { get; set; }
        public required string Description { get; set; }
    }
}

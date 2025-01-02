namespace OGS.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName {  get; set; }
        public string ImageUrl { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public int StockQuantity { get; set; }

    }
}

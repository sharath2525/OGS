namespace OGS.Models
{
    public class Stock
    {
        public int StockId { get; set; }
        public int ProductId { get; set; }
        public int QuantityAdded { get; set; }

        public int QuantityInHand { get; set; }
        public int QuantitySold { get; set; }
        public DateTime UpdatedDate { get; set; }


    }
}

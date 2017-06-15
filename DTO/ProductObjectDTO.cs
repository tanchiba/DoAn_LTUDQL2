namespace DTO
{
    public class ProductObjectDTO
    {
        public int? MaxStock { get; set; }
        public int? MinStock { get; set; }
        public decimal? Org_Price { get; set; }
        public string ProductName { get; set; }
        public string Product_Group_ID { get; set; }
        public string Product_ID { get; set; }
        public int? Quantity { get; set; }
        public decimal? Retail_Price { get; set; }
        public decimal? Sale_Price { get; set; }
        public string Unit { get; set; }
    }
}
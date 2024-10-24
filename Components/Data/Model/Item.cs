namespace Webbanhang.Components.Data.Model
{
    public class Item
    {
        public int ItemId { get; set; }
        public string? ItemName { get; set; }
        public string? Description { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal SalePrice { get; set; }
        public string? Category { get; set; }
        public int QuantityInStock { get; set; }
        public int DiscountPrice { get; set; }
        public string? Image1 { get; set; }
        public string? Image2 { get; set; }
        public string? Image3 { get; set; }
        public string? Image4 { get; set; }
    }
}

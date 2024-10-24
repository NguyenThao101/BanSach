namespace Webbanhang.Components.Data.Model
{
    public class SaleHistory
    {
        public int HistoryId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime CompletionDate { get; set; }
        public DateTime PaymentDate { get; set; }
        public string? UserName { get; set; }
        public decimal PriceTotal { get; set; }
        public int QuantityTotal { get; set; }
        public int ItemId { get; set; }
    }
}

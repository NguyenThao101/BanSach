namespace Webbanhang.Components.Data.Model
{
    public class OrderDetail
    {
        public int OrderId { get; set; }
        public string? Username { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime CompletionDate { get; set; }
        public DateTime PaymentDate { get; set; }
        public int ItemId { get; set; }
        public string? ItemName { get; set; }
        public int Quatity { get; set; }
        public int QuantityTotal { get; set; }
        public int PriceTotal { get; set; }
        //public string? PaymentMethod { get; set; }


    }
}

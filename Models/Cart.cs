using System.Text.Json.Serialization;

namespace CarPartStore.Models
{
    public class Cart
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid PartId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        [JsonIgnore]
        public virtual User User { get; set; }
    }
}

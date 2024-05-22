using CarPartStore.Enums;
using System.Text.Json.Serialization;

namespace CarPartStore.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public Guid UserId  { get; set; }
        public string OrderNumber { get; set; }
        public decimal OrderTotal { get; set; }
        public OrederStateEnum OrderStatus { get; set; }

        [JsonIgnore]
        public virtual User User { get; set; }
    }
}

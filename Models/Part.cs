namespace CarPartStore.Models
{
    public class Part
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Manufacturer { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal UnitePrice { get; set; }
        public decimal Discount { get; set; }
        public int Quantity { get; set; }
        public string ImageUrl { get; set; }
    }
}

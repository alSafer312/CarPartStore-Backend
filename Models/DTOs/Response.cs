namespace CarPartStore.Models.DTOs
{
    public class Response
    {
        public int StatusCode { get; set; }
        public string StatusMessage { get; set; }

        public  List<User> userList { get; set; }
        public User user { get; set; }
        
        public List<Part> partList { get; set; }
        public Part part { get; set; }

        public List<Cart> cartList { get; set; }
        public Cart cart { get; set; }

        public List<Order> orderList { get; set; }
        public Order order { get; set; }

        public List<OrderItem> ItemList { get; set; }
        public OrderItem orderItem { get; set; }
    }
}

namespace SalesManagementApi.DTO
{
    public class CreateOrderResponse
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public decimal TotalPrice { get; set; }
        public List<OrderItemResponse> Items { get; set; }
    }
}

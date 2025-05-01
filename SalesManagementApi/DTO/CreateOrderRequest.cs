namespace SalesManagementApi.DTO
{
    public class CreateOrderRequest
    {
        public string? CustomerId { get; set; } // required
        public List<CreateOrderItemRequest> Items { get; set; }
    }
}

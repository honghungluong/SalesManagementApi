using SalesManagementApi.Models;

namespace SalesManagementApi.Repository
{
    public interface IOrderRepository
    {
        List<Order> GetAll();
    }
}

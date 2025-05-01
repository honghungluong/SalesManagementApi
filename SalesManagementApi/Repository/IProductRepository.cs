using SalesManagementApi.Models;

namespace SalesManagementApi.Repository
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAll();

    }
}

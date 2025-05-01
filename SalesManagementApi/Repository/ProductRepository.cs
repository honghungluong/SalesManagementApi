using Microsoft.EntityFrameworkCore;
using SalesManagementApi.Data;
using SalesManagementApi.Models;

namespace SalesManagementApi.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly SalesDbContext _dbContext;

        public ProductRepository(SalesDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public async Task<List<Product>> GetAll()
        {
            return await _dbContext.Products.ToListAsync();
        }
    }
}

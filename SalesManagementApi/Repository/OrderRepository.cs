using Microsoft.EntityFrameworkCore;
using SalesManagementApi.Data;
using SalesManagementApi.Models;
using System;

namespace SalesManagementApi.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly SalesDbContext _dbContext;

        public OrderRepository(SalesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Order> GetAll()
        {
            return _dbContext.Orders
                .Include(o => o.OrderItems)
                .ToList();
        }
    }

}

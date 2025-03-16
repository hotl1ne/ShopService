using Microsoft.EntityFrameworkCore;
using ShopService.Domain.Entities;
using ShopService.Domain.Interfaces;
using ShopService.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopService.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DataContext _dataContext;

        public OrderRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<(string CategoryName, int QuantityPurchased, List<string> ProductsPurchased)>> GetCustomerCategory(Guid customerId)
        {
            var categories = await _dataContext.Orders
                .Where(o => o.CustomerId == customerId)
                .Join(_dataContext.OrderProducts,
                    o => o.Id,
                    op => op.OrderId,
                    (o, op) => new { op.ProductId, op.Quantity })
                .Join(_dataContext.Products,
                    op => op.ProductId,
                    p => p.Id,
                    (op, p) => new { p.Category, p.Name, op.Quantity })
                .GroupBy(p => p.Category)
                .Select(g => new
                {
                    CategoryName = g.Key,
                    QuantityPurchased = g.Sum(x => x.Quantity),
                    ProductsPurchased = g.Select(x => x.Name).Distinct().ToList()
                })
                .OrderByDescending(x => x.QuantityPurchased)
                .ToListAsync();

            return categories.Select(c => (c.CategoryName, c.QuantityPurchased, c.ProductsPurchased)).ToList();
        }


        public async Task<List<(Guid Id, string FullName, DateTime LastPurchaseDate)>> GetRecentBuyers(int days)
        {
            DateTime fromDate = DateTime.UtcNow.AddDays(-days);

            var buyers = await _dataContext.Orders
                .Where(o => o.OrderDate >= fromDate)
                .GroupBy(o => o.CustomerId)
                .Select(g => new
                {
                    UserId = g.Key,
                    LastPurchaseDate = g.Max(o => o.OrderDate)
                })
                .Join(_dataContext.Users,
                      o => o.UserId,
                      u => u.Id,
                      (o, u) => new
                      {
                          Id = u.Id,
                          FullName = u.FullName ?? "Unknown",
                          LastPurchaseDate = o.LastPurchaseDate
                      })
                .OrderByDescending(x => x.LastPurchaseDate)
                .ToListAsync();

            return buyers.Select(b => (b.Id, b.FullName, b.LastPurchaseDate)).ToList();
        }

    }
}

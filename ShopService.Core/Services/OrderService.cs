using AutoMapper;
using ShopService.Application.DTOs;
using ShopService.Application.Interfaces;
using ShopService.Domain.Interfaces;


namespace ShopService.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
        }

        public async Task<List<CustomerCategoryDTO>> GetCustomerCategories(Guid id)
        {
            var categories = await _orderRepository.GetCustomerCategory(id);

            var result = categories.Select(b=> new CustomerCategoryDTO
            {
                CategoryName = b.CategoryName,
                QuantityPurchased = b.QuantityPurchased,
                Products = b.ProductsPurchased,
            }).ToList();

            return result;
        }

        public async Task<List<RecentBuyersDTO>> GetRecentBuyers(int days)
        {
            var recentBuyers = await _orderRepository.GetRecentBuyers(days);

            var result = recentBuyers.Select(b => new RecentBuyersDTO
            {
                Id = b.Id,
                FullName = b.FullName,
                LastPurchaseDate = b.LastPurchaseDate
            }).ToList();

            return result;
        }
    }
}

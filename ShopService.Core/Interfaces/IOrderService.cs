using ShopService.Application.DTOs;


namespace ShopService.Application.Interfaces
{
    public interface IOrderService
    {
        Task<List<RecentBuyersDTO>> GetRecentBuyers(int days);
        Task<List<CustomerCategoryDTO>> GetCustomerCategories(Guid id);
    }
}

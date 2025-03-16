using ShopService.Domain.Entities;


namespace ShopService.Domain.Interfaces
{
    public interface IOrderRepository
    {
        Task<List<(Guid Id, string FullName, DateTime LastPurchaseDate)>> GetRecentBuyers(int days);
        Task<List<(string CategoryName, int QuantityPurchased, List<string> ProductsPurchased)>> GetCustomerCategory(Guid customerId);
    }
}


namespace ShopService.Application.DTOs
{
    public class CustomerCategoryDTO
    {
        public string CategoryName { get; set; } = string.Empty;
        public int QuantityPurchased { get; set; }
        public List<string> Products { get; set; }
    }
}

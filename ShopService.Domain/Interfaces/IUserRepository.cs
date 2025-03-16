using ShopService.Domain.Entities;


namespace ShopService.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetUsersByBirth(DateOnly birthDate);
    }
}

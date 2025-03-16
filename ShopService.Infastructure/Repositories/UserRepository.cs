using Microsoft.EntityFrameworkCore;
using ShopService.Domain.Entities;
using ShopService.Domain.Interfaces;
using ShopService.Infrastructure.Data;


namespace ShopService.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _dataContext;

        public UserRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<User>> GetUsersByBirth(DateOnly birthDate)
        {
            return await _dataContext.Users.Where(x => x.DateOfBirth == birthDate).ToListAsync();   
        }
    }
}

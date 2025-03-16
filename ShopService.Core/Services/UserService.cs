using AutoMapper;
using ShopService.Application.DTOs;
using ShopService.Application.Interfaces;
using ShopService.Domain.Interfaces;

namespace ShopService.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<List<UserDTO>> GetUsersByBirth(DateOnly birthDate)
        {
            var users = await _userRepository.GetUsersByBirth(birthDate);

            return _mapper.Map<List<UserDTO>>(users);
        }
    }
}

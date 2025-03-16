﻿using ShopService.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopService.Application.Interfaces
{
    public interface IUserService
    {
        Task<List<UserDTO>> GetUsersByBirth(DateOnly birthDate);
    }
}

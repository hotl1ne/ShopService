﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopService.Application.DTOs
{
    public class UserDTO
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public DateOnly DateOfBirth { get; set; }

    }
}

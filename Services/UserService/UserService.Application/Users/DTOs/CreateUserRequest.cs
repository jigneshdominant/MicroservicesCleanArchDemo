﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserService.Application.Users.DTOs
{
    public class CreateUserRequest
    {
        public string UserName { get; set; } = "";
        public string EmailID { get; set; } = "";
    }
}

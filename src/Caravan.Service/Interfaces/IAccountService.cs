﻿using Caravan.Service.Dtos.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caravan.Service.Interfaces
{
    public interface IAccountService
    {
        public Task<bool> RegisterAsync(AccountRegisterDto registerDto);
        public Task<bool> LoginAsync(AccountLoginDto loginDto);
    }
}
﻿using System.Threading.Tasks;
using Savitar.Domain.Models;

namespace Savitar.WebAssembly.Services.Contracts
{
    public interface IAuthorizeApi
    {
        Task Login(LoginParameters loginParameters);
        Task Register(RegisterParameters registerParameters);
        Task Logout();
        Task<UserInfo> GetUserInfo();
    }
}

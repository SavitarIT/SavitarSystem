﻿using Savitar.Domain.Models.Requests;
using Savitar.Domain.Shared.Wrapper;
using System.Threading.Tasks;

namespace Savitar.Services.Shared
{
    public interface IAccountsService
    {
        Task<IResult> UpdateProfileAsync(UpdateProfileRequest model, int userId);
        Task<IResult> ChangePasswordAsync(ChangePasswordRequest model, int userId);
    }
}
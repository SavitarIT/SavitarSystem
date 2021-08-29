using System;

namespace Savitar.Web.Server.Shared.Interfaces
{
    public interface ICurrentUserService
    {
        Guid UserId { get; }
    }
}

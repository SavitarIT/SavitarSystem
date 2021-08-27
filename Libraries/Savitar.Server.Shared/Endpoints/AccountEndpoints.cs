using System;

namespace Savitar.Server.Shared.Endpoints
{
    public static class AccountEndpoints
    {
        public static string Register       = "api/identity/account/register";
        public static string ChangePassword = "api/identity/account/changepassword";
        public static string UpdateProfile  = "api/identity/account/updateprofile";

        public static string GetUserProfile(Guid userId)
        {
            return $"api/identity/account/getUserProfile/{userId}";
        }
    }
}
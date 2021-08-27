﻿using System.Collections.Generic;

namespace Savitar.Domain.Models
{
    public class UserInfo
    {
        public bool IsAuthenticated { get; set; }
        public string Email { get; set; }
        public Dictionary<string, string> ExposedClaims { get; set; }
    }
}
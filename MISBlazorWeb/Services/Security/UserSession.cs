using System;

namespace MISBlazorWeb.Services.Security
{
    public class UserSession
    {
        public required string UserID { get; set; }
        public required string Department { get; set; }
    }
}


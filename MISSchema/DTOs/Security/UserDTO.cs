using System;
namespace MISSchema.DTOs.Security
{
    public class UserDTO
    {
        public required string UserId { get; set; } = "";
        public required string Role { get; set; } = "";
        public string DepartmentID { get; set; } = "";
        public string Email { get; set; } = "notdefinemail@vietbank.com.vn";
        public string Mobile { get; set; } = "";
        public string BranchCode { get; set; } = "";
        public string Name { get; set; } = "No name";


    }
}


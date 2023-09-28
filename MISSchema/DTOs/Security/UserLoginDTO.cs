using System;
namespace MISSchema.DTOs.Security
{
	public class UserLoginDTO
	{
		public required string UserID { set; get; }
		public required string Password { set; get; }
	}
}


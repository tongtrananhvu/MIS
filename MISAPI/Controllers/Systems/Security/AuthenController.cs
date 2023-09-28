using System;
using Microsoft.AspNetCore.Mvc;
using MISSchema.DTOs.Security;
using Microsoft.AspNetCore.Authorization;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace MISAPI.Controllers.Systems.Security
{
	[ApiController]
    [Route("[controller]")]
    public class AuthenController:ControllerBase
	{
        private readonly ILogger<AuthenController> _logger;
        private readonly IConfiguration _config;

        public AuthenController(ILogger<AuthenController> logger,IConfiguration config)
		{
			_logger = logger;
            _config = config;
		}

        [AllowAnonymous]
        [HttpPost]
		public IActionResult login([FromBody] UserLoginDTO userlogin)
		{
            IActionResult response = Unauthorized();
            var user = AuthenticateUser(userlogin);

            if (user != null)
            {
                var tokenString = GenerateJSONWebToken(user);
                response = Ok(new { token = tokenString ,
                                     userinfo = user});
            }

            return response;
        }

        private string GenerateJSONWebToken(UserDTO userinfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["MIS-JWT:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            //create claims details based on the user information
            var claims = new[] {
                        new Claim("UserId", userinfo.UserId),
                        new Claim("Email", userinfo.Email)
                    };
            var token = new JwtSecurityToken(_config["MIS-JWT:Issuer"],
              _config["MIS-JWT:Issuer"],
              claims,
              expires: DateTime.Now.AddMinutes(10),
              signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        private UserDTO? AuthenticateUser(UserLoginDTO userlogin) {
            UserDTO? user = null;
            if (userlogin.UserID == "vutta") {
                user = new UserDTO { UserId = "vutta", Role="admin"};
            }
            return user;

        }
       }
}


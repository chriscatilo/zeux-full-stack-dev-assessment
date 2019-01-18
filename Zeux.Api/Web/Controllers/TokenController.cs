using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace Zeux.Api.Web.Controllers
{
    [ApiController]
    public class TokenController : ControllerBase
    {
        /// <summary>
        /// Returns a perpetual token for demo
        /// <returns>
        /// eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJBY2NvdW50TmFtZSI6IkpvaG4gRG9lIiwiQWNjb3VudE51bWJlciI6IjEyMzQ1Njc4OTAifQ.zLyKWzsoFJPlCyoLxItx5J-oeXIvn_DkHdUlId0s6A8
        /// </returns>
        [HttpGet, Route("[controller]")]
        public IActionResult RequestToken(string accountNumber = "1234567890")
        {
            var claims = new[]
            {
                new Claim("AccountName", "John Doe"),
                new Claim("AccountNumber", accountNumber),
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("zeux-full-stack-dev-assessment"));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                claims: claims,
                signingCredentials: credentials);

            return Ok(new JwtSecurityTokenHandler().WriteToken(token));
        }
    }
}
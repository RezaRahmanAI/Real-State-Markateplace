using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Real_Estate.server.api.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Real_Estate.server.api.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly Microsoft.Extensions.Configuration.IConfiguration _configuration;

        public AuthenticationController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            Microsoft.Extensions.Configuration.IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginApiModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(model.email);
                if (user != null)
                {
                    var res = await _signInManager.CheckPasswordSignInAsync(user, model.password, false);
                    if (res.Succeeded)
                    {
                        

                        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetValue<string>("Jwt:Key")));
                        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                        var claims = new[] {
                            new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                            new Claim(JwtRegisteredClaimNames.UniqueName, user.UserName),
                            new Claim("id", user.Id),
                        };

                        var token = new JwtSecurityToken(
                            _configuration.GetValue<string>("Jwt:Issuer"),
                            _configuration.GetValue<string>("Jwt:Audience"),
                            claims: claims,
                            expires: DateTime.UtcNow.AddHours(1),
                            signingCredentials: creds
                            );

                        var result = new
                        {
                            token = new JwtSecurityTokenHandler().WriteToken(token),
                            expiration = token.ValidTo,
                            id = user.Id,
                            email = user.Email
                        };

                        return Ok(result);
                    }
                    else
                    {
                        return Unauthorized();
                    }
                }

            }


            return Unauthorized();
        }

        [Authorize]
        [HttpPost]
        [Route("refreshtoken")]
        public async Task<IActionResult> RefreshToken(string token)
        {

            if (ModelState.IsValid)
            {
                string userid = string.Empty;
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                if (identity != null)
                {
                    IEnumerable<Claim> claims = identity.Claims;

                    userid = identity.FindFirst("id").Value;
                }

                var user = await _userManager.FindByIdAsync(userid);
                if (user != null)
                {
                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetValue<string>("Jwt:Key")));
                    var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                    var claims = new[] {
                        new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.UniqueName, user.UserName),
                        new Claim("id", user.Id),
                    };

                    var newtoken = new JwtSecurityToken(
                        _configuration.GetValue<string>("Jwt:Issuer"),
                        _configuration.GetValue<string>("Jwt:Audience"),
                        claims: claims,
                        expires: DateTime.UtcNow.AddHours(1),
                        signingCredentials: creds
                        );

                    var result = new
                    {
                        token = new JwtSecurityTokenHandler().WriteToken(newtoken),
                        expiration = newtoken.ValidTo
                    };

                    return Ok(result);
                    
                }

            }

            return Unauthorized();
        }

    }

    public class LoginApiModel
    {
        public string email { get; set; }
        public string password { get; set; }
      
    }
}

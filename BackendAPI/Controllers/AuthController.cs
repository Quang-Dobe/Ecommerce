﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SharedView.DTO.Account;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BackendAPI.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration config;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly UserManager<IdentityUser> userManager;

        public AuthController(IConfiguration config, SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            this.config = config;
            this.signInManager = signInManager;
            this.userManager = userManager;
        }

        [HttpPost]
        public async Task<IResult> Login([FromBody] LoginRequestDTO loginRequestModel)
        {
            // Get request successfully
            var result = await signInManager.PasswordSignInAsync(loginRequestModel.UserName, loginRequestModel.Password, false, lockoutOnFailure: true);

            if (result.Succeeded)
            {
                var issuer = config["Jwt:Issuer"];
                var audience = config["Jwt:Audience"];
                var key = Encoding.ASCII.GetBytes
                (config["Jwt:Key"]);
                // Create new token-hash-tool to hash issuer, audience, key
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new[]
                    {
                new Claim("Id", Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Sub, loginRequestModel.UserName),
                new Claim(JwtRegisteredClaimNames.Email, loginRequestModel.UserName),
                new Claim(JwtRegisteredClaimNames.Jti,
                Guid.NewGuid().ToString())
             }),
                    Expires = DateTime.UtcNow.AddMinutes(5),
                    Issuer = issuer,
                    Audience = audience,
                    SigningCredentials = new SigningCredentials
                    (new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha512Signature)
                };

                var identityUser = await userManager.FindByEmailAsync(loginRequestModel.UserName);
                var roles = await userManager.GetRolesAsync(identityUser);

                foreach (var role in roles)
                {
                    tokenDescriptor.Subject.AddClaim(new Claim(ClaimTypes.Role, role));
                }

                // generate token with the above information
                var tokenHandler = new JwtSecurityTokenHandler();
                var token = tokenHandler.CreateToken(tokenDescriptor);
                var stringToken = tokenHandler.WriteToken(token);

                return Results.Ok(stringToken);
            }

            return Results.Unauthorized();
        }

        [HttpPost]
        public async Task<IResult> Register([FromBody] RegisterRequestDTO registerRequestModel)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser
                {
                    //Id = Guid.NewGuid().ToString(),
                    UserName = registerRequestModel.UserName,
                    Email = registerRequestModel.UserName
                };

                var createUserResult = await userManager.CreateAsync(user, registerRequestModel.Password);

                if (createUserResult.Succeeded)
                {
                    return Results.Ok();
                }
                else
                {
                    return Results.BadRequest(createUserResult.Errors);
                }
            }

            return Results.BadRequest(ModelState.Values.SelectMany(x => x.Errors));
        }
    }
}
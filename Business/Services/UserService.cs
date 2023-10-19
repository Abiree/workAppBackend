using Business.IServices;
using Entities.Dtos;
using Entities.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.Extensions.Configuration;

namespace Business.Services
{
    public class UserService:IUserService
    {

        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _configuration;
        private User? _user;
        public UserService(UserManager<User> userManager, IConfiguration configuration) { 
            _userManager = userManager;
            _configuration = configuration;
        }



        public async Task<IdentityResult> register(UserDTO user_dto)
        {

            var user = new User
            {
                FirstName = user_dto.FirstName,
                LastName = user_dto.LastName,
                Email = user_dto.Email,
                DateBirth = user_dto.DateBirth,
                UserName = user_dto.FirstName + user_dto.LastName,
            };
            try {
                var result = await _userManager.CreateAsync(user, user_dto.Password);
                return result;
            }
            catch(Exception ex) {
                throw ex;
            }
           

        }

        public async Task<bool> ValidateUser(UserForAuthenticationDto userForAuth) {
            _user = await _userManager.FindByEmailAsync(userForAuth.Email);
            var result = (_user != null && await _userManager.CheckPasswordAsync(_user, userForAuth.Password));  
            return result; 
        }

        public async Task<string> CreateToken() { 
            var signingCredentials = GetSigningCredentials(); 
            var claims = await GetClaims();
            var tokenOptions = GenerateTokenOptions(signingCredentials, claims); 
            return new JwtSecurityTokenHandler().WriteToken(tokenOptions); }

        private SigningCredentials GetSigningCredentials() {
            var jwtSettings = _configuration.GetSection("JwtSettings");
            var key = Encoding.UTF8.GetBytes(jwtSettings["SECRET_KEY"]); 
            var secret = new SymmetricSecurityKey(key); 
            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256); }

        private async Task<List<Claim>> GetClaims() { 
            var claims = new List<Claim> { new Claim(ClaimTypes.Name, _user.Email) }; 
            var roles = await _userManager.GetRolesAsync(_user); 
            foreach (var role in roles) { claims.Add(new Claim(ClaimTypes.Role, role)); }
            return claims; }

        private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims) { 
            var jwtSettings = _configuration.GetSection("JwtSettings");
            var tokenOptions = new JwtSecurityToken(issuer: jwtSettings["validIssuer"], audience: jwtSettings["validAudience"], claims: claims, expires: DateTime.Now.AddMinutes(Convert.ToDouble(jwtSettings["expires"])), signingCredentials: signingCredentials); 
            return tokenOptions; }

    }
}

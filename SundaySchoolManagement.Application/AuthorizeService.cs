using Microsoft.IdentityModel.Tokens;
using SundaySchoolManagement.Application.Interfaces;
using SundaySchoolManagement.Domain.DatabaseEntities;
using SundaySchoolManagement.Infrastructure.Repositories;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SundaySchoolManagement.Application
{
    public class AuthorizeService : IAuthorizeService
    {
        private readonly IUserRepository _userRepository;

        public AuthorizeService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User Authenticate(string email, string password)
        {
            var user = _userRepository.GetByEmail(email);

            if (user == null)
                return null;

            if (user.Email.Equals(email) && user.Password.Equals(password)) return user;
            return null;
        }

        public string GenerateJwtToken(User user, string secretKey)
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            var key = Encoding.ASCII.GetBytes(secretKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", user.Id.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

    }
}

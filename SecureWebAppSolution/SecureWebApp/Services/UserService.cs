﻿using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using SecureWebApp.Entities;
using SecureWebApp.Helpers;
using SecureWebApp.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;


namespace SecureWebApp.Services
{
    public class UserService : IUserService
    {
        private List<User> _users = new List<User>
        {
            new User { Id = 1, FirstName = "Bhupendra", LastName = "Walhekar",
                        Username = "bhupendra", Password = "pass123" },
             new User { Id = 2, FirstName = "Ajinkya", LastName = "Tambade",
                        Username = "ajinkya", Password = "pass123" },
             new User { Id = 3, FirstName = "Ritesh", LastName = "Chopra",
                        Username = "ritesh", Password = "pass123" },
             new User { Id = 4, FirstName = "Shreedhar", LastName = "Patil",
                        Username = "shreedhar", Password = "pass123" }
        };

        private readonly AppSettings _appSettings;
        public UserService(IOptions<AppSettings> appSettings)
        {
              _appSettings = appSettings.Value;
        }

        public AuthenticateResponse Authenticate(AuthenticateRequest model)
        {
            var user = _users.SingleOrDefault(x => x.Username == model.Username && x.Password == model.Password);

            if (user == null) return null;
            var token = generateJwtToken(user);
            return new AuthenticateResponse(user, token);
        }

        public IEnumerable<User> GetAll()
        {
            return _users;
        }

        public User GetById(int id)
        {
            return _users.FirstOrDefault(x => x.Id == id);
        }

        private string generateJwtToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", user.Id.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                                                           SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);

        }
    }
}

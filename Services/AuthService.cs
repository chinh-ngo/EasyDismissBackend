using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Backend.Data;
using Backend.Helpers;
using Backend.Models;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Backend.Services
{
	public interface IAuthService
    {
        AuthResponse? Authenticate(AuthRequest request);
		IEnumerable<User> GetUsers();
		User GetUserById(long id);
    }

	public class AuthService : IAuthService
	{
        // Temporary
        private readonly List<User> users = FakeData.getAll();
        private readonly AppSettings _appSettings;

		public AuthService(IOptions<AppSettings> appSettings)
		{
            _appSettings = appSettings.Value;
		}

        public AuthResponse? Authenticate(AuthRequest request)
        {
            
            var user = users.SingleOrDefault(u => u.Email == request.Email && u.Password == request.Password);

            if (user == null) return null;

            string token = GenerateJWTToken(user);

            return new AuthResponse(user, token);
        }

        public User GetUserById(long id)
        {
            return users.Single(u => u.Id == id);
        }

        public IEnumerable<User> GetUsers()
        {
            return users;
        }

        private string GenerateJWTToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor {

                Subject = new ClaimsIdentity(new[] { new Claim("id", user.Id.ToString()) }),
                Expires = DateTime.Now.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}


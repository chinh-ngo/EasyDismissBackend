namespace Backend.Models
{
	public class AuthResponse
	{
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }

        public AuthResponse(User user, string token)
		{
            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Email = user.Email;
            Token = token;
		}
	}
}


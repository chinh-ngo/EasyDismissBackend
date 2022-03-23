using System.Text.Json.Serialization;

namespace Backend.Models
{
	public class User
	{
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string role { get; set; }
        public int CarlineId { get; set; }

        [JsonIgnore]
        public string Password { get; set; }
    }
}


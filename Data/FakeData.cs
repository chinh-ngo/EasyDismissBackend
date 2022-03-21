using Backend.Models;

namespace Backend.Data
{
    internal static class FakeData
    {
        internal static List<User> getAll() => new List<User> {
            new User{
                Id = 1,
                FirstName = "Musa",
                LastName = "Ugurlu",
                Email = "mu@sa.com",
                Password = "123456"
            }
        };

    }
    
}
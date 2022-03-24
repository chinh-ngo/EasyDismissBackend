using Backend.Data;
using Backend.Models;

namespace Backend.Services
{
    public class CarlinesService
    {
        private EDDbContext _dbContext;
        public CarlinesService(EDDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Carline> Carlines()
        { 
            List<Carline> carlines = FakeData.getAllCarlines();
            return carlines;
        }
    }
}

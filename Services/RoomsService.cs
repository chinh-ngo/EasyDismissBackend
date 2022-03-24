using Backend.Data;
using Backend.Helpers;
using Backend.Models;
using Microsoft.Extensions.Options;

namespace Backend.Services
{
    public class RoomsService
    {

        private EDDbContext _dbContext;
        public RoomsService(EDDbContext dbContext)
        { 
            _dbContext = dbContext;
        }

        public List<Room> Rooms()
        {
            List<Room> rooms = FakeData.getAllRooms();
            return rooms;
        }

    }
}

using Backend.Models;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Backend.Hubs
{
    public class DispatchHub : Hub
    {
        public async Task SendStudentData(DispatchedStudent dispatchedStudent)
        {
            // Call the broadcastMessage method to update clients.
            await Clients.All.SendAsync("broadcastStudent", dispatchedStudent);
        }
    }
}

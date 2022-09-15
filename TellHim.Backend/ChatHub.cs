using Microsoft.AspNetCore.SignalR;
using TellHim.Domain.Models;

namespace TellHim.Backend
{
    public class ChatHub : Hub
    {
        public async Task Send(string username, string message)
        {
            await Clients.All.SendAsync("Receive", username, message);
        }
    }
}

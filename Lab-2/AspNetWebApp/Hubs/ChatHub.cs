using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace AspNetWebApp.Hubs
{
    public class ChatHub : Hub
    {

        public async Task BroadCastMessage(string username, string message)
        {
            await Clients.All.SendAsync("GetMessage", username, message);
        }

    }
}

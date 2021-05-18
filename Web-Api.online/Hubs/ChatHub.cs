﻿using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Web_Api.online.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
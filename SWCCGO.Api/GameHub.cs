using Microsoft.AspNetCore.SignalR;

namespace SWCCGO.Api;

public class GameHub: Hub
{
    public async Task Send(string name, string message)
    {
        await Clients.All.SendAsync("broadcastMessage", name, message);
    }
}
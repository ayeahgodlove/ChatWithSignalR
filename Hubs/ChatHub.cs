using ChatWithSignalR.Hubs.Clients;
using ChatWithSignalR.Models;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace ChatWithSignalR.Hubs
{
    public class ChatHub : Hub<IChatClient>
    { }
}

using ChatWithSignalR.Models;
using System.Threading.Tasks;

namespace ChatWithSignalR.Hubs.Clients
{
    public interface IChatClient
    {
        Task ReceiveMessage(ChatMessage message);
    }
}

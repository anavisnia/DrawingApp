using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace DrawingApp.Hubs
{
    public class DrawingHub : Hub
    {
        public async Task SendCoord(int x, int y)
        {
            await Clients.Others.SendAsync("receiveCoord", x, y);
        }
    }
}

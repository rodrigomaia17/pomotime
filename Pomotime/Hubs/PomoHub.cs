using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;
using Pomotime.Models;

namespace Pomotime.Hubs
{
    public class PomoHub : Hub
    {
        public static IList<Room> Rooms;

        static PomoHub()
        {
            Rooms = new List<Room>();
            
        }

        public void Hello()
        {
            Clients.All.hello();
            Groups.Add()
        }

        public Task JoinRoom(Guid roomId)
        {
            return Groups.Add(Context.ConnectionId, roomId.ToString());
        }
    }

    public class PomoGroup : GroupManager
    {
      
    }
}
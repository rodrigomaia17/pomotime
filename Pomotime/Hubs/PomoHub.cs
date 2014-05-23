using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Pomotime.Hubs
{
    public class PomoHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Pomotime.Hubs;
using Pomotime.Models;

namespace Pomotime.Controllers
{
    public class RoomController : Controller
    {
        //
        // GET: /Room/2
        public ActionResult Room(Guid id)
        {
            return View("Index");
        }
        //
        // GET: /NewRoom
        public ActionResult NewRoom()
        {
            var room = new Room();
            room.PeopleList.Add(new Person(){ Name = "Guest"});
            
            PomoHub.Rooms.Add(room);

            return RedirectToAction("Room", new RouteValueDictionary()
            {
              {"id",room.Id}
            });
        }


	}
}
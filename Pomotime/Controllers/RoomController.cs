using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Pomotime.Models;

namespace Pomotime.Controllers
{
    public class RoomController : Controller
    {
        protected readonly IList<Room> Rooms;

        public RoomController()
        {
            Rooms = new List<Room>();
        }

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
            
            return RedirectToAction("Room", new RouteValueDictionary()
            {
              {"id",room.Id}
            });
        }


	}
}
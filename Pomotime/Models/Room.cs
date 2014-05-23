using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Pomotime.Models
{
    public class Room
    {
        public Guid Id { get; set; } 
        public Stopwatch Timer { get; set; }

        public IList<Person> PeopleList { get; set; }

        public Room()
        {
            Id = Guid.NewGuid();
            Timer = new Stopwatch();
            PeopleList = new List<Person>();
        }
    }
}
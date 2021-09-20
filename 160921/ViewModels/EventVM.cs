using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _160921.Models;

namespace _160921.ViewModels
{
    public class EventVM
    {
        public Background Background { get; set; }
        public IEnumerable<Event> Event { get; set; }
        public IEnumerable<Speaker> Speakers { get; set; }
        public IEnumerable<EventSpeaker> EventSpeakers { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }

    }
}

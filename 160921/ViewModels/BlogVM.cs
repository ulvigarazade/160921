using _160921.DAL;
using _160921.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _160921.ViewModels
{
    public class BlogVM
    {
        public Background Background { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }
        public IEnumerable<Event> Events { get; set; }

    }
}

using _160921.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _160921.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public AboutSlider AboutSlider { get; set; }
        public IEnumerable<Service> Services { get; set; }
        public AboutUs AboutUs { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<CourseDetail> CourseDetails { get; set; }
        public NoticeVideo NoticeVideo { get; set; }
        public IEnumerable<NoticeBoard> NoticeBoards { get; set; }
        public IEnumerable<Event> Events { get; set; }
        public IEnumerable<Testimonial> Testimonials { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }

    }

}


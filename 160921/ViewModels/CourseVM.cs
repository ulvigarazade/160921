using _160921.DAL;
using _160921.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _160921.ViewModels
{
    public class CourseVM
    {
        public Background Background { get; set; }
        public IEnumerable<Course> Course { get; set; }
        public IEnumerable<CourseDetail> CourseDetails { get; set; }
        public IEnumerable<CourseFeature> CourseFeatures { get; set; }
    }
}

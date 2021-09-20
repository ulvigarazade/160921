using _160921.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _160921.ViewModels
{
    public class TeacherVM
    {
        public Background Background { get; set; }
        public IEnumerable<Teacher> Teachers { get; set; }
        public IEnumerable<AboutTeacher> AboutTeachers { get; set; }
        public IEnumerable<Skill> Skills { get; set; }
        public IEnumerable<Department> Departments { get; set; }
        public IEnumerable<Hobby> Hobbies { get; set; }
        public IEnumerable<TeacherHobby> TeacherHobbies { get; set; }

    }

}

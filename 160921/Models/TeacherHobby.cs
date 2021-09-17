using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _160921.Models
{
    public class TeacherHobby
    {
        public int Id { get; set; }
        public int HobbyId { get; set; }
        public virtual Hobby Hobby { get; set; }
        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}

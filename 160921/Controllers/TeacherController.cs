using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _160921.DAL;
using _160921.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace _160921.Controllers
{
    public class TeacherController : Controller
    {
        private readonly AppDbContext _db;
        public TeacherController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            TeacherVM teacherVM = new TeacherVM
            {
                Background = _db.Backgrounds.FirstOrDefault(),
                Teachers = _db.Teachers,
                AboutTeachers = _db.AboutTeachers,
                Skills = _db.Skills,
                Hobbies = _db.Hobbies,
                TeacherHobbies = _db.TeacherHobbies
            };
            return View(teacherVM);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VinhSyIntro.Data;
using VinhSyIntro.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VinhSyIntro.Controllers
{
    [Route("journey")]
    public class JourneyController : Controller
    {
        private readonly ApplicationDbContext _courseDb;

        public JourneyController(ApplicationDbContext courseDb)
        {
            _courseDb = courseDb;
        }

        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            var courses = _courseDb.Courses.ToList();
            
            var pLanguages = _courseDb.Programming_Languages.ToList();
            
            var i = _courseDb;
            
            Course_PLanguage connection = new Course_PLanguage();
            
            connection.CourseDisplay = courses;
            connection.PLDisplay = pLanguages;
            
            return View(connection);
        }


        [HttpGet, Route("create")]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost, Route("create")]
        public IActionResult Create(Course course)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            Console.WriteLine(course.Course_Name);
            Console.WriteLine(course.Course_Code);
            Console.WriteLine(course.Grade);
            Console.WriteLine(course.Method);

            
            return RedirectToAction("Index");
        }
    }
}

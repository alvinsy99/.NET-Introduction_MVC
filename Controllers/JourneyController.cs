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
            Console.WriteLine(courses + "HERE HEREH EHREREHREH");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            var pLanguages = _courseDb.Programming_Languages.ToList();
            //Console.WriteLine(_courseDb.Courses.ToArray() + "course only");
            //Console.WriteLine(courses.ToList().OrderBy(p => p.Course_Name) + "Course with tolist");
            //Console.WriteLine(courses.FirstOrDefault().Course_Code);


            //Console.WriteLine(pLanguages.ToList());
            var i = _courseDb;
            foreach (Course sth in courses)
            {
                //var connection = _courseDb.Programming_Languages.Where(p => p.Id == sth.Id);
                //foreach (Programming_Language pl in connection)
                //{
                //    Console.WriteLine(pl.PLanguage_Name);
                //}
                //Console.WriteLine(sth.Course_Name);
                //Console.WriteLine(sth.Programming_Id);
                //Console.WriteLine(m);
            }

            Console.WriteLine(courses + "hi hihiahsihaishai");
            Course_PLanguage connection = new Course_PLanguage();
            Console.WriteLine(connection + "TESTING TEANSIOFNASDONAS");
            connection.CourseDisplay = courses;
            connection.PLDisplay = pLanguages;
            
            return View(connection);
        }


        // Journey Index
        //[HttpGet]
        //public ActionResult<IEnumerable<Course>> Index()
        //{
        //    var courses = _courseDb.Courses.ToArray();

        //    return Ok(courses);
        //}

        [HttpGet, Route("Create")]
        public IActionResult Create()
        {
            return View();
        }


    }
}

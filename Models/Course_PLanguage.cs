using System;
using System.Collections.Generic;

namespace VinhSyIntro.Models
{
    public class Course_PLanguage
    {
        public ICollection<Course> CourseDisplay { get; set; }
        public ICollection<Programming_Language> PLDisplay { get; set; }

        
    }
}

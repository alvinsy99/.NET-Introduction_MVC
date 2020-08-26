using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VinhSyIntro.Models
{
    public class Programming_Language
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string PLanguage_Name { get; set; }

        public ICollection<Course> Courses { get; set; }
        //[Required]
        //public ICollection<Usage> Usages { get; set; }

        //[ForeignKey("Course")]
        //public int Course_Id { get; set; }
        //public Course Course { get; set; }

        
    }
}
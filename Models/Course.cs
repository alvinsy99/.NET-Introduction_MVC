using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VinhSyIntro.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Course_Name { get; set; }

        
        public string? Course_Code { get; set; }

        
        public double? Grade { get; set; }

        [Required]
        public string Method { get; set; }

        [ForeignKey("Programming_Language")]
        public int Programming_Id { get; set; }
        public Programming_Language Programming_Language { get; set; }
        //public ICollection<Programming_Language> Programming_Languages { get; set; }

    }
}

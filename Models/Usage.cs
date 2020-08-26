using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VinhSyIntro.Models
{
    public class Usage
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Framework { get; set; }

        //[ForeignKey("Programming_Language")]
        //public int Programming_Id { get; set; }
        public Programming_Language Programming_Languages { get; set; }
    }
}

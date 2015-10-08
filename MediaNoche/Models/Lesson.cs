using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MediaNoche.Models
{
    public class Lesson
    {//Level=LessonNum=,Excersizes=
        public int ID { get; set; }

        [DisplayName("רמה:")]
        [Required]
        public int Level { get; set; }

        [DisplayName("מספר שיעור:")]
        [Required]
        public int LessonNum { get; set; }

        [DisplayName("תרגילים:")]
        [Required]
        public ICollection<Excersize> Excersizes { get; set; }
    }
}
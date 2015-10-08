using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MediaNoche.Models
{
    public class EveningLesson
    {//ActiveID=,Level=,LessonNum=,Actives,Excersizes

        public int ID { get; set; }

        [DisplayName("מפעיל:")]
        [Required]
        public int ActiveID { get; set; }

        [DisplayName("רמה:")]
        [Required]
        public int Level { get; set; }

        [DisplayName("תת רמה:")]
        [Required]
        public int LessonNum { get; set; }

        [DisplayName("מדריכים:")]
        [Required]
        public virtual ICollection<Active> Actives { get; set; }

        [DisplayName("תרגילים:")]
        [Required]
        public ICollection<Excersize> Excersizes { get; set; }
    }
}
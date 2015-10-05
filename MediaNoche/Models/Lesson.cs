using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MediaNoche.Models
{
    public class Lesson
    {//Level=LessonNum=,Excersizes=
        public int ID { get; set; }
        public int Level { get; set; }
        public int LessonNum { get; set; }
        public List<Excersize> Excersizes { get; set; }
    }
}
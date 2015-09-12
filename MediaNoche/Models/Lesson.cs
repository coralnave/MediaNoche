using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MediaNoche.Models
{
    public class Lesson
    {
        public int ID { get; set; }
        public int Level { get; set; }
        public int ClassNum { get; set; }
        public List<Excersize> Excersizes { get; set; }
    }
}
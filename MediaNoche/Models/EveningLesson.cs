using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MediaNoche.Models
{

    public class EveningClass
    {
        public int ID { get; set; }
        public int ActiveID { get; set; }
        public int Level { get; set; }
        public int ClassNum { get; set; }
        public virtual ICollection<Active> Actives { get; set; }
        public List<Excersize> Excersizes { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MediaNoche.Models
{
    public class Evening
    {
        public int ID { get; set; }
        public int EveningClassID { get; set; }
        public DateTime Date { get; set; }
        public ICollection<EveningClass> EveningClasses { get; set; }
        public Active EveningManager { get; set; }
        public Active DJ { get; set; }
        /*להוסיף בעלי תפקידים*/
    }
}
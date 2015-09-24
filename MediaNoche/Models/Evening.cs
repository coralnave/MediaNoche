using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MediaNoche.Models
{
    public class Evening
    {//EveningClassID=,Date,Concept,DJ,Announcer,EveningManager=,EveningManagerAssistant=,IntroductoryRateGuide=
        public int ID { get; set; }
        public int EveningClassID { get; set; }
        public DateTime Date { get; set; }
        public string Concept { get; set; }
        public ICollection<EveningClass> EveningLessons { get; set; }
        public Active DJ { get; set; }
        public Active Announcer { get; set; }
        public Active EveningManager { get; set; }
        public Active EveningManagerAssistant { get; set; }
        public Active IntroductoryRateGuide { get; set; }
    }
}
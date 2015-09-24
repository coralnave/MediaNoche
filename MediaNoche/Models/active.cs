using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MediaNoche.Models
{
    public enum Role
    {
        DJ,
        Announcer,
        Guide,
        GuideAssistant,
        IntroductoryRateGuide,
        EveningManager,
        EveningManagerAssistant
    }

    public class Active
    {//FirsName=,LastName=,Birthday=,Availability=,Roles=,Picture=,Summary=
        public int ID { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public bool Availability { get; set; }
        public Role[] Roles { get; set; }
        public string Picture { get; set; }
        public string Summary { get; set; }
    }
}
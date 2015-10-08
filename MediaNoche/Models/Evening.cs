using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MediaNoche.Models
{
    public class Evening
    {//EveningLessonID=,Date,Concept,DJ,Announcer,EveningManager=,EveningManagerAssistant=,IntroductoryRateGuide=
        public int ID { get; set; }
        [DisplayName("שיעור ערב:")]
        [Required]
        public int EveningLessonID { get; set; }

        [DisplayName("תאריך:")]
        [Required]
        public DateTime Date { get; set; }

        [DisplayName("קונסיפט:")]
        [Required]
        public string Concept { get; set; }

        [DisplayName("שיעורים:")]
        public ICollection<EveningLesson> EveningLessons { get; set; }

        [DisplayName("דיג'י:")]
        public Active DJ { get; set; }

        [DisplayName("מכריז:")]
        public Active Announcer { get; set; }

        [DisplayName("מנהל ערב:")]
        public Active EveningManager { get; set; }

        [DisplayName("עוזר מנהל ערב:")]
        public Active EveningManagerAssistant { get; set; }

        [DisplayName("משהו מסובך לאללה:")]
        public Active IntroductoryRateGuide { get; set; }
    }
}
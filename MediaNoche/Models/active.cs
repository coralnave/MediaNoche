using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [StringLength(20, ErrorMessage = "First name cannot be longer than 20 characters.")]
        [DisplayName("שם המדריך:")]
        [Required]
        public string FirsName { get; set; }

        [DisplayName("שם משפחה:")]
        [Required]
        public string LastName { get; set; }

        [DisplayName("יום הולדת:")]
        [Required]
        public DateTime Birthday { get; set; }

        [DisplayName("זמינות:")]
        [Required]
        public bool Availability { get; set; }

        [DisplayName("תפקידים:")]
        public ICollection<Role> Roles { get; set; }

        public string Picture { get; set; }

        [NotMapped]
        [DisplayName("תמונת:")]
        public HttpPostedFileBase PictureFileHandler { get; set; }

        [DisplayName("סיכום:")]
        [Required]
        public string Summary { get; set; }
    }
}
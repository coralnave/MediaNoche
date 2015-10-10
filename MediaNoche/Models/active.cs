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

        [StringLength(20, ErrorMessage = " שם לא יכיל יותר מ-20 תווים.")]
        [DisplayName("שם המדריך:")]
        [Required]
        public string FirsName { get; set; }

        [StringLength(20, ErrorMessage = " שם משפחה לא יכיל יותר מ-20 תווים.")]
        [DisplayName("שם משפחה:")]
        [Required]
        public string LastName { get; set; }

        [DisplayName("יום הולדת:")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [DisplayName("זמינות:")]
        public bool Availability { get; set; }

        [DisplayName("תפקידים:")]
        public ICollection<Role> Roles { get; set; }

        [DisplayName("תמונת:")]
        public string Picture { get; set; }

        [NotMapped]
        [DisplayName("תמונת:")]
        public HttpPostedFileBase PictureFileHandler { get; set; }

        [StringLength(200, ErrorMessage = " הסיכום לא יכיל יותר מ-200 תווים.")]
        [DisplayName("סיכום:")]
        [Required]
        public string Summary { get; set; }
    }
}
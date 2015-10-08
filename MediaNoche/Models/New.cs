using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MediaNoche.Models
{
    public class New
    {
        public int ID { get; set; }

        [StringLength(20, ErrorMessage = "First name cannot be longer than 20 characters.")]
        [DisplayName("כותרת:")]
        [Required]
        public string Title { get; set; }

        [DisplayName("החדשות:")]
        [Required]
        public string ShortInfo { get; set; }

        [DisplayName("חדשות לתאריך:")]
        [Required]
        public DateTime UpdateForDate { get; set; }
    }
}
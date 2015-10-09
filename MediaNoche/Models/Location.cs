using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MediaNoche.Models
{
    public class Location
    {
        public int ID { get; set; }

        [DisplayName("שם המקום")]
        [Required]
        public string Title { get; set; }

        [DisplayName("מידע למשתמש")]
        [Required]
        public string ShortInfo { get; set; }

        [DisplayName("כתובות")]
        [Required]
        public string Addres { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Web;

namespace MediaNoche.Models
{
    public class Excersize
    {//Name=,Video=,
        public int ID { get; set; }

        [DisplayName("שם התרגיל:")]
        [Required]
        public string Name { get; set; }

        [NotMapped]
        [DisplayName("סרטון:")]
        public HttpPostedFileBase videoFileHandler { get; set; }

        public string Video { get; set; }
    }
}

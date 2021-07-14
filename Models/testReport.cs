using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Covid_19.Models
{
    public class testReport
    {
        public int id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Contact")]
        public string Contact { get; set; }

        [Display(Name = "Report")]
        public string Report { get; set; }


        [Display(Name = "Date")]
        public DateTime TestDate { get; set; }

        public Doctor doctor { get; set; }

        public Patient patient { get; set; }

    }
}

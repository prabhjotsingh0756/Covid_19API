using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Covid_19.Models
{
    public class Login
    {
        public int id { get; set; }


        [Display(Name = "Email")]
        public string CarModel { get; set; }


        [Display(Name = "Password ")]
        public string Password { get; set; }

    }
}

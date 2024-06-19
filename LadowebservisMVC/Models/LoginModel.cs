using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LadowebservisMVC.Models
{
    public class LoginModel
    {
        [Display(Name = "Prihlasovacie meno")]
        [Required(ErrorMessage = "Prihlasovacie meno musí byť zadané")]
        public string Email { get; set; }

        [Display(Name = "Heslo")]
        [Required(ErrorMessage = "Heslo musí byť zadané")]
        [DataType(DataType.Password)]
        public string Heslo { get; set; }
    }
}

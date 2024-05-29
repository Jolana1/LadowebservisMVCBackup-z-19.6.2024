using LadowebservisMVC.Util;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace LadowebservisMVC.Controllers.Models
{
    public class ContactModel
    {
        public string Meno { get; set; }
        public string Priezvisko { get; set; }
        public string Phone { get; set; }
        public string Adresa { get; set; }

        public string Email { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Text{ get; set; }


    }
}














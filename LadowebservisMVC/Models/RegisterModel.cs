using System.ComponentModel.DataAnnotations;



namespace LadowebservisMVC.Models
{
public class RegisterModel
    { 
    [Required(ErrorMessage = "Meno a Priezvisko musí byť zadané")]
        [Display(Name = "Meno a Priezvisko:")]
        public string Meno { get; set; }

        [Required(ErrorMessage = "Email musí byť zadaný:")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Nezadali ste platnú emailovú adresu")]
        public string Email { get; set; }

        [Display(Name = "Zopakujte email")]
        [Required(ErrorMessage = "Emaily sa nezhodujú")]
        [Compare("Captcha", ErrorMessage = "Emaily sa nezhodujú")]
        public string Captcha { get; set; }

        [Required(ErrorMessage = "Telefón musí byť zadaný")]
        [Display(Name = "Telefón")]
        public int Telefon { get; set; }

        [Display(Name = "Adresa")]
        [Required(ErrorMessage = "Názov ulice")]
        
        public string Adresa { get; set; }

        [Required(ErrorMessage = "PSČ musí byť zadané")]
        [Display(Name = "PSČ")]
        [DataType(DataType.PostalCode)]
        public int PSC { get; set; }

        [Required(ErrorMessage = "Mesto  musí byť zadané")]
        [Display(Name = "Mesto")]
        public string Mesto { get; set; }

        [Required(ErrorMessage = "Kratka správa musí byť zadaná")]
        [Display(Name = "Odkaz")]
        public string Sprava { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Heslo musí byť zadané")]
        [DataType(DataType.Password)]

        public string Password { get; set; }

    }
}





























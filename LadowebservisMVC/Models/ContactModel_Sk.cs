using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using LadowebservisMVC.Controllers.Models;


namespace LadowebservisMVC.Controllers.Models
{
    public class ContactModel_Sk

    {
    /// <summary>
    /// Name
    /// </summary>
    [Required(ErrorMessage = ModelUtil.requiredErrMessage_Sk)]
        [Display(Name = "Meno")]
        public string Name { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        [Required(ErrorMessage = ModelUtil.requiredErrMessage_Sk)]
        [EmailAddress(ErrorMessage = ModelUtil.invalidEmailErrMessage_Sk)]
        [Display(Name = "Email")]
        public string Email { get; set; }
        /// <summary>
        /// Subject
        /// </summary>
        [Required(ErrorMessage = ModelUtil.requiredErrMessage_Sk)]
        [Display(Name = "Predmet")]
        public string Subject { get; set; }
        /// <summary>
        /// Text
        /// </summary>
        [Required(ErrorMessage = ModelUtil.requiredErrMessage_Sk)]
        [Display(Name = "Sem napíšte správu")]
        public string Text { get; set; }
        /// <summary>
        /// Password
        /// </summary>
        [Display(Name = "Heslo")]
        public string Password { get; set; }
        /// <summary>
        /// Captcha
        /// 

    }
}

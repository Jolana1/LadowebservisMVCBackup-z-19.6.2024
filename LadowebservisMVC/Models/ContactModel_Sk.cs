using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using LadowebservisMVC.Controllers.Models;
using LadowebservisMVC.Util;


namespace LadowebservisMVC.Controllers.Models
{
    public class ContactModel_Sk
    {
/// <summary>
        /// Name
        /// </summary>
        [Required(ErrorMessage = ModelUtil.requiredErrMessage_Sk)]
        [Display(Name = "Name")]
        public string Name { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        [Required(ErrorMessage = ModelUtil.requiredErrMessage_Sk)]
        [EmailAddress(ErrorMessage = ModelUtil.invalidEmailErrMessage_Sk)]
        [Display(Name = "Email")]
        public string Email { get; set; }
        /// <summary>
        /// Phone
        /// </summary>
        [Required(ErrorMessage = ModelUtil.requiredErrMessage_Sk)]
        [Display(Name = "Phone")]
        public string Phone { get; set; }
        /// <summary>
        /// Text
        /// </summary>
        [Required(ErrorMessage = ModelUtil.requiredErrMessage_Sk)]
        [Display(Name = "Text")]
        public string Text { get; set; }
        /// <summary>
        /// Password
        /// </summary>
        [Display(Name = "Password")]
        public string Password { get; set; }
        /// <summary>
        public bool SendContactRequest()
        {
            List<TextTemplateParam> paramList = new List<TextTemplateParam> { };
            paramList.Add(new TextTemplateParam("NAME", this.Name));
            paramList.Add(new TextTemplateParam("EMAIL", this.Email));
            paramList.Add(new TextTemplateParam("TEXT", this.Text));

            // Odoslanie uzivatelovi
            Mailer.SendMailTemplate(
                "Vaša správa",
                TextTemplate.GetTemplateText("ContactSendSuccess_Sk", paramList),
                this.Email, null);

            return true;




        }
    }
}


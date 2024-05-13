using LadowebservisMVC.Models;
//using System;
//using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
//using System.Reflection;
using System.Security.Policy;
using System.Text;
//using System.Web.Helpers;





namespace LadowebservisMVC.Util
{

    public class Mailer
    {


        public void OdoslanieEmailu(OdoslanieSpravyModel model)
        {
            MailMessage mail = new MailMessage
            {
                From = new MailAddress("info@ladowebservis.sk", "podpora@ladowebservis.sk")
            };
            mail.Headers["X-Mailer"] = "ladowebservis.sk";
            mail.Subject = "Pozdravujeme Vás";
            mail.IsBodyHtml = false;
            mail.SubjectEncoding = Encoding.UTF8;
            mail.BodyEncoding = Encoding.UTF8;
            mail.Body = model.Email;

            mail.Body = string.Format("\r\n Ďakujeme,že ste sa u nás zaregistrovali a kontaktovali nás.\r\n Váš email: {0} ,Vaše meno: {1} ,\r\n Captcha: {2}," +
                "\r\n\r\n Vaša správa:\r\n {3}"+"\r\n\r\n Ďakujeme za prejavenú dôveru a správu ,prajeme príjemný deň. \r\n\r\n S pozdravom.",

                model.Email,
                model.Meno,
                model.Captcha,
                model.Password,
                model.Sprava);

            mail.To.Add(model.Email);
            mail.Bcc.Add("info@ladowebservis.sk");

            SmtpClient client = new SmtpClient("email.active24.com")
            {
                EnableSsl = true,
                Port = 587,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("info@ladowebservis.sk", "44zoIZzIIZ")
            };

            client.Send(mail);
        }
    }
}











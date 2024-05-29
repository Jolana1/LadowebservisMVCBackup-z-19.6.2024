using LadowebservisMVC.Controllers.Models;
using LadowebservisMVC.Models;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Web.Helpers;





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
            mail.Subject = "Pozdravujem Vás!";
            mail.IsBodyHtml = false;
            mail.SubjectEncoding = Encoding.UTF8;
            mail.BodyEncoding = Encoding.UTF8;
            mail.Body = model.Email;

            mail.Body = string.Format("\r\n Ďakujeme,že ste nás kontaktovali.\r\n Váš email: {0} ,\r\n Vaše meno: {1} ,\r\n Potvrdenie mailu: {2}," +
                "\r\n Vaše heslo: {3}" +
                "\r\n Vaša správa:\r\n {4}" + "\r\n\r\n Ďakujeme za prejavenú dôveru a správu. \r\n\r\n S pozdravom.",
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

        public void OdoslanieEmailu(OdoslanieRegModel model)
        {
            MailMessage mail = new MailMessage
            {
                From = new MailAddress("info@ladowebservis.sk", "podpora@ladowebservis.sk")
            };
            mail.Headers["X-Mailer"] = "ladowebservis.sk";
            mail.Subject = "Ďakujeme za Vašu registráciu.";
            mail.IsBodyHtml = false;
            mail.SubjectEncoding = Encoding.UTF8;
            mail.BodyEncoding = Encoding.UTF8;



            mail.Body = string.Format("\r\n Ďakujeme, že ste sa u nás zaregistrovali.Ako zaregistrovaný zákazník okrem iného získavate následovné výhody:" +
                "\r\n Rýchlejší nákup vďaka vlastnému zoznamu obľúbených položiek." +
                "\r\n Možnosť byť informovaný o novinkách a akciách." +
                "\r\n Prístup do členskej sekcie a zľavového programu." +"\r\n\r\n"+
                "\r\n Váš email: {0}" + 
                "\r\n Vaše meno: {1}" + 
                "\r\n Priezvisko: {2}," +
                "\r\n Telefón: {3}" + 
                "\r\n Adresa: {4}" + 
                "\r\n Vaše mesto: {5}" + 
                "\r\n Potvrdenie emailu-(Captcha): {6}" + 
                "\r\n Vaše heslo: {7}" +
                "\r\n Váš text:\r\n {8}" + 
                "\r\n\r\n Prajeme príjemný deň. \r\n\r\n S pozdravom ladowebservis.sk",
                model.Email,
                model.Name,
                model.Priezvisko,
                model.Phone,
                model.Adresa,
                model.City,
                model.Captcha,
                model.Password,
                model.Text);

            
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











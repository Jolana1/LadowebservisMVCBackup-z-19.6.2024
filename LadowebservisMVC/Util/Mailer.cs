using LadowebservisMVC.Controllers.Models;
using LadowebservisMVC.Models;
using System;
using System.Net;
using System.Net.Mail;
using System.Text;







namespace LadowebservisMVC.Util
{

    public class Mailer
    {
        internal static void SendMailTemplate(string v1, string v2, string email, object value)
        {
            throw new NotImplementedException();
        }

        public void OdoslanieEmailu(Controllers.Models.ContactModel_Sk model)
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

            mail.Body = string.Format("\r\n Ďakujeme,že ste sa u nás zaregistrovali a kontaktovali nás.\r\n Váš email: {0} ,Vaše meno: {1} ,\r\n Phone: {2}," +
                "\r\n\r\n Vaše heslo:\r\n {3},\r\n\r\n Váš text:\r\n {4}"
                + "\r\n\r\n Ďakujeme za prejavenú dôveru a správu ,prajeme príjemný deň. \r\n\r\n S pozdravom ladowebservis.sk",

                model.Email,
                model.Name,
                model.Phone,
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











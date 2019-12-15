using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Threading.Tasks;

namespace MyStayAPI.AzureServices
{
    public class SendGridEmail
    {
       public static async Task AzureSendGridEmail()
        {
            string FromMail = "b.m.vidyasree025@gmail.com";
            string ToMail = "bommanahalli.vidyasree@mindtree.com";

            //SendGrid smtpserver
            string smtpPassword = "Vidya17*";
            string SendGridUsername = "azure_a334cbc25835ffb14b1787b37420c284@azure.com";

            MailMessage mail = new MailMessage(FromMail, ToMail);
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Port = 587;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Host = "smtp.sendgrid.net";
            smtpClient.Credentials = new System.Net.NetworkCredential(SendGridUsername, smtpPassword);
            mail.Subject = "Testing the Sendgrid C# Library";
            mail.Body = "Sorry for disturbing:)";
            smtpClient.Send(mail);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.IO;
using System.Threading;
using System.Configuration;

namespace EmailSenderAPP
{
    class Mailclient
    {
        public string sSmtpClient = "smtp.office365.com";
        public string sUsername = "racunarac@vsmti.hr";
        public string sPassword = "Racunarstvo123";
        public int nPort = 587;
        public void SendMail(string sEmail, string sSubject, string sBody)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient(sSmtpClient);

            mail.From = new MailAddress(sUsername);
            mail.To.Add(sEmail);
            mail.Subject = sSubject;
            mail.Body = sBody;

            SmtpServer.Port = nPort;
            SmtpServer.Credentials = new System.Net.NetworkCredential(sUsername, sPassword);
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);
        }
    }
}

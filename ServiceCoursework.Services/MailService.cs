using System;
using System.Collections.Generic;
using System.Net.Mail;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;
using System.Net;

namespace ServiceCoursework.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MailService" in both code and config file together.
    public class MailService : IMailService
    {

        public string SendMail(string to, string subject, string body)
        { 

            try
            {
                using (var smtpClient = new SmtpClient("smtp.gmail.com", 587))
                using (var mailMessage = new MailMessage("artem.denysenko@nure.ua", to, subject, body))
                {
                    smtpClient.Credentials = new NetworkCredential("artem.denysenko@nure.ua", "eleemosynary");
                    smtpClient.EnableSsl = true;
                    smtpClient.Send(mailMessage);
                    return String.Format("Mail send to {0} from {1}", to, "artem.denysenko@nure.ua");
                }
            }
            catch (SmtpFailedRecipientException ex)
            {
                return "SendMail : " + ex.Message;
            }
            catch (SmtpException ex)
            {
                return "SendMail : " + ex.Message;
            }
            catch (Exception ex)
            {
                return "SendMail : " + ex.Message;
            }
        }
    }
}

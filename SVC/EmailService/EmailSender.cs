using DAL;
using SVC.EmailService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SVC
{
    public static class EmailSender
    {
        public static void SendEmail(string to, string subject, string body)
        {
            try
            {
                var fromAddress = new MailAddress(SystemConfigRepository.GetValue("EMAIL_SISTEMA"), SystemConfigRepository.GetValue("NOMBRE_NEGOCIO"));
                var toAddress = new MailAddress(to);
                string fromPassword = SystemConfigRepository.GetValue("EMAIL_PASSWORD");
                var smtp = new SmtpClient
                {
                    Host = SystemConfigRepository.GetValue("EMAIL_HOST"),
                    Port = int.Parse(SystemConfigRepository.GetValue("EMAIL_PORT")),
                    EnableSsl = Convert.ToBoolean(SystemConfigRepository.GetValue("EMAIL_USESSL")),
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };

                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }
            catch (SmtpException smtpEx)
            {
                throw new EmailSendException("Failed to send email due to SMTP error.", smtpEx);
            }
            catch (Exception ex)
            {
                throw new EmailSendException("Unexpected error while sending email.", ex);
            }
            finally
            {

            }
        }
    }
}

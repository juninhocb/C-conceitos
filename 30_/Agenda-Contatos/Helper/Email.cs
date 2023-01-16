using System.Net;
using System.Net.Mail;

namespace Agenda_Contatos.Helper
{
    public class Email : IEmail
    {
        private readonly IConfiguration _configuration;

        public Email(IConfiguration configuration)
        {
            _configuration= configuration;
        }

        public bool Send(string email, string subject, string message)
        {
            
            try
            {
                string host = _configuration.GetValue<string>("SMTP:Host");
                string display = _configuration.GetValue<string>("SMTP:Nome");
                string username = _configuration.GetValue<string>("SMTP:Username");
                string password = _configuration.GetValue<string>("SMTP:Senha");
                int port = _configuration.GetValue<int>("SMTP:Porta");

                MailMessage mail = new MailMessage()
                {
                    From = new MailAddress(username, display)
                };

                mail.To.Add(email);
                mail.Subject = subject;
                mail.Body = message; 
                mail.IsBodyHtml= true;
                mail.Priority = MailPriority.High;

                using(SmtpClient smtp = new SmtpClient(host, port))
                {
                    smtp.Credentials = new NetworkCredential(username, password);
                    smtp.EnableSsl = true;
                    try {
                        smtp.Send(mail);

                    } catch(Exception ex) { 
                        Console.WriteLine("Não foi possível enviar o email por time out, erro: "  + ex.Message);
                        return false;
                    }

                    return true;
                }

            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}

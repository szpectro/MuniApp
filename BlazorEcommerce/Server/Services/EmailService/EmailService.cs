using MimeKit.Text;
using MimeKit;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Services.EmailService
{

    public class EmailService : IEmailService
    {
        private readonly IConfiguration _config;
        public EmailService(IConfiguration config)
        {
            _config = config;
        }
        private void SendEmail(EmailDto request)
        {

            if (request != null)
            {
                var email = new MimeMessage();
                email.From.Add(MailboxAddress.Parse(_config.GetSection("EmailUsername").Value));
                email.To.Add(MailboxAddress.Parse(request.To));
                email.Subject = request.Subject;
                email.Body = new TextPart(TextFormat.Html) { Text = request.Body };

                using var smtp = new SmtpClient();
                smtp.Connect(_config.GetSection("EmailHost").Value, 587, MailKit.Security.SecureSocketOptions.StartTls);
                smtp.Authenticate(_config.GetSection("EmailUsername").Value, _config.GetSection("EmailPassword").Value);
                smtp.Send(email);
                smtp.Disconnect(true);                
            }
        }


        public async Task<ServiceResponse<int>> SendEmailLink(EmailDto emailDto)
        {
            var informacionCorreo = emailDto;
            SendEmail(emailDto);
            if (emailDto != null)
            {
                return new ServiceResponse<int> { Data = 1, Message = "Usuario encontrado." };
            }
            else
            {
                return new ServiceResponse<int>
                {
                    Success = false,
                    Message = "El Usuario no se encontró."
                };
            }

        }
    }
}

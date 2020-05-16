using HealthyNutGuysAPI.Auth.Jwt;
using HealthyNutGuysAPI.Services.EmailService.Templates;
using HealthyNutGuysDomain.Models;
using Microsoft.Extensions.Configuration;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using MailKit.Net.Smtp;
using System.Threading.Tasks;

namespace HealthyNutGuysAPI.Services.EmailService
{
    public class SendEmailService : ISendEmailService
    {
        private IConfigurationSection _emailAppSettings;
        private IConfiguration _configuration;

        public SendEmailService(IConfiguration configuration)
        {
            this._configuration = configuration;
            this._emailAppSettings = configuration.GetSection(nameof(EmailServiceOptions));
        }
        public bool SendEmail(ApplicationUser user, string callbackUrl)
        {
            bool success;
            try
            {
                PasswordResetTemplate template = new PasswordResetTemplate(this._emailAppSettings);

                // Message to User
                MimeMessage messageToUser = new MimeMessage();
                // Add From
                messageToUser.From.Add(new MailboxAddress(this._emailAppSettings[nameof(EmailServiceOptions.Admin)], this._emailAppSettings[nameof(EmailServiceOptions.SystemAdminEmail)]));
                // Add TO
                messageToUser.To.Add(new MailboxAddress("User", user.Email));
                // Add Subject
                messageToUser.Subject = "Password Recovery";

                BodyBuilder bodyBuilderForUser = new BodyBuilder();

                bodyBuilderForUser.HtmlBody = template.UserEmailBody(callbackUrl);

                messageToUser.Body = bodyBuilderForUser.ToMessageBody();

                SmtpClient client = new SmtpClient();
                client.Connect(this._emailAppSettings[nameof(EmailServiceOptions.SmtpServer)], int.Parse(this._emailAppSettings[nameof(EmailServiceOptions.Port)]), true);
                client.Authenticate(this._emailAppSettings[nameof(EmailServiceOptions.SystemAdminEmail)], this._configuration[nameof(VaultKeys.SystemAdminEmailPassword)]);

                client.Send(messageToUser);

                client.Disconnect(true);
                client.Dispose();

                success = true;
            }
            catch(Exception ex)
            {
                success = false;
            }

            return success;
        }
    }
}

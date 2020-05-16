using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyNutGuysAPI.Services.EmailService.Templates
{
    public class PasswordResetTemplate
    {
        public PasswordResetTemplate(IConfigurationSection emailSection)
        {
            this._emailAppSettings = emailSection;
        }

        private IConfigurationSection _emailAppSettings;

        public string UserEmailBody(string callbackUrl)
        {
            return $@"
             <html lang='en'>
             <head>     
            <meta charset='utf-8'>
            <meta name='viewport' content='initial-scale=1, maximum-scale=1'>
            <meta name='viewport' content='width=device-width, initial-scale=1'>  
            <link href='https://fonts.googleapis.com/css?family=Roboto:300,400,500' rel='stylesheet'>  
            <link href='https://fonts.googleapis.com/css?family=Roboto&display=swap' rel='stylesheet'>
            </head>
            <body style='height: 100vh; font-family: 'Roboto', sans-serif; color:white; text-align: center'>
              <div>Please reset your password by clicking here: <a href={callbackUrl}>Reset Password</a></div>
            </body>
            </html>            
            ";
        }
    }
}

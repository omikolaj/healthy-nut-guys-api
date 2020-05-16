using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyNutGuysAPI.Services.EmailService
{
    public class EmailServiceOptions
    {
        public string Admin { get; set; }
        public string AdminEmail { get; set; }
        public string Port { get; set; }
        public string SmtpServer { get; set; }
        public string SystemAdminEmail { get; set; }
        public string AdminPhoneNumber { get; set; }
        public string EmailLogoUrl { get; set; }
    }
}

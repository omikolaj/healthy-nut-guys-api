using HealthyNutGuysDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyNutGuysAPI.Services.EmailService
{
    public interface ISendEmailService
    {
        bool SendEmail(ApplicationUser user, string callbackUrl);        
    }
}

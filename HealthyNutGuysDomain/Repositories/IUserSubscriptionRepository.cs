using HealthyNutGuysDomain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HealthyNutGuysDomain.Repositories
{
    public interface IUserSubscriptionRepository
    {
        Task<UserSubscription> GetUserSubscriptionByUserId(string id, CancellationToken ct = default);
    }
}

using HealthyNutGuysDomain.Models;
using HealthyNutGuysDomain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HealthyNutGuysDataCore.Repositories
{
    public class UserSubscriptionRepository : IUserSubscriptionRepository
    {
        private readonly HealthyNutGuysContext _dbContext;
        public UserSubscriptionRepository(HealthyNutGuysContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public async Task<UserSubscription> GetUserSubscriptionByUserId(string id, CancellationToken ct = default)
        {
            return this._dbContext.UserSubscriptions.Where(sub => sub.Deleted == false && sub.ApplicationUserId == id).FirstOrDefault();
        }
    }
}

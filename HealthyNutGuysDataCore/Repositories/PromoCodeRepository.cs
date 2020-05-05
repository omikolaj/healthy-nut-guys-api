using HealthyNutGuysDomain.Models;
using HealthyNutGuysDomain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HealthyNutGuysDataCore.Repositories
{
    public class PromoCodeRepository : IPromoCodeRepository
    {
        public PromoCodeRepository(HealthyNutGuysContext dbContext)
        {
            this._dbContext = dbContext;
        }

        private readonly HealthyNutGuysContext _dbContext;

        public async Task<PromoCode> GetByIdAsync(string id, CancellationToken ct = default)
        {
            return await this._dbContext.PromoCodes.FindAsync(id);
        }
    }
}

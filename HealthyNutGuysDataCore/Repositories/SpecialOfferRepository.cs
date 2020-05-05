using HealthyNutGuysDomain.Models;
using HealthyNutGuysDomain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HealthyNutGuysDataCore.Repositories
{
    public class SpecialOfferRepository : ISpecialOfferRepository
    {
        public SpecialOfferRepository(HealthyNutGuysContext dbContext)
        {
            this._dbContext = dbContext;
        }

        private readonly HealthyNutGuysContext _dbContext;

        public async Task<List<SpecialOffer>> GetAllAsync(CancellationToken ct = default)
        {
            return await this._dbContext.SpecialOffers.Where(o => o.Deleted == false).ToListAsync(ct);
        }
    }
}

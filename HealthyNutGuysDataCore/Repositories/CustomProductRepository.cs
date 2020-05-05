using HealthyNutGuysDomain.Models;
using HealthyNutGuysDomain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HealthyNutGuysDataCore.Repositories
{
    public class CustomProductRepository : ICustomProductRepository
    {
        public CustomProductRepository(HealthyNutGuysContext dbContext)
        {
            this._dbContext = dbContext;
        }

        private readonly HealthyNutGuysContext _dbContext;

        public async Task<List<CustomProduct>> GetAllAsync(CancellationToken ct = default)
        {
            return await this._dbContext.CustomSacks.ToListAsync(ct);
        }
    }
}

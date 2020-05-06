using HealthyNutGuysDomain;
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
    public class CustomProductRepository : ICustomProductRepository
    {
        public CustomProductRepository(HealthyNutGuysContext dbContext)
        {
            this._dbContext = dbContext;
        }

        private readonly HealthyNutGuysContext _dbContext;

        public async Task<CustomProduct> GetCustomSackAsync(CancellationToken ct = default)
        {
            return await this._dbContext.CustomProducts
                                .Include(p => p.Category)
                                .Include(p => p.Tags)
                                .Include(p => p.SelectOptions)
                                .SingleOrDefaultAsync(p => p.Deleted == false && p.Type == CustomProductType.CustomSack);                          
        }
    }
}

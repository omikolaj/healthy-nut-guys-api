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
    public class MixCategoryRepository : IMixCategoryRepository
    {
        public MixCategoryRepository(HealthyNutGuysContext dbContext)
        {
            this._dbContext = dbContext;
        }

        private readonly HealthyNutGuysContext _dbContext;

        public async Task<List<MixCategory>> GetAllByProductIdAsync(string id, CancellationToken ct = default)
        {
            return await this._dbContext.MixCategories.Where(m => m.CustomProductId == id)
                                                        .Include(m => m.Ingredients)
                                                        .Where(m => m.Deleted == false)
                                                        .ToListAsync(ct);
        }
    }
}

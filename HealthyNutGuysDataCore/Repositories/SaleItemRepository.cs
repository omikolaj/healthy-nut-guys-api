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
    public class SaleItemRepository : ISaleItemRepository
    {
        public SaleItemRepository(HealthyNutGuysContext dbContext)
        {
            this._dbContext = dbContext;
        }

        private readonly HealthyNutGuysContext _dbContext;

        public async Task<List<SaleItem>> GetByProductId(string id, CancellationToken ct = default)
        {
            return await this._dbContext.SaleItems.Where(saleItem => saleItem.ProductId == id).ToListAsync();
        }
    }
}

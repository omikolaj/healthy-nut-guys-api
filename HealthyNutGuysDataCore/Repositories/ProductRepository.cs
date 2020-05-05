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
    public class ProductRepository : IProductRepository
    {
        public ProductRepository(HealthyNutGuysContext dbContext)
        {
            this._dbContext = dbContext;
        }

        private readonly HealthyNutGuysContext _dbContext;

        public async Task<List<Product>> GetAllAsync(CancellationToken ct = default)
        {
            return await this._dbContext.Products.Where(p => p.Deleted == false)
                                                 .Include(p => p.ProductDetails)
                                                    .ThenInclude(pd => pd.SelectOption)                                                  
                                                  .Include(p => p.Category)
                                                  .Include(p => p.Tags)
                                                  .ToListAsync(ct);
        }
    }
}

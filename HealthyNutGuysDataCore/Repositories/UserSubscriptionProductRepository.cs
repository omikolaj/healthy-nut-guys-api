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
    public class UserSubscriptionProductRepository : IUserSubscriptionProductRepository
    {
        private readonly HealthyNutGuysContext _dbContext;
        public UserSubscriptionProductRepository(HealthyNutGuysContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public async Task<List<UserSubscriptionProduct>> GetAllByUserSubscriptionIdAsync(string id, CancellationToken ct = default)
        {
            return await this._dbContext.UserSubscriptionProducts.Where(prod => prod.Deleted == false && prod.UserSubscriptionId == id)
                .Include(prod => prod.SubscriptionMixCategories)                
                .ThenInclude(mixCategory => mixCategory.Ingredients)
                .ThenInclude(ingredient => ingredient.Ingredient)                
                .ToListAsync();
        }
    }
}

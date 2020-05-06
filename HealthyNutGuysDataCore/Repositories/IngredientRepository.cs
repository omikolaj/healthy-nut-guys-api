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
    public class IngredientRepository : IIngredientRepository
    {
        public IngredientRepository(HealthyNutGuysContext dbContext)
        {
            this._dbContext = dbContext;
        }

        private readonly HealthyNutGuysContext _dbContext;

        public async Task<List<Ingredient>> GetAllByMixCategoryIdAsync(string id, CancellationToken ct = default)
        {
            return await this._dbContext.Ingredients.Where(ingredient => ingredient.Deleted == false && ingredient.MixCategoryId == id).ToListAsync(ct);
        }
    }
}

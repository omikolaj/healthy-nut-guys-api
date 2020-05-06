using HealthyNutGuysDomain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HealthyNutGuysDomain.Repositories
{
    public interface IIngredientRepository
    {
        Task<List<Ingredient>> GetAllByMixCategoryIdAsync(string id, CancellationToken ct = default);
    }
}

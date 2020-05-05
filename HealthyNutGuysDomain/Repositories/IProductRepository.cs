using HealthyNutGuysDomain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HealthyNutGuysDomain.Repositories
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllAsync(CancellationToken ct = default);
    }
}

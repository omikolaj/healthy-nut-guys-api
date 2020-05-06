using HealthyNutGuysDomain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HealthyNutGuysDomain.Repositories
{
    public interface ISaleItemRepository
    {
        Task<List<SaleItem>> GetByProductId(string id, CancellationToken ct = default);

        Task<List<SaleItem>> GetByCustomProductId(string id, CancellationToken ct = default);
    }
}

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HealthyNutGuysDomain.Models.Merchandise;
using HealthyNutGuysDomain.Repositories.Merchandise;

namespace HealthyNutGuysDataCore.Repositories
{
    public class GearItemRepository : IGearItemRepository
    {
        #region Fields and Properties
        private readonly HealthyNutGuysContext _dbContext;

        #endregion

        #region Constructor    
        public GearItemRepository(HealthyNutGuysContext dbContext)
        {
            this._dbContext = dbContext;
        }

        #endregion

        #region Methods
        private async Task<bool> GearItemExists(long? id, CancellationToken ct = default(CancellationToken))
        {
            return await GetByIDAsync(id, ct) != null;
        }
        public async Task<List<GearItem>> GetAllAsync(CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }
        public async Task<GearItem> AddAsync(GearItem gearItem, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteAsync(long? id, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }
        public async Task<GearItem> GetByIDAsync(long? id, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateAsync(GearItem gearItem, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
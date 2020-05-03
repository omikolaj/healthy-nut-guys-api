using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HealthyNutGuysDomain.Models.Merchandise;
using HealthyNutGuysDomain.Repositories.Merchandise;
using System;

namespace HealthyNutGuysDataCore.Repositories
{
  public class GearSizeRepository : IGearSizeRepository
  {
    #region Fields and Properties
    private readonly HealthyNutGuysContext _dbContext;

    #endregion

    #region Constructor
    public GearSizeRepository(HealthyNutGuysContext dbContext)
    {
      this._dbContext = dbContext;
    }
    #endregion

    #region Methods
    private async Task<bool> GearSizeExists(long? id, CancellationToken ct = default(CancellationToken))
    {
      return await GetByIDAsync(id, ct) != null;
    }
    public async Task<GearSize> AddAsync(GearSize gearSize, CancellationToken ct = default)
    {
            throw new NotImplementedException();
        }

    public async Task<bool> DeleteAsync(long? id, CancellationToken ct = default)
    {
            throw new NotImplementedException();
        }

    public async Task<GearSize> GetByIDAsync(long? id, CancellationToken ct = default)
    {
            throw new NotImplementedException();
        }

    public async Task<bool> UpdateAsync(GearSize gearSize, CancellationToken ct = default)
    {
            throw new NotImplementedException();
        }

        public Task<List<GearSize>> GetAllByGearItemIdAsync(long? id, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
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
  public class GearImageRepository : IGearImageRepository
  {
    #region Fields and Properties
    private readonly HealthyNutGuysContext _dbContext;

    #endregion

    #region Constructor
    public GearImageRepository(HealthyNutGuysContext dbContext)
    {
      this._dbContext = dbContext;
    }

    #endregion

    #region Methods

    private async Task<bool> GearImageExists(long? id, CancellationToken ct = default(CancellationToken))
    {
      return await GetByIDAsync(id, ct) != null;
    }
    public async Task<GearImage> AddAsync(GearImage gearSize, CancellationToken ct = default)
    {
            throw new NotImplementedException();
        }

    public async Task<bool> DeleteAsync(long? id, CancellationToken ct = default)
    {
            throw new NotImplementedException();
        }

    public async Task<List<GearImage>> GetAllByGearItemIdAsync(long? gearItemId, CancellationToken ct = default)
    {
            throw new NotImplementedException();
        }

    public async Task<GearImage> GetByIDAsync(long? id, CancellationToken ct = default)
    {
            throw new NotImplementedException();
        }

    public Task<bool> UpdateAsync(GearImage gearSize, CancellationToken ct = default)
    {
      throw new System.NotImplementedException();
    }

    #endregion
  }
}
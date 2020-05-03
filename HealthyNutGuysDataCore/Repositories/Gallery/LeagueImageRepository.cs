using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HealthyNutGuysDomain.Models;
using HealthyNutGuysDomain.Models.Gallery;
using HealthyNutGuysDomain.Repositories.Gallery;

namespace HealthyNutGuysDataCore.Repositories.Gallery
{
  public class LeagueImageRepository : ILeagueImageRepository
  {
    #region Fields and Properties
    private readonly HealthyNutGuysContext _dbContext;

    #endregion

    #region Constructor
    public LeagueImageRepository(HealthyNutGuysContext dbContext)
    {
      this._dbContext = dbContext;
    }
    #endregion

    #region Methods
    private async Task<bool> LeagueImageExists(long? id, CancellationToken ct = default(CancellationToken))
    {
            throw new NotImplementedException();
        }

    public async Task<LeagueImage> AddAsync(LeagueImage leagueImage, CancellationToken ct = default)
    {
            throw new NotImplementedException();
        }

    public async Task<bool> DeleteAsync(long? id, CancellationToken ct = default)
    {
            throw new NotImplementedException();
        }

    public async Task<List<LeagueImage>> GetAllAsync(CancellationToken ct = default)
    {
            throw new NotImplementedException();
        }

    public async Task<bool> UpdateAsync(LeagueImage leagueImage, CancellationToken ct = default)
    {
            throw new NotImplementedException();
        }

    public async Task<LeagueImage> GetByIDAsync(long? id, CancellationToken ct = default)
    {
            throw new NotImplementedException();
        }

    public Task<IList<LeagueImage>> UpdateAsync(IList<LeagueImage> leagueImages, CancellationToken ct = default)
    {
      throw new NotImplementedException();
    }

    #endregion
  }
}
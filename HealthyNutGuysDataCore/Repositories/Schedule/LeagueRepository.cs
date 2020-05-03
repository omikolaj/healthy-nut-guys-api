using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HealthyNutGuysDomain.Models.Schedule;
using HealthyNutGuysDomain.Repositories.Schedule;

namespace HealthyNutGuysDataCore.Repositories.Schedule
{
    public class LeagueRepository : ILeagueRepository
    {
        #region Property and Fields

        private readonly HealthyNutGuysContext _dbContext;

        #endregion

        #region Constructor

        public LeagueRepository(HealthyNutGuysContext dbContext)
        {
            this._dbContext = dbContext;
        }

        #endregion

        private async Task<bool> LeagueExists(string id, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public async Task<League> GetByIdAsync(string id, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }
        
        public async Task<List<League>> GetBySportTypeIdAsync(string sportTypeId, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public async Task<League> AddAsync(League newLeague, CancellationToken ct = default)
        {
            throw new NotImplementedException();

        }

        public async Task<bool> DeleteAsync(string id, CancellationToken ct = default)
        {
            throw new NotImplementedException();

        }

        public async Task<bool> UpdateAsync(League leagueToUpdate, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }
    }
}

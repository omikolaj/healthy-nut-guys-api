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
    public class TeamRepository : ITeamRepository
    {
        #region Fields and Properties

        private readonly HealthyNutGuysContext _dbContext;

        #endregion

        #region Constructor

        public TeamRepository(HealthyNutGuysContext dbContext)
        {
            this._dbContext = dbContext;
        }

        #endregion

        #region Team

        private async Task<bool> TeamExists(string id, CancellationToken ct = default(CancellationToken))
        {
            return await GetByIdAsync(id, ct) != null;
        }

        public async Task<Team> GetByIdAsync(string id, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Team>> GetAllByLeagueIdAsync(string leagueID, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }
        public async Task<List<Team>> GetUnassignedTeams(CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }
        public async Task<bool> DeleteAsync(string id, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public async Task<Team> AddAsync(Team newTeam, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateAsync(Team updatedTeam, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

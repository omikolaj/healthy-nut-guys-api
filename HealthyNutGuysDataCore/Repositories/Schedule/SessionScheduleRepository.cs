using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HealthyNutGuysDataCore;
using HealthyNutGuysDomain.Models.Schedule;

namespace HealthyNutGuysDomain.Repositories.Schedule
{
    public class SessionScheduleRepository : ISessionScheduleRepository
    {
        #region Properties and Fields

        private readonly HealthyNutGuysContext _dbContext;

        #endregion

        #region Constructor

        public SessionScheduleRepository(HealthyNutGuysContext dbContext)
        {
            this._dbContext = dbContext;
        }

        #endregion

        #region Methods

        private async Task<bool> LeagueSessionScheduleExists(string id, CancellationToken ct = default)
        {
            return await this.GetLeagueSessionScheduleByIdAsync(id, ct) != null;
        }

        public async Task<LeagueSessionSchedule> GetLeagueSessionScheduleByIdAsync(string id, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public async Task<List<LeagueSessionSchedule>> GetAllSessionsByLeagueIdAsync(string leagueId, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public async Task<List<LeagueSessionSchedule>> GetAllActiveSessionsAsync(CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public async Task<Match> GetMatchByIdAsync(string matchId, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }        

        public async Task<bool> UpdateSessionScheduleAsync(LeagueSessionSchedule leagueSessionScheduleToUpdate, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public async Task<LeagueSessionSchedule> AddScheduleAsync(LeagueSessionSchedule newLeagueSessionSchedule, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public async Task<GameDay> AddGameDayAsync(GameDay newGameDay, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public async Task<GameTime> AddGameTimeAsync(GameTime newGameTime, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public async Task<Match> AddMatchAsync(Match newMatch, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public async Task<MatchResult> ReportMatchAsync(MatchResult matchResult, CancellationToken ct = default)
        {
            throw new NotImplementedException();

        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HealthyNutGuysDomain.Models;
using HealthyNutGuysDomain.Models.Gallery;
using HealthyNutGuysDomain.Models.Schedule;
using HealthyNutGuysDomain.Models.TeamSignUp;
using HealthyNutGuysDomain.Repositories;
using HealthyNutGuysDomain.Repositories.TeamSignUp;

namespace HealthyNutGuysDataCore.Repositories.TeamSignUp
{
    public class TeamSignUpRepository : ITeamSignUpRepository
    {
        #region Fields and Properties
        private readonly HealthyNutGuysContext _dbContext;

        #endregion

        #region Constructor
        public TeamSignUpRepository(HealthyNutGuysContext dbContext)
        {
            this._dbContext = dbContext;
        }

        #endregion

        #region Methods

        #region Team SignUp
        public async Task<Contact> AddTeamContactAsync(Contact teamContact, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public async Task<TeamSignUpForm> AddSignUpFormAsync(TeamSignUpForm teamSignUpForm, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteSignUpFormAsync(long? id, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<List<TeamSignUpForm>> GetAllSignUpFormsAsync(CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<Contact> GetTeamContactByTeamId(long? teamId, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<TeamSignUpForm> GetTeamSignUpFormByIdAsync(long? id, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateSignUpFormAsync(TeamSignUpForm leagueImage, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        #endregion

        #endregion
    }
}
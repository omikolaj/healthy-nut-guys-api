using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HealthyNutGuysDomain.Models.Schedule;
using HealthyNutGuysDomain.Repositories.Schedule;
using Z.EntityFramework.Plus;

namespace HealthyNutGuysDataCore.Repositories.Schedule
{
    public class SportTypeRepository : ISportTypeRepository
    {
        #region Properties and Fields

        private readonly HealthyNutGuysContext _dbContext;

        #endregion

        #region Constructor

        public SportTypeRepository(HealthyNutGuysContext dbContext)
        {
            this._dbContext = dbContext;
        }

        #endregion

        #region Methods

        private async Task<bool> SportTypeExists(string id, CancellationToken ct = default)
        {
            return await GetByIdAsync(id, ct) != null;
        }

        public async Task<SportType> AddAsync(SportType newSportType, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteAsync(string id, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public async Task<SportType> GetByIdAsync(string id, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateAsync(SportType sportTypeToUpdate, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public async Task<List<SportType>> GetAllAsync(CancellationToken ct = default)
        {
            throw new NotImplementedException();

        }

        #endregion
    }
}

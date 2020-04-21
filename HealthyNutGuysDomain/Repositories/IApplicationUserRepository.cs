using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using HealthyNutGuysDomain.Models;

namespace HealthyNutGuysDomain.Repositories
{
  public interface IApplicationUserRepository
  {
    #region Methods
    Task<List<ApplicationUser>> GetAllAsync(CancellationToken ct = default(CancellationToken));

    Task<ApplicationUser> GetByIDAsync(string id, CancellationToken ct = default(CancellationToken));

    Task<ApplicationUser> AddAsync(ApplicationUser user, CancellationToken ct = default(CancellationToken));

    Task<bool> UpdateAsync(ApplicationUser user, CancellationToken ct = default(CancellationToken));

    Task<bool> DeleteAsync(string id, CancellationToken ct = default(CancellationToken));

    #endregion
  }
}
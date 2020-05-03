using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HealthyNutGuysDomain.Models;
using HealthyNutGuysDomain.Models.Gallery;
using HealthyNutGuysDomain.Models.Merchandise;
using HealthyNutGuysDomain.Repositories.Gallery;
using HealthyNutGuysDomain.Repositories.Merchandise;

namespace HealthyNutGuysDataCore.Repositories.Gallery
{
  public class PreOrderRepository : IPreOrderRepository
  {
    #region Fields and Properties
    private readonly HealthyNutGuysContext _dbContext;

    #endregion

    #region Constructor
    public PreOrderRepository(HealthyNutGuysContext dbContext)
    {
      this._dbContext = dbContext;
    }
    #endregion

    #region Methods
    private async Task<bool> PreOrderExists(long? id, CancellationToken ct = default(CancellationToken))
    {
      return await GetByIDAsync(id, ct) != null;
    }

    public async Task<PreOrder> GetByIDAsync(long? id, CancellationToken ct)
    {
            throw new NotImplementedException();
        }

    public async Task<PreOrder> AddAsync(PreOrder preOrder, CancellationToken ct = default)
    {
            throw new NotImplementedException();
        }

    public async Task<PreOrderContact> AddPreOrderContactAsync(PreOrderContact preOrderContact, CancellationToken ct = default)
    {
            throw new NotImplementedException();
        }

    #endregion
  }
}
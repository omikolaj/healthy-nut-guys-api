using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using HealthyNutGuysDomain.ViewModels;

namespace HealthyNutGuysDomain
{
    public interface IHealthyNutGuysSupervisor
    {
        #region ApplicationUser

        Task<UserSubscriptionViewModel> GetUserSubscriptionByIdAsync(string id, CancellationToken ct = default(CancellationToken));        
        Task<List<ApplicationUserViewModel>> GetAllUsersAsync(CancellationToken ct = default(CancellationToken));
        Task<ApplicationUserViewModel> GetUserByIDAsync(string ID, CancellationToken ct = default(CancellationToken));
        Task<ApplicationUserViewModel> CreateUserAsync(ApplicationUserViewModel userViewModel, CancellationToken ct = default(CancellationToken));
        Task<bool> UpdateUserAsync(ApplicationUserViewModel userViewModel, CancellationToken ct = default(CancellationToken));
        Task<bool> DeleteUserAsync(string ID, CancellationToken ct = default(CancellationToken));
        
        #endregion
        
        #region ShopOffer

        Task<SpecialOfferViewModel> GetValidShopOfferAsync(CancellationToken ct = default);

        #endregion

        #region Shop

        Task<List<ProductViewModel>> GetAllProductsAsync(CancellationToken ct = default);

        Task<List<CustomProductViewModel>> GetAllCustomProdctsAsync(CancellationToken ct = default);

        #endregion
    }
}
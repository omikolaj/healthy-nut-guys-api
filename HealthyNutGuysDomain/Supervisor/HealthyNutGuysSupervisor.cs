using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using HealthyNutGuysDomain.Models;
using HealthyNutGuysDomain.Repositories;
using HealthyNutGuysDomain.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace HealthyNutGuysDomain.Supervisor
{
    public partial class HealthyNutGuysSupervisor : IHealthyNutGuysSupervisor
    {
        #region Properties and Fields
        private readonly IApplicationUserRepository _applicationUserRepository;
        private readonly IPromoCodeRepository _promoCodeRepository;
        private readonly ISpecialOfferRepository _specialOfferRepository;
        private readonly IProductRepository _productRepository;
        private readonly ISaleItemRepository _saleItemRepository;
        private readonly ICustomProductRepository _customProductRepository;
        private readonly IMixCategoryRepository _mixCategoryRepository;
        private readonly IIngredientRepository _ingredientRepository;
        private readonly UserManager<ApplicationUser> _userManager;

        #endregion

        #region Constructor
        public HealthyNutGuysSupervisor(
            UserManager<ApplicationUser> userManager,
            IApplicationUserRepository applicationUserRepository,
            IPromoCodeRepository promoCodeRepository,
            ISpecialOfferRepository specialOfferRepository,
            IProductRepository productRepository,
            ISaleItemRepository saleItemRepository,
            ICustomProductRepository customProductRepository,
            IMixCategoryRepository mixCategoryRepository,
            IIngredientRepository ingredientRepository
            )
        {
            this._userManager = userManager;
            this._applicationUserRepository = applicationUserRepository;
            this._promoCodeRepository = promoCodeRepository;
            this._specialOfferRepository = specialOfferRepository;
            this._productRepository = productRepository;
            this._saleItemRepository = saleItemRepository;
            this._customProductRepository = customProductRepository;
            this._mixCategoryRepository = mixCategoryRepository;
            this._ingredientRepository = ingredientRepository;
        }

        #endregion
    }
}
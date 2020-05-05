using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using HealthyNutGuysDomain.Models;
using HealthyNutGuysDomain.Repositories;
using HealthyNutGuysDomain.Repositories.Gallery;
using HealthyNutGuysDomain.Repositories.Merchandise;
using HealthyNutGuysDomain.Repositories.Schedule;
using HealthyNutGuysDomain.Repositories.TeamSignUp;
using HealthyNutGuysDomain.ViewModels;

namespace HealthyNutGuysDomain.Supervisor
{
    public partial class HealthyNutGuysSupervisor : IHealthyNutGuysSupervisor
    {
        #region Properties and Fields
        private readonly IApplicationUserRepository _applicationUserRepository;
        private readonly IGearItemRepository _gearItemRepository;
        private readonly IGearImageRepository _gearImageRepository;
        private readonly IGearSizeRepository _gearSizeRepository;
        private readonly ILeagueImageRepository _leagueImageRepository;
        private readonly ITeamSignUpRepository _teamSignUpRepository;
        private readonly IPreOrderRepository _preOrderRepository;
        private readonly ILeagueRepository _leagueRepository;
        private readonly ISessionScheduleRepository _sessionScheduleRepository;
        private readonly ISportTypeRepository _sportTypeRepository;
        private readonly ITeamRepository _teamRepository;        
        private readonly IPromoCodeRepository _promoCodeRepository;
        private readonly ISpecialOfferRepository _specialOfferRepository;

        #endregion

        #region Constructor
        public HealthyNutGuysSupervisor(
        IApplicationUserRepository applicationUserRepository,
        IGearItemRepository gearItemRepository,
        IGearImageRepository gearImageRepository,
        IGearSizeRepository gearSizeRepository,
        ILeagueImageRepository leagueImageRepository,
        ITeamSignUpRepository teamSignUpRepository,
        IPreOrderRepository preOrderRepository,
        ILeagueRepository leagueRepository,
        ISessionScheduleRepository sessionScheduleRepository,
        ISportTypeRepository sportTypeRepository,
        ITeamRepository teamRepository,        
        IPromoCodeRepository promoCodeRepository,
        ISpecialOfferRepository specialOfferRepository
      )
        {
            this._applicationUserRepository = applicationUserRepository;
            this._gearItemRepository = gearItemRepository;
            this._gearImageRepository = gearImageRepository;
            this._gearSizeRepository = gearSizeRepository;
            this._leagueImageRepository = leagueImageRepository;
            this._teamSignUpRepository = teamSignUpRepository;
            this._preOrderRepository = preOrderRepository;
            this._leagueRepository = leagueRepository;
            this._sessionScheduleRepository = sessionScheduleRepository;
            this._sportTypeRepository = sportTypeRepository;
            this._teamRepository = teamRepository;            
            this._promoCodeRepository = promoCodeRepository;
            this._specialOfferRepository = specialOfferRepository;
        }

        #endregion
    }
}
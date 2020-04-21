using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HealthyNutGuysAPI.Auth.Errors;
using HealthyNutGuysAPI.Filters;
using HealthyNutGuysDomain;
using HealthyNutGuysDomain.Supervisor;
using HealthyNutGuysDomain.ViewModels.Schedule;

namespace HealthyNutGuysAPI.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ServiceFilter(typeof(ValidateModelStateAttribute))]
    public class SchedulesController : ControllerBase
    {
        #region Fields and Properties

        private readonly IHealthyNutGuysSupervisor _supervisor;

        #endregion

        #region Constructor

        public SchedulesController(IHealthyNutGuysSupervisor supervisor)
        {
            this._supervisor = supervisor;
        }

        #endregion

        #region Controllers

        [HttpPost("sessions/active-sessions-info")]
        [Authorize]        
        public async Task<ActionResult<List<ActiveSessionInfoViewModel>>> ActiveSchedulesInfo([FromBody]List<string> leagueIds, CancellationToken ct = default(CancellationToken))
        {
            List<ActiveSessionInfoViewModel> activeSessions = await this._supervisor.GetActiveSessionsInfoAsync(leagueIds, ct);

            if (activeSessions == null)
            {
                return BadRequest(Errors.AddErrorToModelState(ErrorCodes.ActiveSessionsInfo, ErrorDescriptions.ActiveSessionsInfoFailure, ModelState));
            }

            return new JsonResult(activeSessions);
        }

        [HttpPost("sessions")]
        [Authorize]
        public async Task<ActionResult<bool>> PublishLeagueSessionSchedules([FromBody]List<LeagueSessionScheduleViewModel> newSessionSchedules, CancellationToken ct = default(CancellationToken))
        {
            if (!await this._supervisor.PublishSessionsSchedulesAsync(newSessionSchedules, ct))
            {
                return BadRequest(Errors.AddErrorToModelState(ErrorCodes.PublishNewSession, ErrorDescriptions.PublishingNewSessionsFailure, ModelState));
            }

            return new JsonResult(true);
        }

        [HttpGet("sessions")]        
        public async Task<ActionResult<List<LeagueSessionScheduleViewModel>>> GetAllActiveSessionSchedules(CancellationToken ct = default(CancellationToken))
        {
            List<LeagueSessionScheduleViewModel> sessions = await this._supervisor.GetAllActiveSessionsAsync(ct);

            return new JsonResult(sessions);
        }

        [HttpPost("sessions/{id}/matches/{matchId}/report")]
        [Authorize]
        public async Task<ActionResult<MatchResultViewModel>> ReportMatch([FromBody]MatchResultViewModel reportMatch, CancellationToken ct = default(CancellationToken))
        {
            reportMatch = await this._supervisor.ReportMatchAsync(reportMatch, ct);
            if (reportMatch == null)
            {
                return BadRequest(Errors.AddErrorToModelState(ErrorCodes.MatchResult, ErrorDescriptions.MatchResulFailure, ModelState));
            }

            return new JsonResult(reportMatch);
        }

        #endregion
    }
}

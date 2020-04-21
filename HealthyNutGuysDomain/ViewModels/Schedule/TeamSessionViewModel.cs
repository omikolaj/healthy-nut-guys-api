using System;
using System.Collections.Generic;
using System.Text;
using HealthyNutGuysDomain.Models.Schedule;

namespace HealthyNutGuysDomain.ViewModels.Schedule
{
    public class TeamSessionViewModel
    {

        #region Fields and Properties

        public string TeamId { get; set; }
        public string TeamName { get; set; }
        public TeamViewModel Team { get; set; }
        public string LeagueSessionScheduleId { get; set; }        

        #endregion

    }
}

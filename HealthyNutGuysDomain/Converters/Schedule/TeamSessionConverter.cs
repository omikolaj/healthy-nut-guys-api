using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HealthyNutGuysDomain.Models.Schedule;
using HealthyNutGuysDomain.ViewModels.Schedule;

namespace HealthyNutGuysDomain.Converters.Schedule
{
    public class TeamSessionConverter
    {
        #region Methods

        public static TeamSessionViewModel Convert(TeamSession teamSession)
        {
            TeamSessionViewModel model = new TeamSessionViewModel()
            {
                TeamId = teamSession.TeamId,
                Team = teamSession.Team == null ? null : TeamConverter.Convert(teamSession.Team),
                LeagueSessionScheduleId = teamSession.LeagueSessionScheduleId                
            };

            return model;
        }

        public static List<TeamSessionViewModel> ConvertList(List<TeamSession> teamSessions)
        {
            return teamSessions.Select(teamSession =>
            {
                TeamSessionViewModel model = new TeamSessionViewModel()
                {
                    TeamId = teamSession.TeamId,
                    Team = teamSession.Team == null ? null : TeamConverter.Convert(teamSession.Team),
                    LeagueSessionScheduleId = teamSession.LeagueSessionScheduleId                    
                };

                return model;

            }).ToList();
        }

        #endregion
    }
}

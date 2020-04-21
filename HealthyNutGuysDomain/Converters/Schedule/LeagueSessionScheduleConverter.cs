using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HealthyNutGuysDomain.Models.Schedule;
using HealthyNutGuysDomain.ViewModels.Schedule;

namespace HealthyNutGuysDomain.Converters.Schedule
{
    public class LeagueSessionScheduleConverter
    {
        #region Methods

        public static LeagueSessionScheduleViewModel Convert(LeagueSessionSchedule sessionSchedule)
        {
            LeagueSessionScheduleViewModel model = new LeagueSessionScheduleViewModel();
            model.Active = sessionSchedule.Active;
            model.ByeWeeks = sessionSchedule.ByeWeeks;
            model.GamesDays = GameDayConverter.ConvertList(sessionSchedule.GamesDays);
            model.Id = sessionSchedule.Id;
            model.LeagueID = sessionSchedule.LeagueID;            
            model.Matches = MatchConverter.ConvertList(sessionSchedule.Matches);
            model.NumberOfWeeks = sessionSchedule.NumberOfWeeks;
            model.SessionEnd = sessionSchedule.SessionEnd;            
            model.SessionStart = sessionSchedule.SessionStart;
            model.TeamsSessions = sessionSchedule.TeamsSessions == null ? null : TeamSessionConverter.ConvertList(sessionSchedule.TeamsSessions.ToList());

            return model;
        }

        public static List<LeagueSessionScheduleViewModel> ConvertList(IEnumerable<LeagueSessionSchedule> sessionSchedules)
        {
            return sessionSchedules.Select(sessionSchedule => 
            {
                LeagueSessionScheduleViewModel model = new LeagueSessionScheduleViewModel();
                model.Active = sessionSchedule.Active;
                model.ByeWeeks = sessionSchedule.ByeWeeks;
                model.GamesDays = GameDayConverter.ConvertList(sessionSchedule.GamesDays);
                model.Id = sessionSchedule.Id;
                model.LeagueID = sessionSchedule.LeagueID;
                model.Matches = MatchConverter.ConvertList(sessionSchedule.Matches);
                model.NumberOfWeeks = sessionSchedule.NumberOfWeeks;
                model.SessionEnd = sessionSchedule.SessionEnd;
                model.SessionStart = sessionSchedule.SessionStart;
                model.TeamsSessions = sessionSchedule.TeamsSessions == null ? null : TeamSessionConverter.ConvertList(sessionSchedule.TeamsSessions.ToList());

                return model;
            }).ToList();
        }

        #endregion
    }
}

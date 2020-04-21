using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HealthyNutGuysDomain.Models.Schedule;
using HealthyNutGuysDomain.ViewModels.Schedule;

namespace HealthyNutGuysDomain.Converters.Schedule
{
    public class MatchConverter
    {
        #region Methods

        public static MatchViewModel Convert(Match match)
        {
            MatchViewModel model = new MatchViewModel();
            model.AwayTeamId = match.AwayTeamId;            
            model.HomeTeamId = match.HomeTeamId;            
            model.Id = match.MatchId;
            model.LeagueID = match.LeagueID;
            model.SessionId = match.LeagueSessionScheduleId;            
            model.MatchResult = match.MatchResult == null ? null : MatchResultConverter.Convert(match.MatchResult);

            return model;
        }

        public static List<MatchViewModel> ConvertList(IEnumerable<Match> matches)
        {
            return matches.Select(match => 
            {
                MatchViewModel model = new MatchViewModel();
                model.DateTime = match.DateTime;
                model.AwayTeamId = match.AwayTeamId;                
                model.HomeTeamId = match.HomeTeamId;                
                model.Id = match.MatchId;
                model.LeagueID = match.LeagueID;
                model.SessionId = match.LeagueSessionScheduleId;                
                model.MatchResult = match.MatchResult == null ? null : MatchResultConverter.Convert(match.MatchResult);             

                return model;

            }).ToList();
        }

        #endregion
    }
}

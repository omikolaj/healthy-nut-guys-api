using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HealthyNutGuysDomain.Models.Schedule;
using HealthyNutGuysDomain.ViewModels.Schedule;

namespace HealthyNutGuysDomain.Converters.Schedule
{
    public class GameDayConverter
    {
        #region Methods

        public static GameDayViewModel Convert(GameDay gameDay)
        {
            GameDayViewModel model = new GameDayViewModel();
            model.GamesDay = gameDay.GamesDay;
            model.Id = gameDay.Id;
            model.LeagueSessionScheduleId = gameDay.LeagueSessionScheduleId;
            model.GamesTimes = GameTimeConverter.ConvertList(gameDay.GamesTimes);

            return model;
        }

        public static List<GameDayViewModel> ConvertList(IEnumerable<GameDay> gameDays)
        {
            return gameDays.Select(gameDay =>
            {
                GameDayViewModel model = new GameDayViewModel();
                model.GamesDay = gameDay.GamesDay;
                model.Id = gameDay.Id;
                model.LeagueSessionScheduleId = gameDay.LeagueSessionScheduleId;
                model.GamesTimes = GameTimeConverter.ConvertList(gameDay.GamesTimes);

                return model;
            }).ToList();
        }

        #endregion
    }
}

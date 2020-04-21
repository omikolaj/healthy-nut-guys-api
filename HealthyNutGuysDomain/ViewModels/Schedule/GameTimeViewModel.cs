using System;
using System.Collections.Generic;
using System.Text;

namespace HealthyNutGuysDomain.ViewModels.Schedule
{
    public class GameTimeViewModel
    {
        #region Fields and Properties

        public string Id { get; set; }
        public string GameDayId { get; set; }
        public long GamesTime { get; set; }

        #endregion
    }
}

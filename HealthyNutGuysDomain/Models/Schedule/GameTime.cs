using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HealthyNutGuysDomain.Models.Schedule
{
    public class GameTime
    {
        #region Fields and Properties

        public string Id { get; set; }
        public string GameDayId { get; set; }
        public DateTime GamesTime { get; set; }

        #endregion
    }
}

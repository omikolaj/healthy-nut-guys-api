﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HealthyNutGuysDomain.ViewModels.Schedule
{
    public class LeagueViewModel
    {
        #region Fields and Properties

        public string Id { get; set; }
        public bool Active { get; set; } = true;
        public string Type { get; set; }
        public string Name { get; set; }
        public ICollection<TeamViewModel> Teams { get; set; }
        public bool Selected { get; set; }
        public string SportTypeID { get; set; }             

        #endregion
    }
}
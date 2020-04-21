using System.Collections.Generic;
using HealthyNutGuysDomain.Models;
using HealthyNutGuysDomain.Models.Merchandise;

namespace HealthyNutGuysDomain.ViewModels.Merchandise
{
  public class GearSizeViewModel
  {
    #region Fields and Properties
    public long? Id { get; set; }
    public long? GearItemId { get; set; }
    public Size Size { get; set; }
    public bool Available { get; set; }
    public string Color { get; set; }

    #endregion
  }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HealthyNutGuysDomain.Models.Merchandise;
using HealthyNutGuysDomain.ViewModels;

namespace HealthyNutGuysDomain.Models.Merchandise
{
  public class PreOrderContactViewModel : ContactBaseViewModel
  {
    #region Fields and Properties    
    public long? PreOrderId { get; set; }
    public virtual PreOrder PreOrder { get; set; }

    #endregion
  }
}
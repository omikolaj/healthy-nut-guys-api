using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HealthyNutGuysDomain.Models.Merchandise;

namespace HealthyNutGuysDomain.Models.Merchandise
{
  public class PreOrderContact : ContactBase
  {
    #region Fields and Properties    
    public long? PreOrderId { get; set; }
    public virtual PreOrder PreOrder { get; set; }

    #endregion
  }
}
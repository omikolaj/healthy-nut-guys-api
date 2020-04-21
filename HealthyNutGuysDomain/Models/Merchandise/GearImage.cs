using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthyNutGuysDomain.Models.Merchandise
{
  public class GearImage : ImageBase
  {
    public long? Id { get; set; }
    public long? GearItemId { get; set; }
    public GearItem GearItem { get; set; }

  }
}
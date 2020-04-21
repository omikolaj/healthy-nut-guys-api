using System.Collections.Generic;
using System.Linq;
using HealthyNutGuysDomain.Models.Merchandise;
using HealthyNutGuysDomain.ViewModels;
using HealthyNutGuysDomain.ViewModels.Merchandise;

namespace HealthyNutGuysDomain.Converters
{
  public static class GearItemConverter
  {
    #region Methods
    public static GearItemViewModel Convert(GearItem gearItem)
    {
      if (gearItem == null)
      {
        return null;
      }
      GearItemViewModel gearItemViewModel = new GearItemViewModel();
      gearItemViewModel.Id = gearItem.Id;
      gearItemViewModel.Images = GearImageConverter.ConvertList(gearItem.Images);
      gearItemViewModel.InStock = gearItem.InStock;
      gearItemViewModel.Name = gearItem.Name;
      gearItemViewModel.Price = gearItem.Price;
      gearItemViewModel.Sizes = GearSizeConverter.ConvertList(gearItem.Sizes);

      return gearItemViewModel;
    }

    public static List<GearItemViewModel> ConvertList(IEnumerable<GearItem> gearItems)
    {
      return gearItems.Select(gearItem =>
      {
        GearItemViewModel gearItemViewModel = new GearItemViewModel();
        gearItemViewModel.Id = gearItem.Id;
        gearItemViewModel.Images = GearImageConverter.ConvertList(gearItem.Images);
        gearItemViewModel.InStock = gearItem.InStock;
        gearItemViewModel.Name = gearItem.Name;
        gearItemViewModel.Price = gearItem.Price;
        gearItemViewModel.Sizes = GearSizeConverter.ConvertList(gearItem.Sizes);

        return gearItemViewModel;
      }).ToList();
    }

    #endregion
  }
}
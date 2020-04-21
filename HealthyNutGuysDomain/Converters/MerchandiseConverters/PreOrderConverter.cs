using System.Collections.Generic;
using System.Linq;
using HealthyNutGuysDomain.Converters.TeamConverters;
using HealthyNutGuysDomain.Models.Merchandise;
using HealthyNutGuysDomain.ViewModels.Merchandise;

namespace HealthyNutGuysDomain.Converters.MerchandiseConverters
{
  public static class PreOrderConverter
  {
    #region Methods
    public static PreOrderViewModel Convert(PreOrder preOrder)
    {
      PreOrderViewModel preOrderViewModel = new PreOrderViewModel();
      preOrderViewModel.Id = preOrder.Id;
      preOrderViewModel.GearItemId = preOrder.GearItemId;
      preOrderViewModel.Quantity = preOrder.Quantity;
      preOrderViewModel.Size = preOrder.Size;
      preOrderViewModel.Contact = PreOrderContactConverter.Convert(preOrder.Contact);

      return preOrderViewModel;
    }

    public static List<PreOrderViewModel> ConvertList(IEnumerable<PreOrder> preOrders)
    {
      return preOrders.Select(preOrder =>
      {
        PreOrderViewModel preOrderViewModel = new PreOrderViewModel();
        preOrderViewModel.Id = preOrder.Id;
        preOrderViewModel.GearItemId = preOrder.GearItemId;
        preOrderViewModel.Quantity = preOrder.Quantity;
        preOrderViewModel.Size = preOrder.Size;
        preOrderViewModel.Contact = PreOrderContactConverter.Convert(preOrder.Contact);

        return preOrderViewModel;
      }).ToList();
    }

    #endregion
  }
}
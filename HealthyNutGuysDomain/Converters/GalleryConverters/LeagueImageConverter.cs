using System.Collections.Generic;
using System.Linq;
using HealthyNutGuysDomain.Models;
using HealthyNutGuysDomain.Models.Gallery;
using HealthyNutGuysDomain.ViewModels.Gallery;

namespace HealthyNutGuysDomain.Converters.GalleryConverters
{
  public static class LeagueImageConverter
  {
    #region Methods
    public static LeagueImageViewModel Convert(LeagueImage leagueImage)
    {
      LeagueImageViewModel leagueImageViewModel = new LeagueImageViewModel();
      leagueImageViewModel.Id = leagueImage.Id;
      leagueImageViewModel.CloudinaryPublicId = leagueImage.CloudinaryPublicId;
      leagueImageViewModel.Format = leagueImage.Format;
      leagueImageViewModel.HashTag = leagueImage.HashTag;
      leagueImageViewModel.Height = leagueImage.Height;
      leagueImageViewModel.Width = leagueImage.Width;
      leagueImageViewModel.Type = leagueImage.Type;
      leagueImageViewModel.Medium = leagueImage.Medium;
      leagueImageViewModel.Small = leagueImage.Small;
      leagueImageViewModel.Big = leagueImage.Big;
      leagueImageViewModel.Name = leagueImage.Name;
      leagueImageViewModel.Url = leagueImage.Url;
      leagueImageViewModel.OrderId = leagueImage.OrderId;

      return leagueImageViewModel;
    }
    public static List<LeagueImageViewModel> ConvertList(IEnumerable<LeagueImage> leagueImages)
    {
      return leagueImages.Select(leagueImage =>
      {
        LeagueImageViewModel leagueImageViewModel = new LeagueImageViewModel();
        leagueImageViewModel.Id = leagueImage.Id;
        leagueImageViewModel.CloudinaryPublicId = leagueImage.CloudinaryPublicId;
        leagueImageViewModel.Format = leagueImage.Format;
        leagueImageViewModel.HashTag = leagueImage.HashTag;
        leagueImageViewModel.Height = leagueImage.Height;
        leagueImageViewModel.Width = leagueImage.Width;
        leagueImageViewModel.Type = leagueImage.Type;
        leagueImageViewModel.Medium = leagueImage.Medium;
        leagueImageViewModel.Small = leagueImage.Small;
        leagueImageViewModel.Big = leagueImage.Big;
        leagueImageViewModel.Name = leagueImage.Name;
        leagueImageViewModel.Url = leagueImage.Url;
        leagueImageViewModel.ResourceType = leagueImage.ResourceType;
        leagueImageViewModel.OrderId = leagueImage.OrderId;

        return leagueImageViewModel;
      }).ToList();
    }

    #endregion
  }
}
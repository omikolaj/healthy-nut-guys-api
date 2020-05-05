using HealthyNutGuysDomain.Models;
using HealthyNutGuysDomain.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthyNutGuysDomain.Converters
{
    public static class SpecialOfferConverter
    {
        public static SpecialOfferViewModel Convert(SpecialOffer specialOffer)
        {
            SpecialOfferViewModel model = new SpecialOfferViewModel();
            model.Id = specialOffer.Id;
            model.PromoCodeId = specialOffer.PromoCodeId;
            model.Scope = (OfferScope)specialOffer?.Scope;
            model.Type = (OfferType)specialOffer.Type;            
            model.ExpireDate = (DateTime)specialOffer?.ExpireDate;
            model.DisplayMessage = specialOffer.DisplayMessage;
            
            return model;
        }
    }
}
 
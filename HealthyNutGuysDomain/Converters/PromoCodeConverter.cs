using HealthyNutGuysDomain.Models;
using HealthyNutGuysDomain.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthyNutGuysDomain.Converters
{
    public static class PromoCodeConverter
    {
        public static PromoCodeViewModel Convert(PromoCode promo)
        {
            PromoCodeViewModel model = new PromoCodeViewModel();
            model.Id = promo.Id;
            model.DiscountValue = promo.DiscountValue;
            model.ExpireDate = promo.ExpireDate;
            model.Type = promo.Type;
            model.Code = promo.Code;

            return model;
        }
    }
}

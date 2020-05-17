using HealthyNutGuysDomain.Models;
using HealthyNutGuysDomain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthyNutGuysDomain.Converters
{
    public static class UserSubscriptionProductConverter
    {
        public static UserSubscriptionProductViewModel Convert(UserSubscriptionProduct subscriptionProduct)
        {
            UserSubscriptionProductViewModel model = new UserSubscriptionProductViewModel();
            model.Id = subscriptionProduct.Id;
            if (subscriptionProduct.Product != null)
                model.Product = ProductConverter.Convert(subscriptionProduct.Product);
            if (subscriptionProduct.CustomProduct != null)
                model.CustomProduct = CustomProductConverter.Convert(subscriptionProduct.CustomProduct);
            if (subscriptionProduct.SelectOption != null)
                model.SelectOption = SelectOptionConverter.Convert(subscriptionProduct.SelectOption);
            if (subscriptionProduct.CustomSelectOption != null)
                model.CustomSelectOption = CustomSelectOptionConverter.Convert(subscriptionProduct.CustomSelectOption);
            if (subscriptionProduct.SubscriptionMixCategories != null)
                model.SubscriptionMixCategories = UserSubscriptionMixCategoryConverter.ConvertList(subscriptionProduct.SubscriptionMixCategories);

            return model;
        }

        public static List<UserSubscriptionProductViewModel> ConvertList(IEnumerable<UserSubscriptionProduct> userSubscriptionProducts)
        {
            return userSubscriptionProducts.Select(subscriptionProduct => Convert(subscriptionProduct)).ToList();
        }
    }
}

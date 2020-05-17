using HealthyNutGuysDomain.Models;
using HealthyNutGuysDomain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthyNutGuysDomain.Converters
{
    public static class UserSubscriptionConverter
    {
        public static UserSubscriptionViewModel Convert(UserSubscription subscription)
        {
            UserSubscriptionViewModel model = new UserSubscriptionViewModel();
            model.Id = subscription.Id;
            model.Frequency = subscription.Frequency;
            model.Modified = subscription.Modified;
            model.NextDelivery = subscription.NextDelivery;            

            return model;
        }

        public static List<UserSubscriptionViewModel> ConvertList(IEnumerable<UserSubscription> subscriptions)
        {
            return subscriptions.Select(sub => Convert(sub)).ToList();
        }
    }
}

using System;

namespace HealthyNutGuysDataCore.DataBaseInitializer
{
    public class DataBaseInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            IdentitySeedData.Populate(serviceProvider).Wait();
            SeedData.Populate(serviceProvider);
        }     
    }
}
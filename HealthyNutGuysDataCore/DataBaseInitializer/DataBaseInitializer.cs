﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using HealthyNutGuysDomain.Models;
using HealthyNutGuysDomain.Models.Schedule;

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
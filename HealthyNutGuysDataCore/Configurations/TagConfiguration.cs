using HealthyNutGuysDomain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthyNutGuysDataCore.Configurations
{
    public class TagConfiguration
    {
        public TagConfiguration(EntityTypeBuilder<Tag> model)
        {
            model.HasOne<Product>()
                .WithMany(_ => _.Tags);
        }
    }
}

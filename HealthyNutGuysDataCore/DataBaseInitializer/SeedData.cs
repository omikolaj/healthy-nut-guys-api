using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthyNutGuysDomain.Models.Schedule;
using HealthyNutGuysDomain.Models;

namespace HealthyNutGuysDataCore.DataBaseInitializer
{
    public class SeedData
    {
        #region Fields and Properties

        private static List<string> TeamNamesA
        {
            get
            {
                List<string> teams = new List<string>
                {
                    "Manchester United FC",
                    "Arsenal F.C",
                    "Chelsea F.C",
                    "Manchester City F.C",
                    "Liverpool F.C",
                    "Tottenham Hotspur F.C",
                    "Leicester City F.C",
                    "RTS"
                };

                return teams;
            }
        }

        private static List<string> TeamNamesB
        {
            get
            {
                List<string> teams = new List<string>
                {
                    "FC Barcelona",
                    "Real Madrid C.F",
                    "Atletico Madrid",
                    "Real Betis",
                    "CD Leganes",
                    "Real Sociedad",
                    "Valencia CF",
                    "LKS"
                };

                return teams;
            }
        }

        private static List<string> TeamNamesC
        {
            get
            {
                List<string> teams = new List<string>
                {
                    "Korona Kielce",
                    "Cracovia",
                    "Jagiellonia Białystok",
                    "ŁKS Łódź",
                    "Wisła Płock",
                    "Legia Warszawa",
                    "Lechia Gdańsk",
                    "Lech Poznań"
                };

                return teams;
            }
        }

        #endregion

        #region Methods
        public static void Populate(IServiceProvider serviceProvider)
        {
            HealthyNutGuysContext dbContext = serviceProvider.GetService<HealthyNutGuysContext>();

            SeedProducts(dbContext);            
        }

        private static void SeedProducts(HealthyNutGuysContext dbContext)
        {
            Category nutCategory = new Category()
            {
                Name = "Nuts"
            };

            dbContext.Categories.Add(nutCategory);
            dbContext.SaveChanges();

            nutCategory = dbContext.Categories.First();

            Product succulentSack = new Product()
            {
                Name = "Succulent Nut Sack",
                Subtitle = "Healthy Nut Guys",
                Description = "This savory, Succulent Nut Sack will leave you drooling! A decadent mix of white and milk chocolate chips, raisins, dried cranberries, peanuts, almonds, and cashews. As if that wasn't enough to make you nut...I mean, go nuts...we've topped it off with our delicious honey cashew vanilla granola. This organic Succulent Nut Sack is the thing of your wildest trail mix dreams!",
                Price = (decimal)17.99,
                ImageSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533594/thng/succulent_nut_sack_aa2ujs.png",                
                CategoryId = nutCategory.Id,
                IsOnSale = false
            };

            dbContext.Products.Add(succulentSack);
            dbContext.SaveChanges();
            

            ProductDetails succulentDetails4oz = new ProductDetails()
            {
                ProductId = succulentSack.Id,
                LabelSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533593/thng/succulent_nut_sack_label_s2glru.png",                
            };

            dbContext.ProductDetails.Add(succulentDetails4oz);
            dbContext.SaveChanges();

            SelectOption option4oz = new SelectOption
            {
                ProductDetailsId = succulentDetails4oz.Id,
                Option = "4oz"
            };

            ProductDetails succulentDetails8oz = new ProductDetails()
            {
                ProductId = succulentSack.Id,
                LabelSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533593/thng/succulent_nut_sack_label_s2glru.png",                
            };

            dbContext.ProductDetails.Add(succulentDetails8oz);
            dbContext.SaveChanges();

            SelectOption option8oz = new SelectOption
            {
                ProductDetailsId = succulentDetails8oz.Id,
                Option = "8oz"
            };

            ProductDetails succulentDetails12oz = new ProductDetails()
            {
                ProductId = succulentSack.Id,
                LabelSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533593/thng/succulent_nut_sack_label_s2glru.png",                
            };

            dbContext.ProductDetails.Add(succulentDetails12oz);
            dbContext.SaveChanges();

            SelectOption option12oz = new SelectOption
            {
                ProductDetailsId = succulentDetails12oz.Id,
                Option = "12oz"
            };

            ProductDetails succulentDetails16oz = new ProductDetails()
            {
                ProductId = succulentSack.Id,
                LabelSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533593/thng/succulent_nut_sack_label_s2glru.png",                
            };

            dbContext.ProductDetails.Add(succulentDetails16oz);
            dbContext.SaveChanges();

            SelectOption option16oz = new SelectOption
            {
                ProductDetailsId = succulentDetails16oz.Id,
                Option = "16oz"
            };

            List<SelectOption> selectOptions = new List<SelectOption>
            {
                option4oz,
                option8oz,
                option12oz,
                option16oz
            };

            foreach (SelectOption option in selectOptions)
            {
                dbContext.SelectOptions.Add(option);
                dbContext.SaveChanges();
            }

            Product ketoSack = new Product()
            {
                Name = "Keto Nut Sack",
                Subtitle = "Healthy Nut Guys",
                Description = "This blend of nuts and seeds is perfect for your ketogenic lifestyle! The nut blend of peanuts, Brazil nuts, almonds, and pecans mixed with sesame and sunflower seeds will help keep you in ketosis while providing essential fats, vitamins, and antioxidants. This organic, high-fiber Nut Sack will keep you full, ripped, and craving more of our nuts!",
                Price = (decimal)22.99,
                ImageSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533594/thng/keto_nut_sack_kfgj2w.png",                
                CategoryId = nutCategory.Id,
                IsOnSale = true
            };

            dbContext.Products.Add(ketoSack);
            dbContext.SaveChanges();

            ProductDetails ketoSackDetails4oz = new ProductDetails()
            {
                ProductId = ketoSack.Id,
                LabelSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533594/thng/keto_nut_sack_label_tdvpid.png",
            };

            dbContext.ProductDetails.Add(ketoSackDetails4oz);
            dbContext.SaveChanges();

            SelectOption ketoOption4oz = new SelectOption
            {
                ProductDetailsId = ketoSackDetails4oz.Id,
                Option = "4oz"
            };

            ProductDetails ketoSackDetails8oz = new ProductDetails()
            {
                ProductId = ketoSack.Id,
                LabelSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533594/thng/keto_nut_sack_label_tdvpid.png",                
            };

            dbContext.ProductDetails.Add(ketoSackDetails8oz);
            dbContext.SaveChanges();

            SelectOption ketoOption8oz = new SelectOption
            {
                ProductDetailsId = ketoSackDetails8oz.Id,
                Option = "8oz"
            };

            ProductDetails ketoSackDetails12oz = new ProductDetails()
            {
                ProductId = ketoSack.Id,
                LabelSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533594/thng/keto_nut_sack_label_tdvpid.png",                
            };

            dbContext.ProductDetails.Add(ketoSackDetails12oz);
            dbContext.SaveChanges();

            SelectOption ketoOption12oz = new SelectOption
            {
                ProductDetailsId = ketoSackDetails12oz.Id,
                Option = "12oz"
            };

            ProductDetails ketoSackDetails16oz = new ProductDetails()
            {
                ProductId = ketoSack.Id,                
                LabelSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533594/thng/keto_nut_sack_label_tdvpid.png",                
            };

            dbContext.ProductDetails.Add(ketoSackDetails16oz);
            dbContext.SaveChanges();

            SelectOption ketoOption16oz = new SelectOption
            {
                ProductDetailsId = ketoSackDetails16oz.Id,
                Option = "16oz"
            };

            List<SelectOption> ketoSelectOptions = new List<SelectOption> 
            {
                ketoOption4oz,
                ketoOption8oz,
                ketoOption12oz,
                ketoOption16oz
            };

            foreach (SelectOption option in ketoSelectOptions)
            {
                dbContext.SelectOptions.Add(option);
                dbContext.SaveChanges();
            }

            Product energySack = new Product()
            {
                Name = "Energy Nut Sack",
                Subtitle = "Healthy Nut Guys",
                Description = "Energize your Nut Sack with this awesome mix! Almonds, peanuts, and cashews provide long-lasting energy (you're welcome ladies) while the bananas, apple rings, and raisins will provide a quick boost in energy levels! For even more energy, we've topped it off with coconut, dark chocolate chips, and pumpkin seeds. All ingredients are organic so you can enjoy the natural stamina without the crash.",
                Price = (decimal)18.99,                
                ImageSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533593/thng/energy_nut_sack_label_y64lpg.png",                
                CategoryId = nutCategory.Id,
                IsOnSale = false
            };

            dbContext.Products.Add(energySack);
            dbContext.SaveChanges();

            ProductDetails energySackDetails4oz = new ProductDetails()
            {
                ProductId = energySack.Id,
                LabelSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533593/thng/energy_nut_sack_label_y64lpg.png",                
            };

            dbContext.ProductDetails.Add(energySackDetails4oz);
            dbContext.SaveChanges();

            SelectOption energyOption4oz = new SelectOption
            {
                ProductDetailsId = energySackDetails4oz.Id,
                Option = "4oz"
            };

            ProductDetails energySackDetails8oz = new ProductDetails()
            {
                ProductId = energySack.Id,
                LabelSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533593/thng/energy_nut_sack_label_y64lpg.png",                
            };

            dbContext.ProductDetails.Add(energySackDetails8oz);
            dbContext.SaveChanges();

            SelectOption energyOption8oz = new SelectOption
            {
                ProductDetailsId = energySackDetails8oz.Id,
                Option = "8oz"
            };

            ProductDetails energySackDetails12oz = new ProductDetails()
            {
                ProductId = energySack.Id,
                LabelSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533593/thng/energy_nut_sack_label_y64lpg.png",                
            };

            dbContext.ProductDetails.Add(energySackDetails12oz);
            dbContext.SaveChanges();

            SelectOption energyOption12oz = new SelectOption
            {
                ProductDetailsId = energySackDetails12oz.Id,
                Option = "12oz"
            };

            ProductDetails energySackDetails16oz = new ProductDetails()
            {
                ProductId = energySack.Id,                
                LabelSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533593/thng/energy_nut_sack_label_y64lpg.png",                
            };

            dbContext.ProductDetails.Add(energySackDetails16oz);
            dbContext.SaveChanges();

            SelectOption energyOption16oz = new SelectOption
            {
                ProductDetailsId = energySackDetails16oz.Id,
                Option = "16oz"
            };

            List<SelectOption> energySelectOptions = new List<SelectOption>
            {
                 energyOption4oz,
                 energyOption8oz,
                 energyOption12oz,
                 energyOption16oz
            };

            foreach (SelectOption option in energySelectOptions)
            {
                dbContext.SelectOptions.Add(option);
                dbContext.SaveChanges();
            }

            CustomSack customSack = new CustomSack()
            {
                Name = "Custom Nut Sack",
                Subtitle = "Healthy Nut Guys",
                Description = "You tell us how you want our Nut Sack! With the Custom Nut Sack, you get to choose from all of our ingredients to create the Nut Sack you've always wanted! As always, we will fill this Nut Sack with only organic ingredients to provide you with the highest quality, best tasting Nut Sack you have ever had!",
                Price = (decimal)17.99,                
                ImageSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533593/thng/custom_nut_sack_zfuek1.png",                
                CategoryId = nutCategory.Id,
                IsOnSale = false
            };

            dbContext.CustomSacks.Add(customSack);
            dbContext.SaveChanges();

        }

        #endregion
    }
}

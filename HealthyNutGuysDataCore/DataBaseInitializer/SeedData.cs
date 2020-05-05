using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthyNutGuysDomain.Models.Schedule;
using HealthyNutGuysDomain.Models;
using Microsoft.AspNetCore.Identity;
using HealthyNutGuysDomain.ViewModels;
using HealthyNutGuysDomain;

namespace HealthyNutGuysDataCore.DataBaseInitializer
{
    public class SeedData
    {
        public static void Populate(IServiceProvider serviceProvider)
        {
            UserManager<ApplicationUser> userManager = serviceProvider.GetService<UserManager<ApplicationUser>>();
            HealthyNutGuysContext dbContext = serviceProvider.GetService<HealthyNutGuysContext>();

            SeedShop(dbContext, userManager);            
        }

        private static void SeedShop(HealthyNutGuysContext dbContext, UserManager<ApplicationUser> userManager)
        {
            if (dbContext.Products.Count() > 0) return;

            Category nutCategory = new Category()
            {
                Id = "1",
                Name = "Nut Sacks"
            };

            dbContext.Categories.Add(nutCategory);
            dbContext.SaveChanges();

            Tag nutsTag = new Tag
            {
                Id = "2",
                Name = "Nuts"
            };

            Tag fruitsTag = new Tag
            {
                Id = "3",
                Name = "Fruits"
            };

            Tag seedsTag = new Tag
            {
                Id = "4",
                Name = "Seeds"
            };

            Tag granolaTag = new Tag
            {
                Id = "5",
                Name = "Granola"
            };

            List<Tag> tags = new List<Tag>
            {
                nutsTag,
                fruitsTag,
                seedsTag,
                granolaTag
            };

            foreach (Tag tag in tags)
            {
                dbContext.Tags.Add(tag);
                dbContext.SaveChanges();
            }

            Product succulentSack = new Product()
            {
                Id = "1",
                Name = "Succulent Nut Sack",
                Subtitle = "Healthy Nut Guys",
                Description = "This savory, Succulent Nut Sack will leave you drooling! A decadent mix of white and milk chocolate chips, raisins, dried cranberries, peanuts, almonds, and cashews. As if that wasn't enough to make you nut...I mean, go nuts...we've topped it off with our delicious honey cashew vanilla granola. This organic Succulent Nut Sack is the thing of your wildest trail mix dreams!",
                Price = (decimal)17.99,
                ImageSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533594/thng/succulent_nut_sack_aa2ujs.png",
                CategoryId = nutCategory.Id,
                IsOnSale = true,
                Tags = tags
            };

            dbContext.Products.Add(succulentSack);
            dbContext.SaveChanges();

            SaleItem succulentSackSale = new SaleItem
            {
                Id = "1",
                ProductId = succulentSack.Id,
                ExpireDate = DateTime.Today.AddDays(100),
                Type = OfferType.PercentOff, // 1 = free shipping, 2 = free stickers, 3 = $, 4 = %, 5 = promo code 
                DiscountValue = 5,
            };

            dbContext.SaleItems.Add(succulentSackSale);
            dbContext.SaveChanges();

            ProductDetails succulentDetails4oz = new ProductDetails()
            {
                Id = "1",
                ProductId = succulentSack.Id,
                LabelSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533593/thng/succulent_nut_sack_label_s2glru.png",
            };

            dbContext.ProductDetails.Add(succulentDetails4oz);
            dbContext.SaveChanges();

            SelectOption option4oz = new SelectOption
            {
                Id = "2",
                ProductDetailsId = succulentDetails4oz.Id,
                Option = "4oz"
            };

            ProductDetails succulentDetails8oz = new ProductDetails()
            {
                Id = "3",
                ProductId = succulentSack.Id,
                LabelSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533593/thng/succulent_nut_sack_label_s2glru.png",
            };

            dbContext.ProductDetails.Add(succulentDetails8oz);
            dbContext.SaveChanges();

            SelectOption option8oz = new SelectOption
            {
                Id = "4",
                ProductDetailsId = succulentDetails8oz.Id,
                Option = "8oz"
            };

            ProductDetails succulentDetails12oz = new ProductDetails()
            {
                Id = "5",
                ProductId = succulentSack.Id,
                LabelSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533593/thng/succulent_nut_sack_label_s2glru.png",
            };

            dbContext.ProductDetails.Add(succulentDetails12oz);
            dbContext.SaveChanges();

            SelectOption option12oz = new SelectOption
            {
                Id = "6",
                ProductDetailsId = succulentDetails12oz.Id,
                Option = "12oz"
            };

            ProductDetails succulentDetails16oz = new ProductDetails()
            {
                Id = "7",
                ProductId = succulentSack.Id,
                LabelSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533593/thng/succulent_nut_sack_label_s2glru.png",
            };

            dbContext.ProductDetails.Add(succulentDetails16oz);
            dbContext.SaveChanges();

            SelectOption option16oz = new SelectOption
            {
                Id = "8",
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

            Tag ketoSackNutsTag = new Tag
            {
                Id = "99",
                Name = "Nuts"
            };

            Tag ketoSackFruitsTag = new Tag
            {
                Id = "103",
                Name = "Fruits"
            };

            Tag ketoSackSeedsTag = new Tag
            {
                Id = "104",
                Name = "Seeds"
            };

            Tag ketoSackGranolaTag = new Tag
            {
                Id = "105",
                Name = "Granola"
            };

            List<Tag> ketoSackTags = new List<Tag>
            {
                ketoSackNutsTag,
                ketoSackFruitsTag,
                ketoSackSeedsTag,
                ketoSackGranolaTag
            };

            foreach (Tag tag in ketoSackTags)
            {
                dbContext.Tags.Add(tag);
                dbContext.SaveChanges();
            }

            Product ketoSack = new Product()
            {
                Id = "9",
                Name = "Keto Nut Sack",
                Subtitle = "Healthy Nut Guys",
                Description = "This blend of nuts and seeds is perfect for your ketogenic lifestyle! The nut blend of peanuts, Brazil nuts, almonds, and pecans mixed with sesame and sunflower seeds will help keep you in ketosis while providing essential fats, vitamins, and antioxidants. This organic, high-fiber Nut Sack will keep you full, ripped, and craving more of our nuts!",
                Price = (decimal)22.99,
                ImageSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533594/thng/keto_nut_sack_kfgj2w.png",
                CategoryId = nutCategory.Id,
                IsOnSale = true,
                Tags = ketoSackTags
            };

            dbContext.Products.Add(ketoSack);
            dbContext.SaveChanges();

            SaleItem ketoSaleItem = new SaleItem
            {
                Id = "10",
                ProductId = ketoSack.Id,
                ExpireDate = DateTime.Today.AddDays(100),
                Type = OfferType.AmountOff, // 1 = free shipping, 2 = free stickers, 3 = $, 4 = %, 5 = promo code 
                DiscountValue = (decimal)2.99
            };

            dbContext.SaleItems.Add(ketoSaleItem);
            dbContext.SaveChanges();

            ProductDetails ketoSackDetails4oz = new ProductDetails()
            {
                Id = "11",
                ProductId = ketoSack.Id,
                LabelSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533594/thng/keto_nut_sack_label_tdvpid.png",
            };

            dbContext.ProductDetails.Add(ketoSackDetails4oz);
            dbContext.SaveChanges();

            SelectOption ketoOption4oz = new SelectOption
            {
                Id = "12",
                ProductDetailsId = ketoSackDetails4oz.Id,
                Option = "4oz"
            };

            ProductDetails ketoSackDetails8oz = new ProductDetails()
            {
                Id = "13",
                ProductId = ketoSack.Id,
                LabelSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533594/thng/keto_nut_sack_label_tdvpid.png",
            };

            dbContext.ProductDetails.Add(ketoSackDetails8oz);
            dbContext.SaveChanges();

            SelectOption ketoOption8oz = new SelectOption
            {
                Id = "14",
                ProductDetailsId = ketoSackDetails8oz.Id,
                Option = "8oz"
            };

            ProductDetails ketoSackDetails12oz = new ProductDetails()
            {
                Id = "15",
                ProductId = ketoSack.Id,
                LabelSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533594/thng/keto_nut_sack_label_tdvpid.png",
            };

            dbContext.ProductDetails.Add(ketoSackDetails12oz);
            dbContext.SaveChanges();

            SelectOption ketoOption12oz = new SelectOption
            {
                Id = "16",
                ProductDetailsId = ketoSackDetails12oz.Id,
                Option = "12oz"
            };

            ProductDetails ketoSackDetails16oz = new ProductDetails()
            {
                Id = "17",
                ProductId = ketoSack.Id,
                LabelSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533594/thng/keto_nut_sack_label_tdvpid.png",
            };

            dbContext.ProductDetails.Add(ketoSackDetails16oz);
            dbContext.SaveChanges();

            SelectOption ketoOption16oz = new SelectOption
            {
                Id = "18",
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

            Tag energySackNutsTag = new Tag
            {
                Id = "499",
                Name = "Nuts"
            };

            Tag energySackFruitsTag = new Tag
            {
                Id = "4103",
                Name = "Fruits"
            };

            Tag energySackSeedsTag = new Tag
            {
                Id = "4104",
                Name = "Seeds"
            };

            Tag energySackGranolaTag = new Tag
            {
                Id = "4105",
                Name = "Granola"
            };

            List<Tag> energySackTags = new List<Tag>
            {
                energySackNutsTag,
                energySackFruitsTag,
                energySackSeedsTag,
                energySackGranolaTag
            };

            Product energySack = new Product()
            {
                Id = "19",
                Name = "Energy Nut Sack",
                Subtitle = "Healthy Nut Guys",
                Description = "Energize your Nut Sack with this awesome mix! Almonds, peanuts, and cashews provide long-lasting energy (you're welcome ladies) while the bananas, apple rings, and raisins will provide a quick boost in energy levels! For even more energy, we've topped it off with coconut, dark chocolate chips, and pumpkin seeds. All ingredients are organic so you can enjoy the natural stamina without the crash.",
                Price = (decimal)18.99,
                ImageSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533593/thng/energy_nut_sack_jwssmx.png",                
                CategoryId = nutCategory.Id,
                IsOnSale = true,
                Tags = energySackTags
            };

            dbContext.Products.Add(energySack);
            dbContext.SaveChanges();

            SaleItem energySackSale = new SaleItem
            {
                Id = "20",
                ProductId = energySack.Id,
                ExpireDate = DateTime.Today.AddDays(29),
                Type = OfferType.FreeShipping, // 1 = free shipping, 2 = free stickers, 3 = $, 4 = %, 5 = promo code               
            };

            dbContext.SaleItems.Add(energySackSale);
            dbContext.SaveChanges();

            ProductDetails energySackDetails4oz = new ProductDetails()
            {
                Id = "21",
                ProductId = energySack.Id,
                LabelSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533593/thng/energy_nut_sack_label_y64lpg.png",
            };

            dbContext.ProductDetails.Add(energySackDetails4oz);
            dbContext.SaveChanges();

            SelectOption energyOption4oz = new SelectOption
            {
                Id = "22",
                ProductDetailsId = energySackDetails4oz.Id,
                Option = "4oz"
            };

            ProductDetails energySackDetails8oz = new ProductDetails()
            {
                Id = "23",
                ProductId = energySack.Id,
                LabelSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533593/thng/energy_nut_sack_label_y64lpg.png",
            };

            dbContext.ProductDetails.Add(energySackDetails8oz);
            dbContext.SaveChanges();

            SelectOption energyOption8oz = new SelectOption
            {
                Id = "24",
                ProductDetailsId = energySackDetails8oz.Id,
                Option = "8oz"
            };

            ProductDetails energySackDetails12oz = new ProductDetails()
            {
                Id = "25",
                ProductId = energySack.Id,
                LabelSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533593/thng/energy_nut_sack_label_y64lpg.png",
            };

            dbContext.ProductDetails.Add(energySackDetails12oz);
            dbContext.SaveChanges();

            SelectOption energyOption12oz = new SelectOption
            {
                Id = "26",
                ProductDetailsId = energySackDetails12oz.Id,
                Option = "12oz"
            };

            ProductDetails energySackDetails16oz = new ProductDetails()
            {
                Id = "27",
                ProductId = energySack.Id,
                LabelSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533593/thng/energy_nut_sack_label_y64lpg.png",
            };

            dbContext.ProductDetails.Add(energySackDetails16oz);
            dbContext.SaveChanges();

            SelectOption energyOption16oz = new SelectOption
            {
                Id = "28",
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

            Tag customSackNutsTag = new Tag
            {
                Id = "799",
                Name = "Nuts"
            };

            Tag customSackFruitsTag = new Tag
            {
                Id = "7103",
                Name = "Fruits"
            };

            Tag customSackSeedsTag = new Tag
            {
                Id = "7104",
                Name = "Seeds"
            };

            Tag customSackGranolaTag = new Tag
            {
                Id = "7105",
                Name = "Granola"
            };

            List<Tag> customSackTags = new List<Tag>
            {
                energySackNutsTag,
                energySackFruitsTag,
                energySackSeedsTag,
                energySackGranolaTag
            };

            CustomSack customSack = new CustomSack()
            {
                Id = "29",
                Name = "Custom Nut Sack",
                Subtitle = "Healthy Nut Guys",
                Description = "You tell us how you want our Nut Sack! With the Custom Nut Sack, you get to choose from all of our ingredients to create the Nut Sack you've always wanted! As always, we will fill this Nut Sack with only organic ingredients to provide you with the highest quality, best tasting Nut Sack you have ever had!",
                Price = (decimal)17.99,
                ImageSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533593/thng/custom_nut_sack_zfuek1.png",
                CategoryId = nutCategory.Id,
                IsOnSale = false,
                Tags = customSackTags
            };

            dbContext.CustomSacks.Add(customSack);
            dbContext.SaveChanges();

            CustomSelectOption customSack4oz = new CustomSelectOption
            {
                Id = "30",
                CustomSackId = customSack.Id,
                Option = "4oz"
            };

            CustomSelectOption customSack8oz = new CustomSelectOption
            {
                Id = "31",
                CustomSackId = customSack.Id,
                Option = "8oz"
            };

            CustomSelectOption customSack12oz = new CustomSelectOption
            {
                Id = "32",
                CustomSackId = customSack.Id,
                Option = "12oz"
            };

            CustomSelectOption customSack16oz = new CustomSelectOption
            {
                Id = "33",
                CustomSackId = customSack.Id,
                Option = "16oz"
            };

            List<CustomSelectOption> customSackOptions = new List<CustomSelectOption>
            {
                customSack4oz,
                customSack8oz,
                customSack12oz,
                customSack16oz
            };

            foreach (CustomSelectOption option in customSackOptions)
            {
                dbContext.CustomSelectOptions.Add(option);
                dbContext.SaveChanges();
            }

            MixCategory nuts = new MixCategory
            {
                Id = "34",
                InStock = true,
                Name = "Nuts",
                Type = MixCategoryType.Nuts
            };

            dbContext.MixCategories.Add(nuts);
            dbContext.SaveChanges();

            Ingredient almonds = new Ingredient
            {
                Id = "35",
                MixCategoryId = nuts.Id,
                Name = "Almonds",
                InStock = true
            };

            Ingredient brazilNuts = new Ingredient
            {
                Id = "36",
                MixCategoryId = nuts.Id,
                Name = "Brazil Nuts",
                InStock = true
            };

            Ingredient cachews = new Ingredient
            {
                Id = "37",
                MixCategoryId = nuts.Id,
                Name = "Cachews",
                InStock = true
            };

            Ingredient peanuts = new Ingredient
            {
                Id = "38",
                MixCategoryId = nuts.Id,
                Name = "Peanuts",
                InStock = true
            };

            Ingredient pecans = new Ingredient
            {
                Id = "39",
                MixCategoryId = nuts.Id,
                Name = "Pecans",
                InStock = true
            };

            Ingredient pistachios = new Ingredient
            {
                Id = "40",
                MixCategoryId = nuts.Id,
                Name = "Pistachios",
                InStock = true
            };

            Ingredient walnuts = new Ingredient
            {
                Id = "41",
                MixCategoryId = nuts.Id,
                Name = "Walnuts",
                InStock = true
            };

            List<Ingredient> nutIngredients = new List<Ingredient>
            {
                almonds,
                brazilNuts,
                cachews,
                peanuts,
                pecans,
                pistachios,
                walnuts
            };

            foreach (Ingredient ingredient in nutIngredients)
            {
                dbContext.Ingredients.Add(ingredient);
                dbContext.SaveChanges();
            }

            MixCategory fruits = new MixCategory
            {
                Id = "42",
                InStock = true,
                Name = "Fruits",
                Type = MixCategoryType.Fruits
            };

            dbContext.MixCategories.Add(fruits);
            dbContext.SaveChanges();

            Ingredient appleRings = new Ingredient
            {
                Id = "43",
                MixCategoryId = fruits.Id,
                Name = "Apple Rings",
                InStock = true
            };

            Ingredient apricots = new Ingredient
            {
                Id = "44",
                MixCategoryId = fruits.Id,
                Name = "Appricots",
                InStock = true
            };

            Ingredient bananas = new Ingredient
            {
                Id = "45",
                MixCategoryId = fruits.Id,
                Name = "Bananas",
                InStock = true
            };

            Ingredient cranberries = new Ingredient
            {
                Id = "46",
                MixCategoryId = fruits.Id,
                Name = "Cranberries with cane sugar",
                InStock = true
            };

            Ingredient coconut = new Ingredient
            {
                Id = "47",
                MixCategoryId = fruits.Id,
                Name = "Coconut",
                InStock = true
            };

            Ingredient dates = new Ingredient
            {
                Id = "48",
                MixCategoryId = fruits.Id,
                Name = "Dates",
                InStock = true
            };

            Ingredient mango = new Ingredient
            {
                Id = "49",
                MixCategoryId = fruits.Id,
                Name = "Mango",
                InStock = true
            };

            Ingredient peaches = new Ingredient
            {
                Id = "50",
                MixCategoryId = fruits.Id,
                Name = "Peaches",
                InStock = true
            };

            Ingredient pineapple = new Ingredient
            {
                Id = "51",
                MixCategoryId = fruits.Id,
                Name = "Pineapple",
                InStock = true
            };

            Ingredient raisins = new Ingredient
            {
                Id = "52",
                MixCategoryId = fruits.Id,
                Name = "Raisins",
                InStock = true
            };

            Ingredient sweetCherries = new Ingredient
            {
                Id = "53",
                MixCategoryId = fruits.Id,
                Name = "Sweet Cherries",
                InStock = true
            };

            List<Ingredient> fruitIngredients = new List<Ingredient>
            {
                appleRings,
                apricots,
                bananas,
                cranberries,
                coconut,
                dates,
                mango,
                peaches,
                pineapple,
                raisins,
                sweetCherries
            };

            foreach (Ingredient ingredient in fruitIngredients)
            {
                dbContext.Ingredients.Add(ingredient);
                dbContext.SaveChanges();
            }

            MixCategory seeds = new MixCategory
            {
                Id = "54",
                InStock = true,
                Name = "Seeds",
                Type = MixCategoryType.Seeds
            };

            dbContext.MixCategories.Add(seeds);
            dbContext.SaveChanges();

            Ingredient flax = new Ingredient
            {
                Id = "55",
                MixCategoryId = seeds.Id,
                Name = "Flax",
                InStock = true
            };

            Ingredient hemp = new Ingredient
            {
                Id = "56",
                MixCategoryId = seeds.Id,
                Name = "Hemp",
                InStock = true
            };

            Ingredient pumpkin = new Ingredient
            {
                Id = "57",
                MixCategoryId = seeds.Id,
                Name = "Pumpkin (hulled)",
                InStock = true
            };

            Ingredient sesame = new Ingredient
            {
                Id = "58",
                MixCategoryId = seeds.Id,
                Name = "Sesame (hulled)",
                InStock = true
            };

            Ingredient sunflower = new Ingredient
            {
                Id = "59",
                MixCategoryId = seeds.Id,
                Name = "Sunflower (hulled)",
                InStock = true
            };

            List<Ingredient> seedsIngredients = new List<Ingredient>
            {
                flax,
                hemp,
                pumpkin,
                sesame,
                sunflower
            };

            foreach (Ingredient ingredient in seedsIngredients)
            {
                dbContext.Ingredients.Add(ingredient);
                dbContext.SaveChanges();
            }

            MixCategory granola = new MixCategory
            {
                Id = "60",
                InStock = true,
                Name = "Granola",
                Type = MixCategoryType.Granola
            };

            dbContext.MixCategories.Add(granola);
            dbContext.SaveChanges();

            Ingredient glutenFreeGranola = new Ingredient
            {
                Id = "61",
                MixCategoryId = granola.Id,
                Name = "Gluten Free Granola",
                InStock = true
            };

            Ingredient honeyCachewVanila = new Ingredient
            {
                Id = "62",
                MixCategoryId = granola.Id,
                Name = "Honey Cachew Vanila",
                InStock = true
            };

            Ingredient chocolateHazelnutFig = new Ingredient
            {
                Id = "63",
                MixCategoryId = granola.Id,
                Name = "Chocolate Hazelnut Fig",
                InStock = true
            };

            List<Ingredient> granolaIngredients = new List<Ingredient>
            {
                glutenFreeGranola,
                honeyCachewVanila,
                chocolateHazelnutFig
            };

            foreach (Ingredient ingredient in granolaIngredients)
            {
                dbContext.Ingredients.Add(ingredient);
                dbContext.SaveChanges();
            }

            customSack.MixCategories = new List<MixCategory>
            {
                nuts,
                seeds,
                fruits,
                granola
            };

            PromoCode promoCode = new PromoCode
            {
                Id = "64",
                Type = OfferType.PercentOff, // 1 = free shipping, 2 = free stickers, 3 = $, 4 = %, 5 = promo code 
                Code = "4321",
                DiscountValue = 5
            };

            dbContext.PromoCodes.Add(promoCode);
            dbContext.SaveChanges();

            SpecialOffer specialOffer = new SpecialOffer
            {
                Id = "65",
                PromoCodeId = promoCode.Id,
                ExpireDate = DateTime.Now.AddDays(-100),
                Type = OfferType.PromoCode, // 1 = free shipping, 2 = free stickers, 3 = $, 4 = %, 5 = promo code,                
            };

            SubscriptionOffer weeklySubscription = new SubscriptionOffer
            {
                Id = "66",
                Frequency = Frequency.Weekly, // 1 = weekly, 2 = bi-weekly, 3 = semi-monthly, 4 = monthly, 5 = quarterly,
                Type = OfferType.PercentOff, // 1 = free shipping, 2 = free stickers, 3 = $, 4 = %, 5 = promo code 
                DiscountValue = 20
            };

            SubscriptionOffer biWeeklySubscription = new SubscriptionOffer
            {
                Id = "67",
                Frequency = Frequency.Biweekly, // 1 = weekly, 2 = bi-weekly, 3 = semi-monthly, 4 = monthly, 5 = quarterly,
                Type = OfferType.PercentOff, // 1 = free shipping, 2 = free stickers, 3 = $, 4 = %, 5 = promo code 
                DiscountValue = 20
            };

            SubscriptionOffer semiMonthlySubscription = new SubscriptionOffer
            {
                Id = "68",
                Frequency = Frequency.SemiMonthly, // 1 = weekly, 2 = bi-weekly, 3 = semi-monthly, 4 = monthly, 5 = quarterly,
                Type = OfferType.PercentOff, // 1 = free shipping, 2 = free stickers, 3 = $, 4 = %, 5 = promo code 
                DiscountValue = 20
            };

            SubscriptionOffer monthlySubscription = new SubscriptionOffer
            {
                Id = "69",
                Frequency = Frequency.Monthly, // 1 = weekly, 2 = bi-weekly, 3 = semi-monthly, 4 = monthly, 5 = quarterly,
                Type = OfferType.PercentOff, // 1 = free shipping, 2 = free stickers, 3 = $, 4 = %, 5 = promo code 
                DiscountValue = 20
            };

            SubscriptionOffer quarterlyMonthlySubscription = new SubscriptionOffer
            {
                Id = "70",
                Frequency = Frequency.Quarterly, // 1 = weekly, 2 = bi-weekly, 3 = semi-monthly, 4 = monthly, 5 = quarterly,
                Type = OfferType.PercentOff, // 1 = free shipping, 2 = free stickers, 3 = $, 4 = %, 5 = promo code 
                DiscountValue = 20
            };

            SubscriptionOffer limitedExpiredTimeSubscription = new SubscriptionOffer
            {
                Id = "71",
                Frequency = Frequency.SemiMonthly, // 1 = weekly, 2 = bi-weekly, 3 = semi-monthly, 4 = monthly, 5 = quarterly,
                Type = OfferType.PercentOff, // 1 = free shipping, 2 = free stickers, 3 = $, 4 = %, 5 = promo code 
                DiscountValue = 25,
                StandardOffer = false,                
                StartDate = DateTime.Today,
                ExpireDate = DateTime.Now.AddDays(-1),                
            };

            List<SubscriptionOffer> subscriptionOffers = new List<SubscriptionOffer>
            {
                weeklySubscription,
                biWeeklySubscription,
                semiMonthlySubscription,
                monthlySubscription,
                quarterlyMonthlySubscription,
                limitedExpiredTimeSubscription
            };

            foreach (SubscriptionOffer offer in subscriptionOffers)
            {
                dbContext.SubscriptionOffers.Add(offer);
                dbContext.SaveChanges();
            }

            SubscriptionOffer limitedTimeSubscriptionWeekly = new SubscriptionOffer
            {
                Id = "72",
                Frequency = Frequency.Weekly, // 1 = weekly, 2 = bi-weekly, 3 = semi-monthly, 4 = monthly, 5 = quarterly,                                
                Type = OfferType.Special, // 1 = free shipping, 2 = free stickers, 3 = $, 4 = %, 5 = promo code, 6 special offer
                StandardOffer = false,
                DiscountValue = 20,
                StartDate = DateTime.Today,
                ExpireDate = DateTime.Now.AddDays(45),
            };

            SubscriptionOffer limitedTimeSubscriptionBiWeekly = new SubscriptionOffer
            {
                Id = "73",
                Frequency = Frequency.Biweekly, // 1 = weekly, 2 = bi-weekly, 3 = semi-monthly, 4 = monthly, 5 = quarterly,                                
                Type = OfferType.Special, // 1 = free shipping, 2 = free stickers, 3 = $, 4 = %, 5 = promo code, 6 special offer
                StandardOffer = false,
                DiscountValue = 20,
                StartDate = DateTime.Today,
                ExpireDate = DateTime.Now.AddDays(45),
            };

            SubscriptionOffer limitedTimeSubscriptionSemiMonthly = new SubscriptionOffer
            {
                Id = "74",
                Frequency = Frequency.SemiMonthly, // 1 = weekly, 2 = bi-weekly, 3 = semi-monthly, 4 = monthly, 5 = quarterly,                                
                Type = OfferType.Special, // 1 = free shipping, 2 = free stickers, 3 = $, 4 = %, 5 = promo code, 6 special offer
                StandardOffer = false,
                DiscountValue = 20,
                StartDate = DateTime.Today,
                ExpireDate = DateTime.Now.AddDays(45),
            };

            SubscriptionOffer limitedTimeMonthly = new SubscriptionOffer
            {
                Id = "75",
                Frequency = Frequency.SemiMonthly, // 1 = weekly, 2 = bi-weekly, 3 = semi-monthly, 4 = monthly, 5 = quarterly,                                
                Type = OfferType.Special, // 1 = free shipping, 2 = free stickers, 3 = $, 4 = %, 5 = promo code, 6 special offer
                StandardOffer = false,
                DiscountValue = 20,
                StartDate = DateTime.Today,
                ExpireDate = DateTime.Now.AddDays(45),                
            };

            List<SubscriptionOffer> specialSubscriptions = new List<SubscriptionOffer>
            {
                limitedTimeSubscriptionWeekly,
                limitedTimeSubscriptionBiWeekly,
                limitedTimeSubscriptionSemiMonthly,
                limitedTimeMonthly
            };

            foreach (SubscriptionOffer offer in specialSubscriptions)
            {
                dbContext.SubscriptionOffers.Add(offer);
                dbContext.SaveChanges();
            }

            SpecialOffer freeShippingNextOrder = new SpecialOffer
            {
                Id = "76",
                Type = OfferType.FreeShipping, // 1 = free shipping, 2 = free stickers, 3 = $, 4 = %, 5 = promo code,       
                AppliesNextOrder = true,
                Scope = OfferScope.Subscription, //1 = store wide, 2 = specific to subscription offer
            };

            dbContext.SpecialOffers.Add(freeShippingNextOrder);
            dbContext.SaveChanges();

            PromoCode shopWidePromoCode = new PromoCode
            {
                Id = "1s232",
                Code = "123123",
                ExpireDate = DateTime.Now.AddDays(15),
                Type = OfferType.PercentOff,
                DiscountValue = (decimal)10.00
            };

            dbContext.PromoCodes.Add(shopWidePromoCode);
            dbContext.SaveChanges();

            SpecialOffer storeWidePromoCode = new SpecialOffer
            {
                Id = "7456",
                PromoCodeId = shopWidePromoCode.Id,
                ExpireDate = DateTime.Now.AddDays(150),
                Type = OfferType.PromoCode, // 1 = free shipping, 2 = free stickers, 3 = $, 4 = %, 5 = promo code,       
                AppliesNextOrder = false,                
                Scope = OfferScope.Shop, //1 = store wide, 2 = specific to subscription offer
            };

            dbContext.SpecialOffers.Add(storeWidePromoCode);
            dbContext.SaveChanges();
            

            foreach (SubscriptionOffer offer in specialSubscriptions)
            {
                offer.SpecialOfferId = freeShippingNextOrder.Id;                       
            }

            ApplicationUser sysAdmin = userManager.Users.First(u => u.FirstName.ToLower().Contains("Oskar"));

            UserSubscription userSubscription = new UserSubscription
            {
                Id = "77",
                ApplicationUserId = sysAdmin.Id,
                SubscriptionOfferId = limitedExpiredTimeSubscription.Id,
                Frequency = limitedTimeSubscriptionWeekly.Frequency,
                Modified = DateTime.Now,
                NextDelivery = DateTime.Today.AddDays(7),
                SpecialOffers = new List<SpecialOffer>
                {
                    freeShippingNextOrder
                }
            };

            dbContext.UserSubscriptions.Add(userSubscription);
            dbContext.SaveChanges();
        }
        
    }
}

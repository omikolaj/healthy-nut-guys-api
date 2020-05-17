using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                Id = Guid.NewGuid().ToString(),
                Name = "Nut Sacks"
            };

            dbContext.Categories.Add(nutCategory);
            dbContext.SaveChanges();

            Tag nutsTag = new Tag
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Nuts"
            };

            Tag fruitsTag = new Tag
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Fruits"
            };

            Tag seedsTag = new Tag
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Seeds"
            };

            Tag granolaTag = new Tag
            {
                Id = Guid.NewGuid().ToString(),
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
            
            ///////////////////////////////////////////SALES///////////////////////////////////////////////
            // SALES HAVE TO BE RE-DONE. THEY MUST BE TIED TO PRODUCTDETAILS OR CUSTOMSELECTOPTION
            // EACH PRODUCTDETAILS HAS TO HAVE CORRESPONDING SALEITEM, EACH CUSTOMSELECTOPTION
            // MUST HAVE A CORRESPONDING SALEITEM IF ITEM IS ON SALE
            // IsOnSale property should be on both Product and individual PRODUCTDETAILS OR CUSTOMSELECTOPTION

            // CURRENT IMPLEMENTATION TIES A SINGLE SALE-ITEM TO EITHER PRODUCT OR CUSTOM PRODUCT

            Product succulentSack = new Product()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Succulent Nut Sack",
                Subtitle = "Healthy Nut Guys",
                Description = "This savory, Succulent Nut Sack will leave you drooling! A decadent mix of white and milk chocolate chips, raisins, dried cranberries, peanuts, almonds, and cashews. As if that wasn't enough to make you nut...I mean, go nuts...we've topped it off with our delicious honey cashew vanilla granola. This organic Succulent Nut Sack is the thing of your wildest trail mix dreams!",                
                ImageSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533594/thng/succulent_nut_sack_aa2ujs.png",
                CategoryId = nutCategory.Id,
                IsOnSale = false,
                Tags = tags
            };

            dbContext.Products.Add(succulentSack);
            dbContext.SaveChanges();

            SaleItem succulentSackSale = new SaleItem
            {
                Id = Guid.NewGuid().ToString(),
                ProductId = succulentSack.Id,
                ExpireDate = DateTime.Now.AddDays(100),
                Type = OfferType.PercentOff, // 1 = free shipping, 2 = free stickers, 3 = $, 4 = %, 5 = promo code 
                DiscountValue = 5,
                SalePrice = (decimal)15.99,
            };

            dbContext.SaleItems.Add(succulentSackSale);
            dbContext.SaveChanges();

            ProductDetails succulentDetails4oz = new ProductDetails()
            {
                Id = Guid.NewGuid().ToString(),
                Price = (decimal)17.99,
                ProductId = succulentSack.Id,
                LabelSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533593/thng/succulent_nut_sack_label_s2glru.png",
            };

            dbContext.ProductDetails.Add(succulentDetails4oz);
            dbContext.SaveChanges();

            SelectOption option4oz = new SelectOption
            {
                Id = Guid.NewGuid().ToString(),
                ProductDetailsId = succulentDetails4oz.Id,
                Option = "4oz"
            };

            ProductDetails succulentDetails8oz = new ProductDetails()
            {
                Id = Guid.NewGuid().ToString(),
                Price = (decimal)18.99,
                ProductId = succulentSack.Id,
                LabelSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533593/thng/succulent_nut_sack_label_s2glru.png",
            };

            dbContext.ProductDetails.Add(succulentDetails8oz);
            dbContext.SaveChanges();

            SelectOption option8oz = new SelectOption
            {
                Id = Guid.NewGuid().ToString(),
                ProductDetailsId = succulentDetails8oz.Id,
                Option = "8oz"
            };

            ProductDetails succulentDetails12oz = new ProductDetails()
            {
                Id = Guid.NewGuid().ToString(),
                Price = (decimal)19.99,
                ProductId = succulentSack.Id,
                LabelSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533593/thng/succulent_nut_sack_label_s2glru.png",
            };

            dbContext.ProductDetails.Add(succulentDetails12oz);
            dbContext.SaveChanges();

            SelectOption option12oz = new SelectOption
            {
                Id = Guid.NewGuid().ToString(),
                ProductDetailsId = succulentDetails12oz.Id,
                Option = "12oz",
            };

            ProductDetails succulentDetails16oz = new ProductDetails()
            {
                Id = Guid.NewGuid().ToString(),
                ProductId = succulentSack.Id,
                Price = (decimal)20.99,
                LabelSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533593/thng/succulent_nut_sack_label_s2glru.png",
            };

            dbContext.ProductDetails.Add(succulentDetails16oz);
            dbContext.SaveChanges();

            SelectOption option16oz = new SelectOption
            {
                Id = Guid.NewGuid().ToString(),
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
                Id = Guid.NewGuid().ToString(),
                Name = "Nuts"
            };

            Tag ketoSackFruitsTag = new Tag
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Fruits"
            };

            Tag ketoSackSeedsTag = new Tag
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Seeds"
            };

            Tag ketoSackGranolaTag = new Tag
            {
                Id = Guid.NewGuid().ToString(),
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
                Id = Guid.NewGuid().ToString(),
                Name = "Keto Nut Sack",
                Subtitle = "Healthy Nut Guys",
                Description = "This blend of nuts and seeds is perfect for your ketogenic lifestyle! The nut blend of peanuts, Brazil nuts, almonds, and pecans mixed with sesame and sunflower seeds will help keep you in ketosis while providing essential fats, vitamins, and antioxidants. This organic, high-fiber Nut Sack will keep you full, ripped, and craving more of our nuts!",                
                ImageSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533594/thng/keto_nut_sack_kfgj2w.png",
                CategoryId = nutCategory.Id,
                IsOnSale = false,
                Tags = ketoSackTags
            };

            dbContext.Products.Add(ketoSack);
            dbContext.SaveChanges();

            SaleItem ketoSaleItem = new SaleItem
            {
                Id = Guid.NewGuid().ToString(),
                ProductId = ketoSack.Id,
                ExpireDate = DateTime.Now.AddDays(100),
                Type = OfferType.AmountOff, // 1 = free shipping, 2 = free stickers, 3 = $, 4 = %, 5 = promo code 
                DiscountValue = (decimal)2.99,
                SalePrice = (decimal)20.99
            };

            dbContext.SaleItems.Add(ketoSaleItem);
            dbContext.SaveChanges();

            ProductDetails ketoSackDetails4oz = new ProductDetails()
            {
                Id = Guid.NewGuid().ToString(),
                ProductId = ketoSack.Id,
                Price = (decimal)22.99,
                LabelSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533594/thng/keto_nut_sack_label_tdvpid.png",
            };

            dbContext.ProductDetails.Add(ketoSackDetails4oz);
            dbContext.SaveChanges();

            SelectOption ketoOption4oz = new SelectOption
            {
                Id = Guid.NewGuid().ToString(),
                ProductDetailsId = ketoSackDetails4oz.Id,
                Option = "4oz"
            };

            ProductDetails ketoSackDetails8oz = new ProductDetails()
            {
                Id = Guid.NewGuid().ToString(),
                ProductId = ketoSack.Id,
                Price = (decimal)23.99,
                LabelSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533594/thng/keto_nut_sack_label_tdvpid.png",
            };

            dbContext.ProductDetails.Add(ketoSackDetails8oz);
            dbContext.SaveChanges();

            SelectOption ketoOption8oz = new SelectOption
            {
                Id = Guid.NewGuid().ToString(),
                ProductDetailsId = ketoSackDetails8oz.Id,
                Option = "8oz"
            };

            ProductDetails ketoSackDetails12oz = new ProductDetails()
            {
                Id = Guid.NewGuid().ToString(),
                ProductId = ketoSack.Id,
                Price = (decimal)23.99,
                LabelSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533594/thng/keto_nut_sack_label_tdvpid.png",
            };

            dbContext.ProductDetails.Add(ketoSackDetails12oz);
            dbContext.SaveChanges();

            SelectOption ketoOption12oz = new SelectOption
            {
                Id = Guid.NewGuid().ToString(),
                ProductDetailsId = ketoSackDetails12oz.Id,
                Option = "12oz"
            };

            ProductDetails ketoSackDetails16oz = new ProductDetails()
            {
                Id = Guid.NewGuid().ToString(),
                ProductId = ketoSack.Id,
                Price = (decimal)22.99,
                LabelSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533594/thng/keto_nut_sack_label_tdvpid.png",
            };

            dbContext.ProductDetails.Add(ketoSackDetails16oz);
            dbContext.SaveChanges();

            SelectOption ketoOption16oz = new SelectOption
            {
                Id = Guid.NewGuid().ToString(),
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
                Id = Guid.NewGuid().ToString(),
                Name = "Nuts"
            };

            Tag energySackFruitsTag = new Tag
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Fruits"
            };

            Tag energySackSeedsTag = new Tag
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Seeds"
            };

            Tag energySackGranolaTag = new Tag
            {
                Id = Guid.NewGuid().ToString(),
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
                Id = Guid.NewGuid().ToString(),
                Name = "Energy Nut Sack",                
                Subtitle = "Healthy Nut Guys",
                Description = "Energize your Nut Sack with this awesome mix! Almonds, peanuts, and cashews provide long-lasting energy (you're welcome ladies) while the bananas, apple rings, and raisins will provide a quick boost in energy levels! For even more energy, we've topped it off with coconut, dark chocolate chips, and pumpkin seeds. All ingredients are organic so you can enjoy the natural stamina without the crash.",                
                ImageSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533593/thng/energy_nut_sack_jwssmx.png",                
                CategoryId = nutCategory.Id,
                IsOnSale = false,
                Tags = energySackTags
            };

            dbContext.Products.Add(energySack);
            dbContext.SaveChanges();

            SaleItem energySackSale = new SaleItem
            {
                Id = Guid.NewGuid().ToString(),
                ProductId = energySack.Id,
                ExpireDate = DateTime.Now.AddDays(29),
                Type = OfferType.FreeShipping, // 1 = free shipping, 2 = free stickers, 3 = $, 4 = %, 5 = promo code               
            };

            dbContext.SaleItems.Add(energySackSale);
            dbContext.SaveChanges();

            ProductDetails energySackDetails4oz = new ProductDetails()
            {
                Id = Guid.NewGuid().ToString(),
                ProductId = energySack.Id,
                Price = (decimal)19.99,
                LabelSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533593/thng/energy_nut_sack_label_y64lpg.png",
            };

            dbContext.ProductDetails.Add(energySackDetails4oz);
            dbContext.SaveChanges();

            SelectOption energyOption4oz = new SelectOption
            {
                Id = Guid.NewGuid().ToString(),
                ProductDetailsId = energySackDetails4oz.Id,
                Option = "4oz"
            };

            ProductDetails energySackDetails8oz = new ProductDetails()
            {
                Id = Guid.NewGuid().ToString(),
                ProductId = energySack.Id,
                Price = (decimal)20.99,
                LabelSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533593/thng/energy_nut_sack_label_y64lpg.png",
            };

            dbContext.ProductDetails.Add(energySackDetails8oz);
            dbContext.SaveChanges();

            SelectOption energyOption8oz = new SelectOption
            {
                Id = Guid.NewGuid().ToString(),
                ProductDetailsId = energySackDetails8oz.Id,
                Option = "8oz"
            };

            ProductDetails energySackDetails12oz = new ProductDetails()
            {
                Id = Guid.NewGuid().ToString(),
                ProductId = energySack.Id,
                Price = (decimal)21.99,
                LabelSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533593/thng/energy_nut_sack_label_y64lpg.png",
            };

            dbContext.ProductDetails.Add(energySackDetails12oz);
            dbContext.SaveChanges();

            SelectOption energyOption12oz = new SelectOption
            {
                Id = Guid.NewGuid().ToString(),
                ProductDetailsId = energySackDetails12oz.Id,
                Option = "12oz"
            };

            ProductDetails energySackDetails16oz = new ProductDetails()
            {
                Id = Guid.NewGuid().ToString(),
                ProductId = energySack.Id,
                Price = (decimal)21.99,
                LabelSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533593/thng/energy_nut_sack_label_y64lpg.png",
            };

            dbContext.ProductDetails.Add(energySackDetails16oz);
            dbContext.SaveChanges();

            SelectOption energyOption16oz = new SelectOption
            {
                Id = Guid.NewGuid().ToString(),
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
                Id = Guid.NewGuid().ToString(),
                Name = "Nuts"
            };

            Tag customSackFruitsTag = new Tag
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Fruits"
            };

            Tag customSackSeedsTag = new Tag
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Seeds"
            };

            Tag customSackGranolaTag = new Tag
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Granola"
            };

            List<Tag> customSackTags = new List<Tag>
            {
                energySackNutsTag,
                energySackFruitsTag,
                energySackSeedsTag,
                energySackGranolaTag
            };

            CustomProduct customSack = new CustomProduct()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Custom Nut Sack",
                Subtitle = "Healthy Nut Guys",
                Type = CustomProductType.CustomSack,
                Description = "You tell us how you want our Nut Sack! With the Custom Nut Sack, you get to choose from all of our ingredients to create the Nut Sack you've always wanted! As always, we will fill this Nut Sack with only organic ingredients to provide you with the highest quality, best tasting Nut Sack you have ever had!",                
                ImageSrc = "https://res.cloudinary.com/healthynutguys/image/upload/f_auto,q_70,w_512/v1588533593/thng/custom_nut_sack_zfuek1.png",
                CategoryId = nutCategory.Id,
                IsOnSale = false,
                Tags = customSackTags
            };

            dbContext.CustomProducts.Add(customSack);
            dbContext.SaveChanges();

            SaleItem customSackSale = new SaleItem
            {
                Id = Guid.NewGuid().ToString(),
                CustomProductId = customSack.Id,
                Type = OfferType.FreeShipping,
                ExpireDate = DateTime.Now.AddDays(45)
            };

            dbContext.SaleItems.Add(customSackSale);
            dbContext.SaveChanges();

            CustomSelectOption customSack4oz = new CustomSelectOption
            {
                Id = Guid.NewGuid().ToString(),
                CustomProductId = customSack.Id,
                Option = "4oz",
                Price = (decimal)17.99,
            };

            CustomSelectOption customSack8oz = new CustomSelectOption
            {
                Id = Guid.NewGuid().ToString(),
                CustomProductId = customSack.Id,
                Option = "8oz",
                Price = (decimal)18.99,
            };

            CustomSelectOption customSack12oz = new CustomSelectOption
            {
                Id = Guid.NewGuid().ToString(),
                CustomProductId = customSack.Id,
                Option = "12oz",
                Price = (decimal)19.99,
            };

            CustomSelectOption customSack16oz = new CustomSelectOption
            {
                Id = Guid.NewGuid().ToString(),
                CustomProductId = customSack.Id,
                Option = "16oz",
                Price = (decimal)20.99,
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
                Id = Guid.NewGuid().ToString(),
                InStock = true,
                Order = 1,
                CustomProductId = customSack.Id,
                Name = "Nuts",
                Type = MixCategoryType.Nuts
            };

            dbContext.MixCategories.Add(nuts);
            dbContext.SaveChanges();

            Ingredient almonds = new Ingredient
            {
                Id = Guid.NewGuid().ToString(),
                MixCategoryId = nuts.Id,
                Name = "Almonds",
                InStock = true
            };

            Ingredient brazilNuts = new Ingredient
            {
                Id = Guid.NewGuid().ToString(),
                MixCategoryId = nuts.Id,
                Name = "Brazil Nuts",
                InStock = true
            };

            Ingredient cachews = new Ingredient
            {
                Id = Guid.NewGuid().ToString(),
                MixCategoryId = nuts.Id,
                Name = "Cachews",
                InStock = true
            };

            Ingredient peanuts = new Ingredient
            {
                Id = Guid.NewGuid().ToString(),
                MixCategoryId = nuts.Id,
                Name = "Peanuts",
                InStock = true
            };

            Ingredient pecans = new Ingredient
            {
                Id = Guid.NewGuid().ToString(),
                MixCategoryId = nuts.Id,
                Name = "Pecans",
                InStock = true
            };

            Ingredient pistachios = new Ingredient
            {
                Id = Guid.NewGuid().ToString(),
                MixCategoryId = nuts.Id,
                Name = "Pistachios",
                InStock = true
            };

            Ingredient walnuts = new Ingredient
            {
                Id = Guid.NewGuid().ToString(),
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
                Id = Guid.NewGuid().ToString(),
                InStock = true,
                Order = 2,
                CustomProductId = customSack.Id,
                Name = "Fruits",
                Type = MixCategoryType.Fruits
            };

            dbContext.MixCategories.Add(fruits);
            dbContext.SaveChanges();

            Ingredient appleRings = new Ingredient
            {
                Id = Guid.NewGuid().ToString(),
                MixCategoryId = fruits.Id,
                Name = "Apple Rings",
                InStock = true
            };

            Ingredient apricots = new Ingredient
            {
                Id = Guid.NewGuid().ToString(),
                MixCategoryId = fruits.Id,
                Name = "Appricots",
                InStock = true
            };

            Ingredient bananas = new Ingredient
            {
                Id = Guid.NewGuid().ToString(),
                MixCategoryId = fruits.Id,
                Name = "Bananas",
                InStock = false
            };

            Ingredient cranberries = new Ingredient
            {
                Id = Guid.NewGuid().ToString(),
                MixCategoryId = fruits.Id,
                Name = "Cranberries with cane sugar",
                InStock = true
            };

            Ingredient coconut = new Ingredient
            {
                Id = Guid.NewGuid().ToString(),
                MixCategoryId = fruits.Id,
                Name = "Coconut",
                InStock = false
            };

            Ingredient dates = new Ingredient
            {
                Id = Guid.NewGuid().ToString(),
                MixCategoryId = fruits.Id,
                Name = "Dates",
                InStock = true
            };

            Ingredient mango = new Ingredient
            {
                Id = Guid.NewGuid().ToString(),
                MixCategoryId = fruits.Id,
                Name = "Mango",
                InStock = true
            };

            Ingredient peaches = new Ingredient
            {
                Id = Guid.NewGuid().ToString(),
                MixCategoryId = fruits.Id,
                Name = "Peaches",
                InStock = true
            };

            Ingredient pineapple = new Ingredient
            {
                Id = Guid.NewGuid().ToString(),
                MixCategoryId = fruits.Id,
                Name = "Pineapple",
                InStock = true
            };

            Ingredient raisins = new Ingredient
            {
                Id = Guid.NewGuid().ToString(),
                MixCategoryId = fruits.Id,
                Name = "Raisins",
                InStock = true
            };

            Ingredient sweetCherries = new Ingredient
            {
                Id = Guid.NewGuid().ToString(),
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
                Id = Guid.NewGuid().ToString(),
                InStock = true,
                Order = 3,
                CustomProductId = customSack.Id,
                Name = "Seeds",
                Type = MixCategoryType.Seeds
            };

            dbContext.MixCategories.Add(seeds);
            dbContext.SaveChanges();

            Ingredient flax = new Ingredient
            {
                Id = Guid.NewGuid().ToString(),
                MixCategoryId = seeds.Id,
                Name = "Flax",
                InStock = true
            };

            Ingredient hemp = new Ingredient
            {
                Id = Guid.NewGuid().ToString(),
                MixCategoryId = seeds.Id,
                Name = "Hemp",
                InStock = true
            };

            Ingredient pumpkin = new Ingredient
            {
                Id = Guid.NewGuid().ToString(),
                MixCategoryId = seeds.Id,
                Name = "Pumpkin (hulled)",
                InStock = true
            };

            Ingredient sesame = new Ingredient
            {
                Id = Guid.NewGuid().ToString(),
                MixCategoryId = seeds.Id,
                Name = "Sesame (hulled)",
                InStock = true
            };

            Ingredient sunflower = new Ingredient
            {
                Id = Guid.NewGuid().ToString(),
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
                Id = Guid.NewGuid().ToString(),
                InStock = false,
                Order = 4,
                CustomProductId = customSack.Id,
                Name = "Granola",
                Type = MixCategoryType.Granola
            };

            dbContext.MixCategories.Add(granola);
            dbContext.SaveChanges();

            Ingredient glutenFreeGranola = new Ingredient
            {
                Id = Guid.NewGuid().ToString(),
                MixCategoryId = granola.Id,
                Name = "Gluten Free Granola",
                InStock = true
            };

            Ingredient honeyCachewVanila = new Ingredient
            {
                Id = Guid.NewGuid().ToString(),
                MixCategoryId = granola.Id,
                Name = "Honey Cachew Vanila",
                InStock = true
            };

            Ingredient chocolateHazelnutFig = new Ingredient
            {
                Id = Guid.NewGuid().ToString(),
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
                Id = Guid.NewGuid().ToString(),
                Type = OfferType.PercentOff, // 1 = free shipping, 2 = free stickers, 3 = $, 4 = %, 5 = promo code 
                Code = "4321",
                DiscountValue = 5
            };

            dbContext.PromoCodes.Add(promoCode);
            dbContext.SaveChanges();

            SpecialOffer specialOffer = new SpecialOffer
            {
                Id = Guid.NewGuid().ToString(),
                PromoCodeId = promoCode.Id,
                ExpireDate = DateTime.Now.AddDays(-100),
                Type = OfferType.PromoCode, // 1 = free shipping, 2 = free stickers, 3 = $, 4 = %, 5 = promo code,                
            };

            SubscriptionOffer weeklySubscription = new SubscriptionOffer
            {
                Id = Guid.NewGuid().ToString(),
                Frequency = Frequency.Weekly, // 1 = weekly, 2 = bi-weekly, 3 = semi-monthly, 4 = monthly, 5 = quarterly,
                Type = OfferType.PercentOff, // 1 = free shipping, 2 = free stickers, 3 = $, 4 = %, 5 = promo code 
                DiscountValue = 20
            };

            SubscriptionOffer biWeeklySubscription = new SubscriptionOffer
            {
                Id = Guid.NewGuid().ToString(),
                Frequency = Frequency.Biweekly, // 1 = weekly, 2 = bi-weekly, 3 = semi-monthly, 4 = monthly, 5 = quarterly,
                Type = OfferType.PercentOff, // 1 = free shipping, 2 = free stickers, 3 = $, 4 = %, 5 = promo code 
                DiscountValue = 20
            };

            SubscriptionOffer semiMonthlySubscription = new SubscriptionOffer
            {
                Id = Guid.NewGuid().ToString(),
                Frequency = Frequency.SemiMonthly, // 1 = weekly, 2 = bi-weekly, 3 = semi-monthly, 4 = monthly, 5 = quarterly,
                Type = OfferType.PercentOff, // 1 = free shipping, 2 = free stickers, 3 = $, 4 = %, 5 = promo code 
                DiscountValue = 20
            };

            SubscriptionOffer monthlySubscription = new SubscriptionOffer
            {
                Id = Guid.NewGuid().ToString(),
                Frequency = Frequency.Monthly, // 1 = weekly, 2 = bi-weekly, 3 = semi-monthly, 4 = monthly, 5 = quarterly,
                Type = OfferType.PercentOff, // 1 = free shipping, 2 = free stickers, 3 = $, 4 = %, 5 = promo code 
                DiscountValue = 20
            };

            SubscriptionOffer quarterlyMonthlySubscription = new SubscriptionOffer
            {
                Id = Guid.NewGuid().ToString(),
                Frequency = Frequency.Quarterly, // 1 = weekly, 2 = bi-weekly, 3 = semi-monthly, 4 = monthly, 5 = quarterly,
                Type = OfferType.PercentOff, // 1 = free shipping, 2 = free stickers, 3 = $, 4 = %, 5 = promo code 
                DiscountValue = 20
            };

            SubscriptionOffer limitedExpiredTimeSubscription = new SubscriptionOffer
            {
                Id = Guid.NewGuid().ToString(),
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
                Id = Guid.NewGuid().ToString(),
                Frequency = Frequency.Weekly, // 1 = weekly, 2 = bi-weekly, 3 = semi-monthly, 4 = monthly, 5 = quarterly,                                
                Type = OfferType.Special, // 1 = free shipping, 2 = free stickers, 3 = $, 4 = %, 5 = promo code, 6 special offer
                StandardOffer = false,
                DiscountValue = 20,
                StartDate = DateTime.Today,
                ExpireDate = DateTime.Now.AddDays(45),
            };

            SubscriptionOffer limitedTimeSubscriptionBiWeekly = new SubscriptionOffer
            {
                Id = Guid.NewGuid().ToString(),
                Frequency = Frequency.Biweekly, // 1 = weekly, 2 = bi-weekly, 3 = semi-monthly, 4 = monthly, 5 = quarterly,                                
                Type = OfferType.Special, // 1 = free shipping, 2 = free stickers, 3 = $, 4 = %, 5 = promo code, 6 special offer
                StandardOffer = false,
                DiscountValue = 20,
                StartDate = DateTime.Today,
                ExpireDate = DateTime.Now.AddDays(45),
            };

            SubscriptionOffer limitedTimeSubscriptionSemiMonthly = new SubscriptionOffer
            {
                Id = Guid.NewGuid().ToString(),
                Frequency = Frequency.SemiMonthly, // 1 = weekly, 2 = bi-weekly, 3 = semi-monthly, 4 = monthly, 5 = quarterly,                                
                Type = OfferType.Special, // 1 = free shipping, 2 = free stickers, 3 = $, 4 = %, 5 = promo code, 6 special offer
                StandardOffer = false,
                DiscountValue = 20,
                StartDate = DateTime.Today,
                ExpireDate = DateTime.Now.AddDays(45),
            };

            SubscriptionOffer limitedTimeMonthly = new SubscriptionOffer
            {
                Id = Guid.NewGuid().ToString(),
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
                Id = Guid.NewGuid().ToString(),
                ExpireDate = DateTime.Now.AddDays(100),
                Type = OfferType.FreeShipping, // 1 = free shipping, 2 = free stickers, 3 = $, 4 = %, 5 = promo code,       
                AppliesNextOrder = true,
                Scope = OfferScope.Subscription, //1 = store wide, 2 = specific to subscription offer
            };

            dbContext.SpecialOffers.Add(freeShippingNextOrder);
            dbContext.SaveChanges();

            PromoCode shopWidePromoCode = new PromoCode
            {
                Id = Guid.NewGuid().ToString(),
                Code = "123123",
                ExpireDate = DateTime.Now.AddDays(15),
                Type = OfferType.PercentOff,
                DiscountValue = (decimal)10.00
            };

            dbContext.PromoCodes.Add(shopWidePromoCode);
            dbContext.SaveChanges();

            SpecialOffer storeWidePromoCode = new SpecialOffer
            {
                Id = Guid.NewGuid().ToString(),
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
                Id = Guid.NewGuid().ToString(),
                ApplicationUserId = sysAdmin.Id,
                SubscriptionOfferId = limitedExpiredTimeSubscription.Id,
                Frequency = limitedTimeSubscriptionWeekly.Frequency,
                Modified = DateTime.Now,
                NextDelivery = DateTime.Today.AddDays(7),
                SpecialOffers = new List<SpecialOffer>
                {
                    freeShippingNextOrder
                },
            };

            dbContext.UserSubscriptions.Add(userSubscription);
            dbContext.SaveChanges();

            #region 16oz CustomSack
            UserSubscriptionProduct subscriptionProduct = new UserSubscriptionProduct
            {
                Id = Guid.NewGuid().ToString(),
                CustomProductId = customSack.Id,
                CustomSelectOptionId = customSack16oz.Id,
                UserSubscriptionId = userSubscription.Id               
            };

            dbContext.UserSubscriptionProducts.Add(subscriptionProduct);
            dbContext.SaveChanges();
            
            UserSubscriptionMixCategory subscriptionNutsMixCategory = new UserSubscriptionMixCategory
            {
                Id = Guid.NewGuid().ToString(),
                MixCategoryId = nuts.Id,
                UserSubscriptionProductId = subscriptionProduct.Id,
            };

            UserSubscriptionMixCategory subscriptionFuitsMixCategory = new UserSubscriptionMixCategory
            {
                Id = Guid.NewGuid().ToString(),
                MixCategoryId = fruits.Id,
                UserSubscriptionProductId = subscriptionProduct.Id,
            };

            UserSubscriptionMixCategory subscriptionSeedsMixCategory = new UserSubscriptionMixCategory
            {
                Id = Guid.NewGuid().ToString(),
                MixCategoryId = seeds.Id,
                UserSubscriptionProductId = subscriptionProduct.Id,
            };

            List<UserSubscriptionMixCategory> mixCategories16 = new List<UserSubscriptionMixCategory> {
                subscriptionNutsMixCategory,
                subscriptionFuitsMixCategory,
                subscriptionSeedsMixCategory
            };

            foreach (UserSubscriptionMixCategory mix in mixCategories16)
            {
                dbContext.UserSubscriptionMixCategories.Add(mix);
                dbContext.SaveChanges();
            }

            UserSubscriptionMixCategoryIngredient cachewsIngredient = new UserSubscriptionMixCategoryIngredient
            {
                Id = Guid.NewGuid().ToString(),
                IngredientId = cachews.Id,
                Weight = 2,
                UserSubscriptionMixCategoryId = subscriptionNutsMixCategory.Id
            };

            UserSubscriptionMixCategoryIngredient walnutsIngredient = new UserSubscriptionMixCategoryIngredient
            {
                Id = Guid.NewGuid().ToString(),
                IngredientId = walnuts.Id,
                Weight = 2,
                UserSubscriptionMixCategoryId = subscriptionNutsMixCategory.Id
            };

            UserSubscriptionMixCategoryIngredient peanutsIngredient = new UserSubscriptionMixCategoryIngredient
            {
                Id = Guid.NewGuid().ToString(),
                IngredientId = peanuts.Id,
                Weight = 4,
                UserSubscriptionMixCategoryId = subscriptionNutsMixCategory.Id
            };

            UserSubscriptionMixCategoryIngredient bananaIngredient = new UserSubscriptionMixCategoryIngredient
            {
                Id = Guid.NewGuid().ToString(),
                IngredientId = bananas.Id,
                Weight = 2,
                UserSubscriptionMixCategoryId = subscriptionFuitsMixCategory.Id
            };

            UserSubscriptionMixCategoryIngredient sesameIngredient = new UserSubscriptionMixCategoryIngredient
            {
                Id = Guid.NewGuid().ToString(),
                IngredientId = sesame.Id,
                Weight = 6,
                UserSubscriptionMixCategoryId = subscriptionSeedsMixCategory.Id
            };

            List<UserSubscriptionMixCategoryIngredient> ingredients16oz = new List<UserSubscriptionMixCategoryIngredient>
            {
                cachewsIngredient,
                walnutsIngredient,
                peanutsIngredient,
                bananaIngredient,
                sesameIngredient
            };

            foreach (UserSubscriptionMixCategoryIngredient ing in ingredients16oz)
            {
                dbContext.UserSubscriptionMixCategoryIngredient.Add(ing);
                dbContext.SaveChanges();
            }

            #endregion

            #region 8oz CustomSack
            UserSubscriptionProduct subscriptionProduct2 = new UserSubscriptionProduct
            {
                Id = Guid.NewGuid().ToString(),
                CustomProductId = customSack.Id,
                CustomSelectOptionId = customSack8oz.Id,
                UserSubscriptionId = userSubscription.Id
            };

            dbContext.UserSubscriptionProducts.Add(subscriptionProduct2);
            dbContext.SaveChanges();

            UserSubscriptionMixCategory subscriptionNutsMixCategory2 = new UserSubscriptionMixCategory
            {
                Id = Guid.NewGuid().ToString(),
                MixCategoryId = nuts.Id,
                UserSubscriptionProductId = subscriptionProduct2.Id,
            };

            UserSubscriptionMixCategory subscriptionFuitsMixCategory2 = new UserSubscriptionMixCategory
            {
                Id = Guid.NewGuid().ToString(),
                MixCategoryId = fruits.Id,
                UserSubscriptionProductId = subscriptionProduct2.Id,
            };

            UserSubscriptionMixCategory subscriptionSeedsMixCategory2 = new UserSubscriptionMixCategory
            {
                Id = Guid.NewGuid().ToString(),
                MixCategoryId = seeds.Id,
                UserSubscriptionProductId = subscriptionProduct2.Id,
            };

            List<UserSubscriptionMixCategory> mixCategories8 = new List<UserSubscriptionMixCategory>
            {
                subscriptionNutsMixCategory2,
                subscriptionFuitsMixCategory2,
                subscriptionSeedsMixCategory2
            };

            foreach (UserSubscriptionMixCategory mixCategory in mixCategories8)
            {
                dbContext.UserSubscriptionMixCategories.Add(mixCategory);
                dbContext.SaveChanges();
            }

            UserSubscriptionMixCategoryIngredient cachewsIngredient2 = new UserSubscriptionMixCategoryIngredient
            {
                Id = Guid.NewGuid().ToString(),
                IngredientId = cachews.Id,
                Weight = 2,
                UserSubscriptionMixCategoryId = subscriptionNutsMixCategory2.Id
            };

            UserSubscriptionMixCategoryIngredient walnutsIngredient2 = new UserSubscriptionMixCategoryIngredient
            {
                Id = Guid.NewGuid().ToString(),
                IngredientId = walnuts.Id,
                Weight = 2,
                UserSubscriptionMixCategoryId = subscriptionNutsMixCategory2.Id
            };

            UserSubscriptionMixCategoryIngredient peanutsIngredient2 = new UserSubscriptionMixCategoryIngredient
            {
                Id = Guid.NewGuid().ToString(),
                IngredientId = peanuts.Id,
                Weight = 4,
                UserSubscriptionMixCategoryId = subscriptionNutsMixCategory2.Id
            };

            UserSubscriptionMixCategoryIngredient bananaIngredient2 = new UserSubscriptionMixCategoryIngredient
            {
                Id = Guid.NewGuid().ToString(),
                IngredientId = bananas.Id,
                Weight = 2,
                UserSubscriptionMixCategoryId = subscriptionFuitsMixCategory2.Id
            };

            UserSubscriptionMixCategoryIngredient sesameIngredient2 = new UserSubscriptionMixCategoryIngredient
            {
                Id = Guid.NewGuid().ToString(),
                IngredientId = sesame.Id,
                Weight = 6,
                UserSubscriptionMixCategoryId = subscriptionSeedsMixCategory2.Id
            };

            List<UserSubscriptionMixCategoryIngredient> ingredients8oz = new List<UserSubscriptionMixCategoryIngredient>
            {
                cachewsIngredient2,
                walnutsIngredient2,
                peanutsIngredient2,
                bananaIngredient2,
                sesameIngredient2
            };

            foreach (UserSubscriptionMixCategoryIngredient ing in ingredients8oz)
            {
                dbContext.UserSubscriptionMixCategoryIngredient.Add(ing);
                dbContext.SaveChanges();
            }

            #endregion

        }
        
    }
}

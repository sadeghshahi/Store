using Store.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace Store.Services.DAL
{
    public class StoreDbInitializer : DropCreateDatabaseIfModelChanges<StoreDbContext>
    {
        protected override void Seed(StoreDbContext context)
        {
            // Category
            var categories = new List<Category>();
            for (int i = 0; i < 10; i++)
                categories.Add(new Category() {Name = "Category " + i});
            context.Categories.AddRange(categories);

            // Country
            var countries = new List<Country>();
            for (int i = 0; i < 10; i++)
                countries.Add(new Country() {Name = "Country " + i});
            context.Countries.AddRange(countries);

            // Company
            var companies = new List<Company>();
            for (int i = 0; i < 10; i++)
                companies.Add(new Company()
                {
                    EnglishName = "Company " + i,
                    PersianName = "کمپانی " + i,
                    Country = countries[i]
                });
            context.Companies.AddRange(companies);

            // Product
            var products = new List<Product>();
            for (int i = 0; i < 10; i++)
                products.Add(new Product()
                {
                    ModelName = "m 1",
                    Description = "des 1",
                    Brand = companies[i],
                    Category = categories[i]
                });
            context.Products.AddRange(products);

            base.Seed(context);
        }
    }
}
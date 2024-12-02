using Microsoft.EntityFrameworkCore;

namespace webapiASP.Models
{
    public static class SeedData
    {
        public static void SeedDatabase(DataContext context)
        {
            context.Database.Migrate();

            var prices = new[]
            {
                new Prices { ProductCode = 123, ProductPrice = 5, ProductName = "товар1" },
                new Prices { ProductCode = 124, ProductPrice = 4, ProductName = "товар1" },
                new Prices { ProductCode = 125, ProductPrice = 3, ProductName = "товар1" },
                new Prices { ProductCode = 126, ProductPrice = 6, ProductName = "товар1" },
                new Prices { ProductCode = 127, ProductPrice = 7, ProductName = "товар1" },
                new Prices { ProductCode = 281, ProductPrice = 8, ProductName = "товар1" },
                new Prices { ProductCode = 129, ProductPrice = 9, ProductName = "товар1" }
            };
            if (!context.Prices.Any())
            {
                context.Prices.AddRange(prices);
            }

            context.SaveChanges();
            var registrationProducts = new[]
            {
                new RegistrationProduct
                {
                    CreatedDate = new DateTime(2024, 12, 1), BuilderLastname = "Скворцов", ProductCode = 123,
                    ProductName = "товар7", Quantity = 5, Price = 500, Prices = prices[0]
                },
                new RegistrationProduct
                {
                    CreatedDate = new DateTime(2024, 12, 1), BuilderLastname = "Скворцов", ProductCode = 234,
                    ProductName = "товар1", Quantity = 5, Price = 500, Prices = prices[3]
                },
                new RegistrationProduct
                {
                    CreatedDate = new DateTime(2024, 12, 1), BuilderLastname = "Скворцов", ProductCode = 789,
                    ProductName = "товар2", Quantity = 5, Price = 500, Prices = prices[6]
                },
                new RegistrationProduct
                {
                    CreatedDate = new DateTime(2024, 12, 1), BuilderLastname = "Гнездилов", ProductCode = 678,
                    ProductName = "товар5", Quantity = 5, Price = 500, Prices = prices[5]
                },
                new RegistrationProduct
                {
                    CreatedDate = new DateTime(2024, 12, 1), BuilderLastname = "Гнездилов", ProductCode = 678,
                    ProductName = "товар3", Quantity = 5, Price = 500, Prices = prices[4]
                },
                new RegistrationProduct
                {
                    CreatedDate = new DateTime(2024, 12, 1), BuilderLastname = "Гнездилов", ProductCode = 789,
                    ProductName = "товар4", Quantity = 5, Price = 500, Prices = prices[3]
                },
                new RegistrationProduct
                {
                    CreatedDate = new DateTime(2024, 12, 1), BuilderLastname = "Горохов", ProductCode = 234,
                    ProductName = "товар6", Quantity = 5, Price = 500, Prices = prices[1]
                },
                new RegistrationProduct
                {
                    CreatedDate = new DateTime(2024, 12, 1), BuilderLastname = "Горохов", ProductCode = 123,
                    ProductName = "товар1", Quantity = 5, Price = 500, Prices = prices[6]
                },
                new RegistrationProduct
                {
                    CreatedDate = new DateTime(2024, 12, 1), BuilderLastname = "Горохов", ProductCode = 456,
                    ProductName = "товар2", Quantity = 5, Price = 500, Prices = prices[5]
                },
                new RegistrationProduct
                {
                    CreatedDate = new DateTime(2024, 12, 1), BuilderLastname = "Пупкин", ProductCode = 345,
                    ProductName = "товар3", Quantity = 5, Price = 500, Prices = prices[2]
                },
                new RegistrationProduct
                {
                    CreatedDate = new DateTime(2024, 12, 1), BuilderLastname = "Пупкин", ProductCode = 123,
                    ProductName = "товар4", Quantity = 5, Price = 500, Prices = prices[3]
                },
                new RegistrationProduct
                {
                    CreatedDate = new DateTime(2024, 12, 1), BuilderLastname = "Пупкин", ProductCode = 567,
                    ProductName = "товар5", Quantity = 5, Price = 500, Prices = prices[1]
                },
                new RegistrationProduct
                {
                    CreatedDate = new DateTime(2024, 12, 1), BuilderLastname = "Соколов", ProductCode = 123,
                    ProductName = "товар6", Quantity = 5, Price = 500, Prices = prices[4]
                },
                new RegistrationProduct
                {
                    CreatedDate = new DateTime(2024, 12, 1), BuilderLastname = "Соколов", ProductCode = 234,
                    ProductName = "товар7", Quantity = 5, Price = 500, Prices = prices[2]
                },
                new RegistrationProduct
                {
                    CreatedDate = new DateTime(2024, 12, 1), BuilderLastname = "Соколов", ProductCode = 345,
                    ProductName = "товар8", Quantity = 7, Price = 700, Prices = prices[0]
                },
                new RegistrationProduct
                {
                    CreatedDate = new DateTime(2024, 12, 1), BuilderLastname = "Иванов", ProductCode = 456,
                    ProductName = "товар7", Quantity = 6, Price = 600, Prices = prices[4]
                }
            };

            if (!context.RegistrationProduct.Any())
            {
                context.RegistrationProduct.AddRange(registrationProducts);
            }

            context.SaveChanges();
        }
    }
}
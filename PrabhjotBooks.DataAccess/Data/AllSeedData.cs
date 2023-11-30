using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PrabhjotBooks.Models;
using PrabhjotBookStore.DataAccess.Data;

namespace PrabhjotBooks.DataAccess.Data
{
    public static class AllSeedData
    {
        public static async Task InitializeAsync(ApplicationDbContext context)
        {
            try
            {
                await SeedCategoriesAsync(context);
                await SeedCoverTypesAsync(context);
                await SeedProductsAsync(context);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred during data seeding: {ex.Message}");
                LogInnerExceptionDetails(ex.InnerException);
                // Optionally, rethrow the exception for further analysis
                throw;
            }
        }

        private static async Task SeedCategoriesAsync(ApplicationDbContext context)
        {
            if (!context.Categories.Any())
            {
                var categories = new List<Category>
                {
                    new Category { Name = "Fiction" },
                    new Category { Name = "Science Fiction" },
                    new Category { Name = "Mystery" },
                    new Category { Name = "Romance" },
                    new Category { Name = "Fantasy" }
                };

                await context.Categories.AddRangeAsync(categories);
                await context.SaveChangesAsync();
            }
        }

        private static async Task SeedCoverTypesAsync(ApplicationDbContext context)
        {
            if (!context.CoverTypes.Any())
            {
                var coverTypes = new List<CoverType>
                {
                    new CoverType { Name = "Hardcover" },
                    new CoverType { Name = "Paperback" },
                    new CoverType { Name = "E-book" },
                    new CoverType { Name = "Hardcover with dust jacket" },
                    new CoverType { Name = "Hardcover with ImageWrap" }
                };

                await context.CoverTypes.AddRangeAsync(coverTypes);
                await context.SaveChangesAsync();
            }
        }

        private static async Task SeedProductsAsync(ApplicationDbContext context)
        {
            try
            {
                if (!context.Products.Any())
                {
                    var products = new List<Product>
                    {
                        new Product
                        {
                            Title = "The Mandalorian",
                            Description =  "Epic tales from the galaxy, featuring the adventures of The Mandalorian.",
                            ISBN = "5974566874",
                            Author = "Din Djarin",
                            ListPrice = 19.99,
                            Price = 15.99,
                            ImageUrl = "/images/products/mandalorian.jpg",
                            CategoryId = 2,
                            CoverTypeId = 2
                        },
                        new Product
                        {
                            Title = "The Witcher's Saga",
                            Description = "A gripping fantasy series following the monster hunter, Geralt of Rivia, in his quest for destiny.",
                            ISBN = "5794359745",
                            Author = "Andrzej Sapkowski",
                            ListPrice = 24.99,
                            Price = 19.99,
                            ImageUrl = "/images/products/Bluw Smurai.jpg",
                            CategoryId = 3,
                            CoverTypeId = 3
                        },
                        new Product
                        {
                            Title = "The Blue Samurai",
                            Description = "An action-packed journey through ancient Japan, featuring the legendary Blue Samurai and his noble quest.",
                            ISBN = "5684324957",
                            Author = "Hikaru Takashi",
                            ListPrice = 29.99,
                            Price = 24.99,
                            ImageUrl = "/images/products/The witicher.jpg",
                            CategoryId = 4,
                            CoverTypeId = 4
                        },

                    };

                    await context.Products.AddRangeAsync(products);
                    await context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred during product seeding: {ex.Message}");
                LogInnerExceptionDetails(ex.InnerException);
                // Optionally, rethrow the exception for further analysis
                throw;
            }
        }

        private static void LogInnerExceptionDetails(Exception innerException)
        {
            while (innerException != null)
            {
                Console.WriteLine($"Inner Exception: {innerException.Message}");
                innerException = innerException.InnerException;
            }
        }
    }
}

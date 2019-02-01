using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDBContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDBContext>();


            context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Kayak",
                        Description = "A boat for one person",
                        Price = 275M,
                        Category = "Soccor"
                    },
                    new Product
                    {
                        Name = "Life Jacket",
                        Description = "Protective and Fashionable",
                        Price = 48.9M,
                        Category = "Soccor"
                    },
                    new Product
                    {
                        Name = "Soccer Ball",
                        Description = "FIFA-Approved size and weight",
                        Price = 19.50M,
                        Category = "Soccor"
                    },
                    new Product
                    {
                        Name = "Corner Flags",
                        Description = "Give your playing field a professional touch",
                        Price = 34.95M,
                        Category = "Soccor"
                    },
                    new Product
                    {
                        Name = "New york Stadium",
                        Description = "A flat-packed 50,000 seat staduim",
                        Price = 79500,
                        Category = "Soccor"
                    },
                    new Product
                    {
                        Name = "Thinking Cap",
                        Description = "Improves brain efficiency by 75%",
                        Price = 16,
                        Category = "Chess"
                    },
                    new Product
                    {
                        Name = "Unsteady Chair",
                        Description = "The way it rocks, it throws off your opponents. Roll with it",
                        Price = 29.95M,
                        Category ="Chess"
                    },
                    new Product
                    {
                        Name = "Human Chess boards",
                        Description = "A family fun Game ( Humans and family not included.)",
                        Price = 75,
                        Category = "Chess"
                    },
                    new Product
                    {
                        Name = "The Bling-bling King",
                        Description = "Gold plated, Diamond-studded King Win or lose In style",
                        Price = 1200,
                        Category = "Chess"

                    },
                    new Product
                    {
                        Name = "Test test test",
                        Description = "This is a god damn test ",
                        Price = 999999,
                        Category = " This shit doesn't work"
                    }
                    );context.SaveChanges();
               
            }
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RaviEraser.Data;
using System;
using System.Linq;

namespace RaviEraser.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any movies.
                if (context.Eraser.Any())
                {
                    return;   // DB has been seeded
                }

                context.Eraser.AddRange(
                    new Eraser
                    {
                        Title = "Natraj",
                        Color = "Red",
                        Type = "Round",
                        Price = 7.99M,
                        Rating = 2.5M
                    },

                    new Eraser
                    {
                        Title = "Apsara ",
                        Color = "Red",
                        Type = "Squre",
                        Price = 8.99M,
                        Rating = 2.5M
                    },

                    new Eraser
                    {
                        Title = "Colourful",
                        Color = "Red",
                        Type = "Squre",
                        Price = 9.99M,
                        Rating = 2.5M
                    },

                    new Eraser
                    {
                        Title = "Apsara",
                        Color = "Red",
                        Type = "Round",
                        Price = 3.99M,
                        Rating = 2.5M
                    },

                     new Eraser
                     {
                         Title = "Rio Bravo",
                         Color = "Red",
                         Type = "Round",
                         Price = 3.99M,
                         Rating = 2.5M
                     },

                      new Eraser
                      {
                          Title = "Colourful",
                          Color = "Red",
                          Type = "Round",
                          Price = 3.99M,
                          Rating = 2.5M
                      },

                       new Eraser
                       {
                           Title = "Apsara",
                           Color = "Red",
                           Type = "Round",
                           Price = 3.99M,
                           Rating = 2.5M
                       },
                        
                       new Eraser
                        {
                            Title = "Rio Bravo",
                            Color = "Red",
                            Type = "Round",
                            Price = 3.99M,
                           Rating = 2.5M
                       },

                        new Eraser
                        {
                            Title = "Natraj",
                            Color = "Red",
                            Type = "Round",
                            Price = 3.99M,
                            Rating = 2.5M
                        }
                ) ;
                context.SaveChanges();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcZipperPaper.Data;



namespace MvcZipperPaper.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcZipperPaperContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcZipperPaperContext>>()))
            {
                // Look for any movies.
                if (context.Zipper.Any())
                {
                    return;   // DB has been seeded
                }

                context.Zipper.AddRange(
                    new Zipper
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Type = "Romantic Comedy",
                        Price = 7.99M,
                        Rating = "R"
                    },

                    new Zipper
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Type = "Comedy",
                        Price = 8.99M,
                        Rating = "R"
                    },

                    new Zipper
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Type = "Comedy",
                        Price = 9.99M,
                        Rating = "R"
                    },

                    new Zipper
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Type = "Western",
                        Price = 3.99M,
                        Rating = "R"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
    


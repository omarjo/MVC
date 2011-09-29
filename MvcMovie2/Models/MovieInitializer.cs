using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace MvcMovie2.Models
{
    public class MovieInitializer : DropCreateDatabaseIfModelChanges<MovieDBContext>
    {
       protected override void Seed(MovieDBContext context)
        {
            var movies = new List<Movie>
            {
                new Movie {
                    Title = "Scary movie",
                    ReleaseDate = DateTime.Parse("2005-12-12"),
                    Genre = "comedy",
                    Rating = "R",
                    Price = 6500},

                    new Movie {
                        Title = "El Aro",
                        ReleaseDate = DateTime.Parse("2012-10-10"),
                        Genre = "Miedo",
                        Rating = "R",
                        Price = 4545},

                        new Movie {
                        Title = "death race",
                        ReleaseDate = DateTime.Parse("2006-09-09"),
                        Genre = "action",
                        Rating = "R",
                        Price = 5656},

                        new Movie {
                        Title = "taken",
                        ReleaseDate = DateTime.Parse("2007-08-08"),
                        Genre = "fiction",
                        Rating = "R",
                        Price = 7878}
                    };
                        
                    movies.ForEach(d => context.Movies.Add(d));
                }
            }

        }
    

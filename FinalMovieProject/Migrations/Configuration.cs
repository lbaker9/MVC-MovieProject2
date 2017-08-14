namespace FinalMovieProject.Migrations
{
    using FinalMovieProject.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FinalMovieProject.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FinalMovieProject.Models.MovieDBContext context)
        {
                context.Movies.AddOrUpdate(i => i.Title,
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = "1989-1-11",
                    Genre = "Romantic Comedy",
                    Rating = "PG",
                    Price = 7.99M
                },

                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = "1984-3-13",
                    Genre = "Comedy",
                    Rating = "G",
                    Price = 8.99M
                },

                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = "1986-2-23",
                    Genre = "Comedy",
                    Rating = "G",
                    Price = 9.99M
                },

                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = "1959-4-15",
                    Genre = "Western",
                    Rating = "G",
                    Price = 3.99M
                }
            );
        }
    }
}

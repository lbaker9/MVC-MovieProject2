namespace FinalMovieProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Data.Entity.Spatial;

    public partial class Movie
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string ReleaseDate { get; set; }

        public string Genre { get; set; }

        public decimal Price { get; set; }

        public string Rating { get; set; }
    }

    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

    }

}

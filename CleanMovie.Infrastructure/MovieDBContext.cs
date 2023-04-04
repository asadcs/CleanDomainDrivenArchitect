using CleanMovie.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanMovie.Infrastructure
{
    public class MovieDBContext : DbContext
    {
        public MovieDBContext(DbContextOptions<MovieDBContext> options) : base(options)
        {

        }
        public DbSet<Movie> Movies { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)// Crée la migration
        //{
        //    modelBuilder.Entity<Movie>().Property(p => p.Cost).HasColumnType("decimal(18,4)");

        //}

    }
}

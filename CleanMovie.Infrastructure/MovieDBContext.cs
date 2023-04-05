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
        public DbSet<Rental> Rentals { get; set; }

        public DbSet<Member> Members { get; set; }
        public DbSet<MovieRental> MovieRentals { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //One to Many for Members and Rentals
            modelBuilder.Entity<Member>()
                .HasOne<Rental>(r => r.Rental)
                .WithMany(m => m.Members)
                .HasForeignKey(r => r.RentalId);

            //Many to Many Rental and Movie
            modelBuilder.Entity<MovieRental>()
                .HasKey(mr => new { mr.RentalId, mr.MovieId });

            //Handle Decimals to avoid precision loss
            modelBuilder.Entity<Rental>()
                .Property(r => r.TotalCost)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Movie>()
                .Property(m => m.RentalCost)
                .HasColumnType("decimal(18,2)");


        }


    }
}

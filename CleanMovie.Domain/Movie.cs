using System;
using System.Collections.Generic;
using System.Text;

namespace CleanMovie.Domain
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; } = string.Empty;
        public decimal RentalCost { get; set; }
        public int RentalDuration { get; set; }

        //For MovieRental Many to Many
        public IList<MovieRental> Movierentals { get; set; }
    }
}

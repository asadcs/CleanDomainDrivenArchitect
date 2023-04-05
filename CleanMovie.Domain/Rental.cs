using System;
using System.Collections.Generic;

namespace CleanMovie.Domain
{
    public class Rental
    {
        public int RentalId { get; set; }
        public DateTime RentalDate { get; set; }

        public DateTime RentalExpiry { get; set; }

        public decimal TotalCost { get; set; }

        //For Member One to Many 
        public ICollection<Member> Members { get; set; }

        //For MovieRental Many to Many
        public IList<MovieRental> MovieRentals { get; set; }
    }
}
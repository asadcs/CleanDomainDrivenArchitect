﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CleanMovie.Domain
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Cost { get; set; }
    }
}
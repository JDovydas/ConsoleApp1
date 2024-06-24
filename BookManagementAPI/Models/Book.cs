using System;
using System.Collections;
using System.Collections.Generic;

namespace BookManagementAPI.Models
{
    public class Book : CommonPropertiesDto
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateOnly Publication { get; set; }
        public Genre Genre { get; set; }
        //public virtual ICollection<Review> Reviews { get; set; } = null;
        //public double? AverageRating { get; set; } // Calculated average rating of all reviews
    }
}

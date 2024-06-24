using BookManagementAPI.Models;
using System;
using System.Collections.Generic;

namespace BookManagementAPI.DTOs;

public class BookDto
{
    public string Title { get; set; }
    public string Author { get; set; }
    public DateOnly Publication { get; set; }
    public GenreDto Genre { get; set; }
    public virtual ICollection<ReviewDto> Reviews { get; set; } = new List<ReviewDto>();
    //public double? AverageRating { get; set; }
}
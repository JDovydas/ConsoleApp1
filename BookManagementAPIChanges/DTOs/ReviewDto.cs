using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using BookManagementAPI.Models;
namespace BookManagementAPI.DTOs

{
    public class ReviewDto
    {
        public string Text { get; set; }
        public int Rating { get; set; }
        [ForeignKey("User")]
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
    }
}

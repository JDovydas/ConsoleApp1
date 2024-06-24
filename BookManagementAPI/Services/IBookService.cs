using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookManagementAPI.DTOs;
using BookManagementAPI.Models;

namespace BookManagementAPI.Services;

public interface IBookService
{
    Task<IEnumerable<Book>> GetAllBooks();
    Task<IEnumerable<Book>> GetBooksByTitle(string title);
    Task<Book> GetBookById(Guid id);
    //Task<Book> AddBook(string title, string author, DateOnly publication, GenreDto genre, ReviewDto reviews);
    Task<Book> UpdateBook(Book currentBook);
    Task<Book> RemoveBookById(Guid id);
    Task<Book> AddReview(Guid bookId, ReviewDto review);
    //Task AddBook(string title, string author, DateOnly publication, GenreDto genre, ICollection<ReviewDto> reviews);
    //ask<Book> UpdateReview(Guid bookId, ReviewDto review);

    Task<Book> AddBook(string title, string author, DateOnly publication, GenreDto genreDto, ICollection<ReviewDto> reviews);
    Task<Book> AddBook(string title, string author, DateOnly publication, GenreDto genreDto, ReviewDto reviewDto);
}
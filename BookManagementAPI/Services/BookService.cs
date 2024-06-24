//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using BookManagementAPI.DTOs;
//using BookManagementAPI.Models;
//using BookManagementAPI.Services.Repositories;
//using Serilog;

//namespace BookManagementAPI.Services;

//public class BookService(IBookRepository repository) : IBookService
//{
//    public async Task<IEnumerable<Book>> GetAllBooks()
//    {
//        try
//        {
//            return await repository.GetAllBooks();
//        }
//        catch (Exception e)
//        {
//            Log.Error($"[{nameof(GetAllBooks)}]: {e.Message}");
//            throw;
//        }
//    }

//    public async Task<IEnumerable<Book>> GetBooksByTitle(string title)
//    {
//        try
//        {
//            return await repository.GetBooksByTitle(title);
//        }
//        catch (Exception e)
//        {
//            Log.Error($"[{nameof(GetBooksByTitle)}]: {e.Message}");
//            throw;
//        }
//    }

//    public async Task<Book> GetBookById(Guid id)
//    {
//        try
//        {
//            return await repository.GetBookById(id);
//        }
//        catch (Exception e)
//        {
//            Log.Error($"[{nameof(GetBookById)}]: {e.Message}");
//            throw;
//        }
//    }

//    public async Task<Book> AddBook(string title, string author, DateOnly publication, GenreDto genreDto, ReviewDto reviewDto)
//    {
//        try
//        {
//            var genre = await GetGenre(genreDto);
//            return await repository.AddBook(new Book
//            {
//                Id = Guid.NewGuid(),
//                Title = title,
//                Author = author,
//                Publication = publication,
//                Genre = genre,
//                Reviews = (ICollection<Review>)reviewDto,

//            });
//        }
//        catch (Exception e)
//        {
//            Log.Error($"[{nameof(AddBook)}]: {e.Message}");
//            throw;
//        }
//    }


//    public async Task<Book> AddBook(string title, string author, DateOnly publication, GenreDto genreDto, ICollection<ReviewDto> reviews)
//    {
//        try
//        {
//            var genre = await GetGenre(genreDto);
//            return await repository.AddBook(new Book
//            {
//                Id = Guid.NewGuid(),
//                Title = title,
//                Author = author,
//                Publication = publication,
//                Genre = genre,
//                Reviews = reviews.Select(r => new Review
//                {
//                    Text = r.Text,
//                    Rating = r.Rating,
//                    UserId = r.UserId
//                }).ToList()
//            });
//        }
//        catch (Exception e)
//        {
//            Log.Error($"[{nameof(AddBook)}]: {e.Message}");
//            throw;
//        }
//    }



//    public async Task<Genre> GetGenre(GenreDto genre)
//    {
//        try
//        {
//            return await repository.GetGenre(genre);
//        }
//        catch (Exception e)
//        {
//            Log.Error($"[{nameof(GetGenre)}]: {e.Message}");
//            throw;
//        }
//    }

//    public async Task<Book> UpdateBook(Book currentBook)
//    {
//        try
//        {
//            return await repository.UpdateBook(currentBook);
//        }
//        catch (Exception e)
//        {
//            Log.Error($"[{nameof(UpdateBook)}]: {e.Message}");
//            throw;
//        }
//    }

//    public async Task<Book> RemoveBookById(Guid id)
//    {
//        try
//        {
//            return await repository.RemoveBookById(id);
//        }
//        catch (Exception e)
//        {
//            Log.Error($"[{nameof(RemoveBookById)}]: {e.Message}");
//            throw;
//        }
//    }

//    public async Task<Book> AddReview(Guid bookId, ReviewDto review)
//    {
//        try
//        {
//            var book = await repository.GetBookById(bookId);
//            if (book == null)
//            {
//                throw new Exception($"Book with id {bookId} not found.");
//            }

//            var newReview = new Review
//            {
//                Text = review.Text,
//                Rating = review.Rating,
//                UserId = review.UserId
//            };

//            book.Reviews.Add(newReview);
//            await repository.UpdateBook(book);

//            return book;
//        }
//        catch (Exception e)
//        {
//            Log.Error($"[{nameof(AddReview)}]: {e.Message}");
//            throw;
//        }
//    }


//    //public async Task<Book> UpdateReview(Guid bookId, ReviewDto review)
//    //{
//    //    try
//    //    {
//    //        var book = await repository.GetBookById(bookId);
//    //        if (book == null)
//    //        {
//    //            throw new Exception($"Book with id {bookId} not found.");
//    //        }

//    //        var existingReview = book.Reviews.FirstOrDefault(r => r.Id == review.Id);
//    //        if (existingReview == null)
//    //        {
//    //            throw new Exception($"Review with id {review.Id} not found for book {bookId}.");
//    //        }

//    //        existingReview.Text = review.Text;
//    //        existingReview.Rating = review.Rating;
//    //        existingReview.UserId = review.UserId;

//    //        await repository.UpdateBook(book);

//    //        return book;
//    //    }
//    //    catch (Exception e)
//    //    {
//    //        Log.Error($"[{nameof(UpdateReview)}]: {e.Message}");
//    //        throw;
//    //    }
//    //}



//}
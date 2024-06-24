//using System;
//using System.Collections.Generic;
//using System.Threading.Tasks;
//using BookManagementAPI.DTOs;
//using BookManagementAPI.Models;
//using BookManagementAPI.Services.Repositories;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;
//using Serilog;

//namespace BookManagementAPI.Services;

////public class ReviewService(IReviewRepository repository) : IReviewService

//public class ReviewService : IReviewService
//{
//    private readonly IReviewRepository _reviewRepository;
//    private readonly IBookRepository _bookRepository;

//    public ReviewService(IReviewRepository reviewRepository, IBookRepository bookRepository)
//    {
//        _reviewRepository = reviewRepository;
//        _bookRepository = bookRepository;
//    }




//    public async Task<IEnumerable<Review>> GetAllReviews()
//    {
//        try
//        {
//            return await _reviewRepository.GetAllReviews();
//        }
//        catch (Exception e)
//        {
//            Log.Error($"[{nameof(GetAllReviews)}]: {e.Message}");
//            throw;
//        }
//    }

//    //[HttpGet("GetReviewsByBookId")]
//    //[AllowAnonymous]
//    //public async Task<ActionResult<IEnumerable<Review>>> GetReviewsByBookId(Guid bookId)
//    //{
//    //    var result = await _reviewRepository.GetReviewsByBookId(bookId);
//    //    if (!result.Any())
//    //        return BadRequest("There are no reviews for this book!");
//    //    return Ok(result);
//    //}
//    public async Task<IEnumerable<Review>> GetReviewsByBookTitle(string title)
//    {
//        try
//        {
//            var book = await _bookRepository.GetBooksByTitle(title);

//            if (book == null)
//                return new List<Review>();

//            var reviews = await _reviewRepository.GetReviewsByBookId(book.Id);

//            return reviews;
//        }
//        catch (Exception e)
//        {
//            Log.Error($"[{nameof(GetReviewsByBookTitle)}]: {e.Message}");
//            throw;
//        }
//    }

//    public async Task<Review> GetReviewById(Guid id)
//    {
//        try
//        {
//            return await repository.GetReviewById(id);
//        }
//        catch (Exception e)
//        {
//            Log.Error($"[{nameof(GetReviewById)}]: {e.Message}");
//            throw;
//        }
//    }

//    public async Task<Review> AddReview(string text, int rating, Guid bookId, string userName)
//    {
//        try
//        {
//            var review = new Review
//            {
//                Text = text,
//                Rating = rating,
//                CreatedByUserId = repository.GetUserId(userName)
//            };

//            return await repository.AddReview(review);
//        }
//        catch (Exception e)
//        {
//            Log.Error($"[{nameof(AddReview)}]: {e.Message}");
//            throw;
//        }
//    }

//    public async Task<Review> UpdateReview(Review currentReview, string userName, string userNameRole)
//    {
//        if (currentReview == null)
//        {
//            return null;
//        }

//        // Check if the user is authorized to update the review
//        if (repository.GetUserId(userName) != currentReview.CreatedByUserId && userNameRole != "Admin")
//        {
//            return null;
//        }

//        try
//        {
//            return await repository.UpdateReview(currentReview);
//        }
//        catch (Exception e)
//        {
//            Log.Error($"[{nameof(UpdateReview)}]: {e.Message}");
//            throw;
//        }
//    }

//    public async Task<Review> RemoveReviewById(Guid id)
//    {
//        try
//        {
//            return await repository.RemoveReviewById(id);
//        }
//        catch (Exception e)
//        {
//            Log.Error($"[{nameof(RemoveReviewById)}]: {e.Message}");
//            throw;
//        }
//    }

//}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using BookManagementAPI.DTOs;
//using BookManagementAPI.Models;
//using Microsoft.EntityFrameworkCore;
//using Serilog;

//namespace BookManagementAPI.Services.Repositories;

//public class ReviewRepository(ApplicationDbContext context) : IReviewRepository
//{
//    public async Task<IEnumerable<Review>> GetAllReviews()
//    {
//        try
//        {
//            return await context.Reviews.ToListAsync();
//        }
//        catch (Exception e)
//        {
//            Log.Error($"[{nameof(GetAllReviews)}]: {e.Message}");
//            throw;
//        }
//    }

//    public async Task<IEnumerable<Review>> GetReviewsByBookId(Guid bookId)
//    {
//        try
//        {
//            return await context.Books.Where(b => b.Id == bookId).ToListAsync();
//        }
//        catch (Exception e)
//        {
//            Log.Error($"[{nameof(GetReviewsByBookId)}]: {e.Message}");
//            throw;
//        }
//    }

//    public async Task<Review> AddReview(Review review)
//    {
//        try
//        {
//            context.Reviews.Add(review);
//            await context.SaveChangesAsync();
//            return review;
//        }
//        catch (Exception e)
//        {
//            Log.Error($"[{nameof(AddReview)}]: {e.Message}");
//            throw;
//        }
//    }


//    public async Task<Review> UpdateReview(Review currentReview)
//    {
//        try
//        {
//            context.Update(currentReview);
//            await context.SaveChangesAsync();
//            return currentReview;
//        }
//        catch (Exception e)
//        {
//            Log.Error($"[{nameof(UpdateReview)}]: {e.Message}");
//            throw;
//        }
//    }

//    public async Task<Review> RemoveReviewById(Guid id)
//    {
//        var review = await context.Reviews.FindAsync(id);
//        if (review == null)
//        {
//            Log.Error($"[{nameof(RemoveReviewById)}]: Review not found!");
//            return null;
//        }

//        try
//        {
//            context.Reviews.Remove(review);
//            await context.SaveChangesAsync();
//            return review;
//        }
//        catch (Exception e)
//        {
//            Log.Error($"[{nameof(RemoveReviewById)}]: {e.Message}");
//            throw;
//        }
//    }


//    public Guid GetUserId(string username)
//    {
//        return context.Users.SingleOrDefault(x => x.Username == username).Id;
//    }
//}
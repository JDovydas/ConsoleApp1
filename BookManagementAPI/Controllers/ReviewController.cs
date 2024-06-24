using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BookManagementAPI.DTOs;
using BookManagementAPI.Models;
using BookManagementAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookManagementAPI.Controllers;

//[ApiController]
//[Route("[controller]")]
//public class ReviewController(IReviewService service) : ControllerBase
//{


//[HttpGet("GetAllReviews")]
//[AllowAnonymous]
//public async Task<ActionResult<IEnumerable<Review>>> GetAllReviews()
//{
//    var result = await service.GetAllReviews();
//    if (!result.Any())
//        return BadRequest("There are no reviews in the database!");
//    return Ok(result);
//}

//[HttpGet("GetReviewsByBookTitle")]
//[AllowAnonymous]
//public async Task<ActionResult<IEnumerable<Review>>> GetReviewsByBookTitle(string title)
//{
//    var result = await service.GetReviewsByBookTitle(title);
//    if (!result.Any())
//        return BadRequest("There are no reviews for this book title!");
//    return Ok(result);
//}

//[HttpGet("GetReviewById")]
//[AllowAnonymous]
//public async Task<ActionResult<Review>> GetReviewById(Guid id)
//{
//    var result = await service.GetReviewById(id);
//    if (result == null)
//        return BadRequest("Review not found!");
//    return Ok(result);
//}

////[HttpPost("AddReview")]
////[Authorize(Roles = "Admin, Regular")]
////public async Task<ActionResult<Review>> AddReview([FromBody] ReviewDto review)
////{
////    var userName = HttpContext.User.FindFirst(ClaimTypes.Name).Value;
////    var result = await service.AddReview(review.Text, review.Rating, review.BookId, userName);

////    if (result == null)
////        return BadRequest("Failed to add a review!");
////    return Ok(result);
////}

//[HttpPut("UpdateReview")]
//[Authorize(Roles = "Admin, Regular")]
//public async Task<ActionResult<Review>> UpdateReview([FromBody] Review currentReview)
//{
//    var userName = HttpContext.User.FindFirst(ClaimTypes.Name).Value;
//    var userNameRole = HttpContext.User.FindFirst(ClaimTypes.Role).Value;
//    var result = await service.UpdateReview(currentReview, userName, userNameRole);
//    if (result is null)
//        return BadRequest("Failed to update a book!");
//    return Ok(result);
//}

//[HttpDelete("RemoveReviewById")]
//[Authorize(Roles = "Admin, Regular")]
//public async Task<ActionResult<Review>> RemoveReviewById([FromQuery] Guid id)
//{
//    var result = await service.RemoveReviewById(id);

//    if (result == null)
//        return BadRequest("Failed to delete the review!");

//    return Ok(result);
//}
//}
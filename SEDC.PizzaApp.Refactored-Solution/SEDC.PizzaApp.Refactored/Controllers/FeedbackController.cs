using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Domain.Models;
using SEDC.PizzaApp.Refactored.Models;
using SEDC.PizzaApp.Services.Services;

namespace SEDC.PizzaApp.Refactored.Controllers
{
    public class FeedbackController : Controller
    {
        private IUserService _userService;

        public FeedbackController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View(new FeedbackAmountModel());
        }

        [HttpPost]
        public IActionResult Index(FeedbackAmountModel model)
        {
            return RedirectToAction("GetFeedback", "Feedback", new { feedbacks = model.NumberOfFeedbacks });

        }

        [HttpGet]
        public IActionResult GetFeedback(int feedbacks)
        {
            List<Feedback> allFeedbacks = _userService.GetFeedback(feedbacks);

            List<FeedbackViewModel> feedbackView = new List<FeedbackViewModel>();

            foreach (var feedback in allFeedbacks)
            {
                feedbackView.Add(new FeedbackViewModel()
                {
                    Id = feedback.Id,
                    Name = feedback.Name,
                    Message = feedback.Message
                });
            }

            FeedbacksViewModel feedbacksViewModel = new FeedbacksViewModel()
            {
                Feedbacks = feedbackView
            };

            return View(feedbacksViewModel);
        }

    }
}

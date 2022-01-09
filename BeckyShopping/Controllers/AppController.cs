using BeckyShopping.Data;
using BeckyShopping.Services;
using BeckyShopping.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BeckyShopping.Controllers
{
    public class AppController : Controller
    {
        private readonly IMailService _mailService;
        private readonly IShoppingRepository _repository;

        public AppController(IMailService mailService, IShoppingRepository repository)
        {
            _mailService = mailService;
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Send the email
                _mailService.SendMessage("beckyonlineshopping@gmail.com", model.Subject, $"From: {model.Name} - {model.Email}, Message: {model.Message}");
                ViewBag.UserMessage = "Mail Sent";
                ModelState.Clear();
            }
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "About Us";

            return View();
        }

        public IActionResult Shop()
        {
            var results = _repository.GetAllProducts();

            return View(results);
        }
    }
}

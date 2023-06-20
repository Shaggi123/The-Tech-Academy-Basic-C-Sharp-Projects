using System;
using System.Web.Mvc;
using CarInsurance.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarInsurance.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CalculateQuote(User user)
        {
            // Perform calculations based on user input to determine the quote amount
            // Store the quote in the database or any other desired action

            // Return the quote amount to the user
            ViewBag.QuoteAmount = CalculateInsuranceQuote(user);

            return View("QuoteResult");
        }

        public ActionResult Admin()
        {
            // Retrieve all issued quotes from the database or any other desired action
            var quotes = GetIssuedQuotes();

            return View(quotes);
        }

        // Helper method to calculate the insurance quote
        private decimal CalculateInsuranceQuote(User user)
        {
            // Implement your business logic to calculate the quote amount
            // Example: return a fixed quote amount for demonstration purposes
            return 1000;
        }

        // Helper method to retrieve issued quotes
        private IEnumerable<Quote> GetIssuedQuotes()
        {
            // Implement your logic to retrieve the quotes from the database or any other source
            // Example: return dummy quotes for demonstration purposes
            return new List<Quote>
            {
                new Quote { QuoteId = 1, Amount = 1000 },
                new Quote { QuoteId = 2, Amount = 1500 }
            };
        }
    }
}

using System.Collections.Generic;
using Aspnetcore.OrderingApp.Models;
using Microsoft.AspNetCore.Mvc;


namespace Aspnetcore.OrderingApp.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult NewClient()
        {
            var newClient = new Client();
            newClient.EmailPromos = new List<EmailPromo>()
            {
                new EmailPromo() {Id = 1, Title = "Weekly Deal", IsSubscribed = false},
                new EmailPromo() {Id = 2, Title = "Holiday Promos", IsSubscribed = false},
                new EmailPromo() {Id = 3, Title = "Company Newsletter", IsSubscribed = false},
                new EmailPromo() {Id = 4, Title = "New Products", IsSubscribed = false}
            };

            return View(newClient);
        }

        [HttpPost]
        public IActionResult NewClient(Client newClient)
        {
            if (ModelState.IsValid)
            {
                // Save updated data to Database

                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(newClient);
            }
        }

        public IActionResult VerifyEmail(string email)
        {
            var emailList = new List<string>()
            {
                "test@example.com",
                "hello@example.com",
                "world@example.com"
            };

            if (emailList.Contains(email))
            {
                return Json("Email is already taken");
            }

            return Json(true);
        }
    }
}
using System;
using System.Linq;
using System.Web.Mvc;
using DemoMVC.Models;
using DemoMVC.Data;

namespace DemoMVC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login        
        public ActionResult Index(UserViewModel userViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(userViewModel);
            }
            var isValid = ValidateUser(userViewModel.UserName, userViewModel.Password);
            if (isValid)
            {
                Session.Add("UserID", userViewModel.UserName);
                return RedirectToAction("Index", "Employees");
            }
            return View(userViewModel);
        }

        public ActionResult LogOut()
        {
            Session.Clear();
            return View("Index");
        }

        private bool ValidateUser(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return false;
            }

            using (DemoEntities dbContext = new DemoEntities())
            {
                var user = (from us in dbContext.Users
                            where string.Compare(username, us.Name, StringComparison.OrdinalIgnoreCase) == 0
                            && string.Compare(password, us.Password, StringComparison.OrdinalIgnoreCase) == 0
                            && us.IsActive == true
                            select us).FirstOrDefault();

                return (user != null) ? true : false;
            }
        }
    }
}
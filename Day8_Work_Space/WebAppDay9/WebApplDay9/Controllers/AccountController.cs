using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplDay9.DAO;
using WebApplDay9.Models;

namespace WebAppDay9.Controllers
{

    public class AccountController : Controller
    {

        private readonly IUserDAO userDAO;

        public AccountController(IUserDAO _userDAO)
        {
            userDAO = _userDAO;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            user.Role = "User";
            if (ModelState.IsValid)
            {
                userDAO.Register(user);
                TempData["Success"] = "Registration Successfull";
                return RedirectToAction("Login");
            }
            return View(user);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var user = userDAO.ValidateUser(username, password);

            if (user != null)
            {
                HttpContext.Session.SetString("UserName", user.Username);
                HttpContext.Session.SetString("UserRole", user.Role);

                Response.Cookies.Append("UserLogin", user.Username, 
                    new CookieOptions { Expires = DateTimeOffset.Now.AddDays(7) });


                return RedirectToAction("Dashboard");
            }

            ViewBag.Error = "Invalid Credential";
            return View();
        }

        [HttpGet]
        public IActionResult Dashboard()
        {
            var role = HttpContext.Session.GetString("UserRole");

            if (role == null)
            {
                return RedirectToAction("Login");
            }

            if (role == "Admin")
            {
                return RedirectToAction("AdminDashboard");
            }
            return RedirectToAction("UserDashboard");
        }

        [HttpGet]
        public IActionResult AdminDashboard()
        {
            return View();
        }
        [HttpGet]
        public IActionResult UserDashboard()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            Response.Cookies.Delete("UserLogin");
            return RedirectToAction("Login");
        }
    }
}

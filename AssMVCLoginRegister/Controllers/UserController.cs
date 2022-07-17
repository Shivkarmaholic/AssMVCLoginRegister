using Microsoft.AspNetCore.Mvc;

namespace AssMVCLoginRegister.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Register()
        {
          
            return View();
        }

        [HttpPost]
        public IActionResult Register(IFormCollection form)
        {
            ViewBag.Name=form["txtname"];
            ViewBag.Password = form["txtpassword"];
            ViewBag.Email=form["txtemail"];
            ViewBag.Dob = form["txtdob"];

            return View("Login");
        }
        public IActionResult Login()
        {

            return View();
        }

    }
}

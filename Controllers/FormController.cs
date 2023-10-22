using Microsoft.AspNetCore.Mvc;

namespace Team_Turtle.Controllers
{
    public class FormController : Controller
    // This will controll the login/sign up form and validate the form
    {
        public IActionResult SignUp()
        {
            return View();
        }

        /*
        [HttpPost]
        public IActionResult SignUp()
        {
            return View();
        }
        */

        public IActionResult Login()
        {
            return View();

        }
    }
}

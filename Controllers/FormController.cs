using Microsoft.AspNetCore.Mvc;

namespace Team_Turtle.Controllers
{
    public class FormController : Controller
    // This will controll the login/sign up form and validate the form
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

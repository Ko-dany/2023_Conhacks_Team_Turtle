using Microsoft.AspNetCore.Mvc;

namespace Team_Turtle.Controllers
{
    public class BoardController : Controller
    // This will control the CRUD of posts for the study group list
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

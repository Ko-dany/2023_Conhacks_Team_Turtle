using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Team_Turtle.Models;

namespace Team_Turtle.Controllers
{
    public class FormController : Controller
    // This will controll the login/sign up form and validate the form
    {
		public FormController(SWCDbContext swcDbContext)
		{
			_swcDbContext = swcDbContext;
		}

		[HttpGet]
		public IActionResult GetSignUpForm()
        {
			var viewModel = new SignUpViewModel
			{
				Student = new Student(),
				Programs = _swcDbContext.Programs.ToList()
			};

			return View("SignUp", viewModel);
		}


        [HttpPost]
        public IActionResult CreateNewAccount(Student student)
        {
			if (ModelState.IsValid)
			{
				// fields are valid so add msmt to the DB & save:
				_swcDbContext.Students.Add(student);
				_swcDbContext.SaveChanges();

				TempData["LastActionMessage"] = $"New account ({student.Email}) created successfully!";

				// Redirect back to the all msmts view:
				return RedirectToAction("Index", "Home");
			}
			else
			{
				// there was a validn err so return the HR msmt to the user
				// along with any possible validn err msgs:
				return View("SignUp", student);
			}
		}

		[HttpGet]
		public IActionResult GetLoginForm()
        {
            return View();

        }

		[HttpPost]
        public IActionResult Login()
        {
            return View();

        }

        private SWCDbContext _swcDbContext;
	}
}

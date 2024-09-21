using Microsoft.AspNetCore.Mvc;
using UserInputApp.Models;

namespace UserInputApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPut]
        public IActionResult ProcessInput(InputModel model)
        { 
            if (ModelState.IsValid)
            {
                model.InputResult = new string(model.InputValue.Reverse().ToArray());
                return View("Index", model);
            }
            return View("Index", model);
        }
    }
}

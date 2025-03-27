using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment2.Controllers
{
    public class ProjectsController : Controller
    {
        [HttpGet]

        public IActionResult Current()
        {
            return View();
        }
        [HttpGet]

        public IActionResult Complete()
        {
            return View();
        }
        [HttpGet]

        public IActionResult Favorite()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace IActionResultExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("/home")]
        public IActionResult Index()
        {
            return File("/", "application/pdf");
        }
        [Route("/about")]
        public IActionResult About()
        {
            return Content("About section", "text/plain");
        }
        [Route("/contact")]
        public IActionResult Contact()
        {
            return Content("Contact us", "text/plain");
        }

        [Route("/privacy")]
        public IActionResult Privacy()
        {
            return Content("Privacy Policy", "text/plain");

        [Route("/Career")]
        public IActionResult Jobs()
        {
            return Content("Carrer Opportunity", "text/plain");
        }
    }
}

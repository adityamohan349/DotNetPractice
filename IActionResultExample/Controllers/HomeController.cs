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
    }
}

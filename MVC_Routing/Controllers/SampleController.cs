using Microsoft.AspNetCore.Mvc;

namespace MVC_Routing.Controllers
{
    public class SampleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

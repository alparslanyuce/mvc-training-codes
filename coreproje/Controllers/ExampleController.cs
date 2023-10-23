using Microsoft.AspNetCore.Mvc;

namespace coreproje.Controllers
{
    public class ExampleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

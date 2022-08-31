using Microsoft.AspNetCore.Mvc;

namespace CoreCodeCamp.Controllers
{
    public class OperationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

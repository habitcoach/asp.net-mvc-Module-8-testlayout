using Microsoft.AspNetCore.Mvc;

namespace CssDownloadIndex.Controllers
{
    public class Test : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

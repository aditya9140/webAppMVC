using Microsoft.AspNetCore.Mvc;

namespace WebAppMVCTask.Views.Home
{
    public class MasterPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

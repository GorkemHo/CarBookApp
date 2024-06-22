using Microsoft.AspNetCore.Mvc;

namespace CarBookApp.WebUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace CarBookApp.WebUI.ViewComponents.UILayoutViewComponents
{
    public class _ScriptsUILayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

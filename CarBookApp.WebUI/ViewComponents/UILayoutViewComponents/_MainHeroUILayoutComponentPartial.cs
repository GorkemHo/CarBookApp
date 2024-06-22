using Microsoft.AspNetCore.Mvc;

namespace CarBookApp.WebUI.ViewComponents.UILayoutViewComponents
{
    public class _MainHeroUILayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }

}

using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.Areas.Admin.ViewComponenets.AdminLayoutViewComponents
{
    public class _AdminLayoutStyleComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
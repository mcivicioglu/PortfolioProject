using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.Areas.Admin.ViewComponenets.AdminLayoutViewComponents
{
    public class _AdminLayoutSidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
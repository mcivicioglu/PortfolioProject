using Microsoft.AspNetCore.Mvc;
using PortfolioProject.Context;

namespace PortfolioProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactController : Controller
    {
        private readonly PortfolioContext _context;

        public IActionResult ContactList()
        {
            var values = _context.Contacts.ToList();
            return View(values);
        }
    }
}
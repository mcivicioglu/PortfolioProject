using Microsoft.AspNetCore.Mvc;
using PortfolioProject.Context;
using PortfolioProject.Entities;

namespace PortfolioProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactController : Controller
    {
        private readonly PortfolioContext _context;

        public ContactController(PortfolioContext context)
        {
            _context = context;
        }

        public IActionResult ContactList()
        {
            var values = _context.Contacts.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateContact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateContact(Contact contact)
        {
            _context.Contacts.Add(contact);
            _context.SaveChanges();
            return RedirectToAction("CreateContact");
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Phonebook.Data.Models;
using Phonebook.Data;

namespace Phonebook.Controllers
{
    public class ContactController : Controller
    {
        [HttpPost]
        public IActionResult Create (Contact contact)
        {
            DataAccess.Contacts.Add(contact);

            return RedirectToAction("Index", "Home");
        }
    }
}
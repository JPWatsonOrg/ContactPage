using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using ContactPage.Models;

namespace ContactPage.Controllers
{
    public class ContactDetailsController : Controller
    {

        private ContactInfoContext _context;

        public ContactDetailsController(ContactInfoContext context)
        {
            _context = context;
        }


        /// <summary>
        /// Default action, not really used at the moment
        /// Stub code in case I want to add it as part of some unit test
        /// </summary>
        /// <returns></returns>
        public string Index()
        {
            return "This is my default action...";
        }

        /// <summary>
        /// Save action for posting a response action when called
        /// The Save action Saves the changes to the database
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save([Bind("Name,phoneNumber,emailAddress")] ContactInfo contact)
        {
            if (ModelState.IsValid)
            {
                contact.Id = 0;
                _context.ContactInfo.Add(contact);
                _context.SaveChanges();
                return RedirectToAction("Saved");
            }
            return View(contact);
        }

        public string Saved()
        {
            return "Thank You.  Now Your Contact Information Is Saved In A Database!";
        }

    }
}
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

        //
        // GET: /ContactDetails/

        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // GET: /ContactDetails/Welcome/ 

        //public string Welcome()
        //{
        //    return "This is the Welcome action method...";
        //}

        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }

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
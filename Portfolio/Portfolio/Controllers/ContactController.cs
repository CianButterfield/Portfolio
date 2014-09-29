using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/

        [HttpGet]
        public ActionResult Index()
        {
            return View(new Models.ContactInformation());
        }

        [HttpPost]
        public ActionResult Index(Models.ContactInformation contactForm)
        {
            Models.ContactInfoEntities db = new Models.ContactInfoEntities();
            db.ContactInformations.Add(contactForm);
            db.SaveChanges();
            return RedirectToAction("ThankYou", "Contact");
        }

        public ActionResult ThankYou()
        {
            return View();
        }

    }
}

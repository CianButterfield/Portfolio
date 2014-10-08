using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;

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

        //[HttpPost]
        //public ActionResult Index(Models.ContactInformation contactForm)
        //{
        //    Models.ContactInfoEntities db = new Models.ContactInfoEntities();
        //    db.ContactInformations.Add(contactForm);
        //    db.SaveChanges();
        //    return RedirectToAction("ThankYou", "Contact");
        //}


        //new contact form post to send me an email with the info
        [HttpPost]
        public ActionResult Index(Models.ContactInformation contactForm)
        {
            //sending an email
            //step 1.  add using system.net.mail
            //step 2. create a new message
            //step 3. subject 4. make the body 5. add the body
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine("You have a new contact request.");
            sb.AppendLine("Name: " + contactForm.FirstName + " " + contactForm.LastName);
            sb.AppendLine("Email: " + contactForm.Email);
            sb.AppendLine("Message: " + contactForm.Comment);
            sb.AppendLine("\n\nI love you,\nThe Robots");

            string body = sb.ToString();

            MailMessage message = new MailMessage("MyWebsite@mysite.com", "ciangregorybutterfield@gmail.com", "Contact Request " + contactForm.FirstName + " " + contactForm.LastName, body);
            //step 6. get client
            SmtpClient smtpClient = new SmtpClient("mail.dustinkraft.com", 587);
            smtpClient.Credentials = new System.Net.NetworkCredential("postmaster@dustinkraft.com", "techIsFun1");
            //step 7. send it
            smtpClient.Send(message);


            return PartialView("ThankYou");
        }
    }
}

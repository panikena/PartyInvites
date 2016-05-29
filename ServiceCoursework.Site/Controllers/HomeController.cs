using ServiceCoursework.Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace ServiceCoursework.Site.Controllers
{
    public class HomeController : Controller
    {

        GuestServiceReference.GuestServiceClient guestService = new GuestServiceReference.GuestServiceClient();
        MailServiceReference.MailServiceClient mailService = new MailServiceReference.MailServiceClient();

        // GET: Home
        public ViewResult Index()
        {
            return View();
        }


        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guest)
        {
            if (ModelState.IsValid)
            {
                // Нужно отправить данные нового гостя по электронной почте 
                // организатору вечеринки.

                guestService.AddGuest(guestService.CreateGuest(guest.Name, guest.Email, guest.Phone, guest.WillAttend, guest.Comment));
                mailService.SendMail(guest.Email, "Вечеринка", "Спасибо, что придете на вечеринку, " + guest.Name + ". ");
               
                return View("Thanks", guest);
            }
            else
                // Обнаружена ошибка проверки достоверности
                return View();
        }
    }
}

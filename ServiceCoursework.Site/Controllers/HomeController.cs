using ServiceCoursework.Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ServiceCoursework.Services;
using System.Xml;

namespace ServiceCoursework.Site.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            GuestService service = new GuestService();
            ViewBag.ServiceEcho = service.Echo();
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
                GuestService gs = new GuestService();
                gs.AddGuest(gs.CreateGuestXML(guest.Name, guest.Email, guest.Phone, guest.WillAttend, guest.Comment));
                return View("Thanks", guest);
            }
            else
                // Обнаружена ошибка проверки достоверности
                return View();
        }
    }
}

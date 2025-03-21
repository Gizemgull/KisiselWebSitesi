//using System;
//using System.Collections.Generic;
using System.Linq;
//using System.Runtime.Remoting.Contexts;
//using System.Web;
using System.Web.Mvc;
using KisiselWebSitesi.Models.Siniflar;
using System.Web.Security;



namespace KisiselWebSitesi.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Context c=new Context();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin ad)
        {
            var bilgiler = c.Admins.FirstOrDefault(x => x.kullaniciAdi == ad.kullaniciAdi && x.sifre == ad.sifre);
            if (bilgiler != null) 
            {
                FormsAuthentication.SetAuthCookie(bilgiler.kullaniciAdi, false);
                Session["kullaniciAdi"] =bilgiler.kullaniciAdi.ToString();
                return RedirectToAction("Index", "Admin");

            }
            else
            {
                return View();
            }
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToActionPermanent("Index","Login");
        }
    }
}
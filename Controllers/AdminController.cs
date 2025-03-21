using KisiselWebSitesi.Models.Siniflar;
using System.Linq;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
using System.Web.Mvc;

namespace KisiselWebSitesi.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c=new Context();
        [Authorize]
        public ActionResult Index()
        {
            var deger=c.AnaSayfas.ToList();
            return View(deger);
        }

        public ActionResult AnaSayfaGetir(int id)
        {
            var ag = c.AnaSayfas.Find(id); //ag->anasayfa getir
            return View("AnaSayfaGetir",ag);
        }

        public ActionResult AnaSayfaGuncelle(AnaSayfa x)  //x->parametre atamak için
        {
            var ag= c.AnaSayfas.Find(x.id);
            ag.isim = x.isim;
            ag.profil = x.profil;
            ag.unvan= x.unvan;
            ag.aciklama= x.aciklama;
            ag.iletisim= x.iletisim;
            c.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult ikonListesi()
        {
            var deger=c.ikonlars.ToList();
            return View(deger);
        }

        [HttpGet] //sayfa yüklendiğinde çalışsın
        public ActionResult YeniIkon() 
        {
            return View();
        }

        [HttpPost] //post işlemi
        public ActionResult YeniIkon(ikonlar p) //p->parametre
        {
            c.ikonlars.Add(p);
            c.SaveChanges();
            return RedirectToAction("ikonListesi");
        }

        public ActionResult ikonGetir(int id)
        {
            var ig = c.ikonlars.Find(id);
            return View("ikonGetir", ig);
        }

        public ActionResult ikonGuncelle(ikonlar x)
        {
            var ig=c.ikonlars.Find(x.id);
            ig.ikon = x.ikon;
            ig.link = x.link;
            c.SaveChanges();
            return RedirectToAction("ikonListesi");
        }

        public ActionResult ikonSil(int id)
        {
            var sl = c.ikonlars.Find(id);
            c.ikonlars.Remove(sl);
            c.SaveChanges();
            return RedirectToAction("ikonListesi");
        }
    }
}

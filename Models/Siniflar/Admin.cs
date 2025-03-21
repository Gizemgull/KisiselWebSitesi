//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

using System.ComponentModel.DataAnnotations;

namespace KisiselWebSitesi.Models.Siniflar
{
    public class Admin
    {
        [Key]
        public int id { get; set; }
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }
    }
}
﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

using System.ComponentModel.DataAnnotations;

namespace KisiselWebSitesi.Models.Siniflar
{
    public class AnaSayfa
    {
        [Key]
        public int id {  get; set; }
        public string isim{ get; set; }
        public string profil { get; set; }
        public string unvan { get; set; }
        public string aciklama { get; set; }
        public string iletisim { get; set; }
    }
}
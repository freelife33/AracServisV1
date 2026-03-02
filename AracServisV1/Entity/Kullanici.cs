using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracServisV1.Entity
{
    public class Kullanici
    {
        public int kullanici_id { get; set; }
        public string kullanici_adi { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string eposta { get; set; }
        public string telefon { get; set; }
        public string parola_hash { get; set; }
        public string rol { get; set; }
        public bool aktif_mi { get; set; }
        public DateTime olusturma_tarihi { get; set; } = DateTime.Now;
        public DateTime guncelleme_tarihi { get; set; }
        public string son_giris_ip { get; set; }
        public DateTime son_giris_tarihi { get; set; }
    }
}

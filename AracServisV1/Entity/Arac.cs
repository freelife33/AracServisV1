using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracServisV1.Entity
{
    public class Arac
    {
        public int arac_id { get; set; }
        public int kisi_id { get; set; }
        public String marka { get; set; }
        public String model { get; set; }
        public int model_yili { get; set; }
        public String motor_no { get; set; }
        public int km { get; set; }
        public String notlar { get; set; }
        public String plaka { get; set; }
        public String renk { get; set; }
        public String sasi_no { get; set; }
        public String vites_turu { get; set; }
        public String yakit_turu { get; set; }
        public bool aktif_mi { get; set; }
        public DateTime guncelleme_tarihi { get; set; }
        public DateTime olusturma_tarihi { get; set; }= DateTime.Now;

    }
}

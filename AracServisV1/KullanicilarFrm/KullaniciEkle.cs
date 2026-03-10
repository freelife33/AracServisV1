using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AracServisV1.DataAccess;
using AracServisV1.Entity;

namespace AracServisV1.KullanicilarFrm
{
    public partial class KullaniciEkle : Form
    {
        KullaniciDAL _kullaniciDal= new KullaniciDAL();
        public KullaniciEkle()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();

            kullanici.kullanici_adi=txtKullaniciAdi.Text;
            kullanici.ad=txtAd.Text;
            kullanici.soyad=txtSoyad.Text;
            kullanici.eposta=txtEposta.Text;
            kullanici.telefon=txtTelefon.Text;
            kullanici.parola_hash=txtParola.Text;
            kullanici.rol=cmbRol.SelectedText;


            _kullaniciDal.KullaniciEkle(kullanici);

            MessageBox.Show("Kullanıcı başarıyla eklendi.");
        }
    }
}

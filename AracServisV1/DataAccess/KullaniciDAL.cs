using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracServisV1.Helpers;
using MySql.Data.MySqlClient;

namespace AracServisV1.DataAccess
{
    public class KullaniciDAL
    {
        AracServisContext _context = new AracServisContext();

        public void KullaniciEkle(Entity.Kullanici kullanici)
        {

            string sorgu= "Insert Into kullacilar (kullanici_adi, ad, soyad, eposta, telefon, parola_hash, rol) " +
                "Values (@kullanici_adi, @ad, @soyad, @eposta, @telefon, @parola_hash, @rol)";

            MySqlCommand cmd = new MySqlCommand(sorgu, _context.conn());

            cmd.Parameters.AddWithValue("@kullanici_adi",kullanici.kullanici_adi);
            cmd.Parameters.AddWithValue("@ad", kullanici.ad);
            cmd.Parameters.AddWithValue("@soyad", kullanici.soyad);
            cmd.Parameters.AddWithValue("@eposta", kullanici.eposta);
            cmd.Parameters.AddWithValue("@telefon", kullanici.telefon);
            cmd.Parameters.AddWithValue("@parola_hash", PasswordHelper.HashPassword(kullanici.parola_hash));
            cmd.Parameters.AddWithValue("@rol", kullanici.rol);
            cmd.ExecuteNonQuery();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracServisV1.Entity;
using AracServisV1.Helpers;
using MySql.Data.MySqlClient;

namespace AracServisV1.DataAccess
{
    public class LoginDAL
    {
        AracServisContext _context= new AracServisContext();


        public Kullanici KullaniciGetir(string username, string password)
        {
            String sifreliParola = PasswordHelper.HashPassword(password);

            String sorgu = "Select * from kullanicilar where kullanici_adi=@kullaniciAdi and parola_hash=@parolaHash and aktif_mi=@aktif_mi";
            MySqlCommand cmd = new MySqlCommand(sorgu, _context.conn());
            cmd.Parameters.AddWithValue("@kullaniciAdi", username);
            cmd.Parameters.AddWithValue("@parolaHash", sifreliParola);
            cmd.Parameters.AddWithValue("@aktif_mi", true);

            using (var dataOku = cmd.ExecuteReader())
            {
                if (dataOku.Read())
                {
                    return new Kullanici
                    {
                        kullanici_adi = dataOku["kullanici_adi"].ToString(),
                        ad = dataOku["ad"].ToString(),
                        soyad = dataOku["soyad"].ToString(),
                        rol = dataOku["rol"].ToString(),
                    };
                }
            } 

            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AracServisV1.DataAccess
{
    public class AracServisContext
    {
        public MySqlConnection conn()
        {
            MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=aracservis;Uid=root;Pwd='';");

            if (baglanti.State == ConnectionState.Closed)
            { 
            baglanti.Open();
            }

            return baglanti;
        }
    }
}

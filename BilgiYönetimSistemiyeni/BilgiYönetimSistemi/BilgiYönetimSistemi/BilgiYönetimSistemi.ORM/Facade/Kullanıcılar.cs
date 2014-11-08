using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilgiYönetimSistemi.ORM;
using BilgiYönetimSistemi.ORM.Entity;
using System.Data.SqlClient;


namespace BilgiYönetimSistemi.ORM.Facade
{
    public class Kullanıcılar
    {
        public static DataTable Listele()
        {
            return Araclar.Listele("kullaniciListele");
        }
        public static bool Ekle(Kullanıcı entity)
        {
            SqlCommand komut = new SqlCommand("kullaniciEkle", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@kAdi", entity.kullanıcıAdi);
            komut.Parameters.AddWithValue("@sfr", entity.sifre);
            return Araclar.komut_calisma(komut);

        }
    }
}

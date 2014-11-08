
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilgiYönetimSistemi.ORM.Entity;
using System.Data;
using System.Data.SqlClient;

namespace BilgiYönetimSistemi.ORM.Facade
{
    public class Musteriler
    {
        //public static DataTable Listele()
        //{
        //    return Araclar.Listele("MusteriListele");
        //}
        public static bool Ekle(Musteri entity)
        {

            SqlCommand komut = new SqlCommand("musteriEkle", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@no", entity.musteriNo);
            komut.Parameters.AddWithValue("@ad", entity.musteriAdi);
            komut.Parameters.AddWithValue("@syd", entity.musteriSoyadi);
            komut.Parameters.AddWithValue("@tel", entity.tel);
            komut.Parameters.AddWithValue("@sfr", entity.Sifre);

            return Araclar.komut_calisma(komut);
        }

    }
}
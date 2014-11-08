using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilgiYönetimSistemi.ORM.Entity;


namespace BilgiYönetimSistemi.ORM.Facade
{
    public class Kategoriler
    {

        public static DataTable Listele()
        {
            return Araclar.Listele("kategoriListele");
        }

        public static bool Ekle(Kategori entity)
        {
            SqlCommand komut = new SqlCommand("kategoriEkle", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@kAdi", entity.kategoriadi);
            return Araclar.komut_calisma(komut);

        }
        public static bool Sil(Kategori silEntity)
        {
            SqlCommand komut = new SqlCommand("kategoriSil", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@id", silEntity.id);
            return Araclar.komut_calisma(komut);
        }
        public static bool Guncelle(Kategori guncelleEntity)
        {
            SqlCommand komut = new SqlCommand("kategoriGuncelle", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@kAdi", guncelleEntity.kategoriadi);
            komut.Parameters.AddWithValue("@id", guncelleEntity.id);
            return Araclar.komut_calisma(komut);
        }
    }
}

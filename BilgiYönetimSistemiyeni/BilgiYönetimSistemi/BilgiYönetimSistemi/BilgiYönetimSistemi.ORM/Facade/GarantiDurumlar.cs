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
    public class GarantiDurumlar
    {
        public static DataTable Listele()
        {
            return Araclar.Listele("garantiDurumListele");
        }
        public static bool Ekle(GarantiDurum entity)
        {
            SqlCommand komut = new SqlCommand("garantiDurumEkle", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@gAdi", entity.garantiadi);
            return Araclar.komut_calisma(komut);

        }
        public static bool Sil(GarantiDurum silEntity)
        {
            SqlCommand komut = new SqlCommand("garantiDurumSil", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@id", silEntity.id);
            return Araclar.komut_calisma(komut);
        }
        public static bool Guncelle(GarantiDurum guncelleEntity)
        {
            SqlCommand komut = new SqlCommand("garantiDurumGuncelle", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@gAdi", guncelleEntity.garantiadi);
            komut.Parameters.AddWithValue("@id", guncelleEntity.id);
            return Araclar.komut_calisma(komut);
        }



    }
}

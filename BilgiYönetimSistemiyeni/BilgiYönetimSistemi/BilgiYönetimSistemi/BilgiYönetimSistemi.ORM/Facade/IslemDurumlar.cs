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
    public class IslemDurumlar
    {
        
        public static DataTable Listele()
        {
            return Araclar.Listele("islemDurumListele");
        }
        public static bool Ekle(IslemDurum entity)
        {
            SqlCommand komut = new SqlCommand("islemDurumEkle", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@iAdi", entity.islemdurumadi);
            komut.Parameters.AddWithValue("@renk", entity.renk);
            return Araclar.komut_calisma(komut);

        }
        public static bool Sil(IslemDurum silEntity)
        {
            SqlCommand komut = new SqlCommand("islemDurumSil", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@id", silEntity.id);
            return Araclar.komut_calisma(komut);
        }
        public static bool Guncelle(IslemDurum guncelleEntity)
        {
            SqlCommand komut = new SqlCommand("islemDurumGuncelle", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@iAdi", guncelleEntity.islemdurumadi);
            komut.Parameters.AddWithValue("@renk", guncelleEntity.renk);
            komut.Parameters.AddWithValue("@id", guncelleEntity.id);
            return Araclar.komut_calisma(komut);
        }
    }
}

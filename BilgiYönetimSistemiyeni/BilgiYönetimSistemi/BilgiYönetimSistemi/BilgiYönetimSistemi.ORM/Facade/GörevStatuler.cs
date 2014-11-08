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
    public class GörevStatuler
    {
        public static DataTable Listele()
        {
            return Araclar.Listele("görevStatuListele");
        }

        public static bool Ekle(GörevStatu entity)
        {
            SqlCommand komut = new SqlCommand("görevStatuEkle", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@gsAdi", entity.görevstatuadi);
           
            return Araclar.komut_calisma(komut);

        }
        public static bool Sil(GörevStatu silEntity)
        {
            SqlCommand komut = new SqlCommand("görevStatuSil", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@id", silEntity.id);
            return Araclar.komut_calisma(komut);
        }
        public static bool Guncelle(GörevStatu guncelleEntity)
        {
            SqlCommand komut = new SqlCommand("görevStatuGuncelle", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@gsAdi", guncelleEntity.görevstatuadi);
          
            komut.Parameters.AddWithValue("@id", guncelleEntity.id);
            return Araclar.komut_calisma(komut);
        }
    }
}

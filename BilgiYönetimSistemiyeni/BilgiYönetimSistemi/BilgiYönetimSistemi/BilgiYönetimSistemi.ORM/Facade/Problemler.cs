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
    public class Problemler
    {
        public static DataTable Listele()
        {
            return Araclar.Listele("problemListele");
        }

        public static bool Ekle(Problem entity)
        {
            SqlCommand komut = new SqlCommand("problemEkle", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@pTuru", entity.probTuru);
            komut.Parameters.AddWithValue("@cTuru", entity.cihazTuru);
            komut.Parameters.AddWithValue("@soru1", entity.soru1);
            komut.Parameters.AddWithValue("@soru2", entity.soru2);
            komut.Parameters.AddWithValue("@soru3", entity.soru3);
            return Araclar.komut_calisma(komut);

        }
        public static bool Sil(Problem silEntity)
        {
            SqlCommand komut = new SqlCommand("problemSil", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@id", silEntity.id);
            return Araclar.komut_calisma(komut);
        }
        public static bool Guncelle(Problem guncelleEntity)
        {
            SqlCommand komut = new SqlCommand("problemGuncelle", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@pTuru", guncelleEntity.probTuru);
            komut.Parameters.AddWithValue("@cTuru", guncelleEntity.cihazTuru);
            komut.Parameters.AddWithValue("@soru1", guncelleEntity.soru1);
            komut.Parameters.AddWithValue("@soru2", guncelleEntity.soru2);
            komut.Parameters.AddWithValue("@soru3", guncelleEntity.soru3);
            komut.Parameters.AddWithValue("@id", guncelleEntity.id);
            return Araclar.komut_calisma(komut);
        }

    }
}

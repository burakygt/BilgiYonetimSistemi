using BilgiYönetimSistemi.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiYönetimSistemi.ORM.Facade
{
   public  class IscilikTanimlar
    {
        public static DataTable Listele()
        {
            return Araclar.Listele("iscilikTanimListele");
        }
        public static bool Ekle(IscilikTanim entity)
        {
            SqlCommand komut = new SqlCommand("iscilikTanimEkle", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@hBilgisi", entity.hizmetbilgisi);
            komut.Parameters.AddWithValue("@ucret", entity.ucret);
            komut.Parameters.AddWithValue("@kdv", entity.kdv);
            komut.Parameters.AddWithValue("@not", entity.notlar);
            return Araclar.komut_calisma(komut);

        }
        public static bool Sil(IscilikTanim silEntity)
        {
            SqlCommand komut = new SqlCommand("iscilikTanimSil", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@id", silEntity.id);
            return Araclar.komut_calisma(komut);
        }
        public static bool Guncelle(IscilikTanim guncelleEntity)
        {
            SqlCommand komut = new SqlCommand("iscilikTanimGuncelle", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@id", guncelleEntity.id);
            komut.Parameters.AddWithValue("@hBilgisi", guncelleEntity.hizmetbilgisi);
            komut.Parameters.AddWithValue("@ucret", guncelleEntity.ucret);
            komut.Parameters.AddWithValue("@kdv", guncelleEntity.kdv);
            komut.Parameters.AddWithValue("@not", guncelleEntity.notlar);
            return Araclar.komut_calisma(komut);
        }

    }
}

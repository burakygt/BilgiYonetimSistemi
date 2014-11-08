using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilgiYönetimSistemi.ORM.Entity;
using System.Data.SqlClient;
using System.Data;

namespace BilgiYönetimSistemi.ORM.Facade
{
    public class MusteriDetaylar
    {
        public static DataTable Listele()
        {
            return Araclar.Listele("MusteriDetayListele");
        }

        public static bool Ekle(MusteriDetay entity)
        {
            SqlCommand komut = new SqlCommand("musteriDetayEkle", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@cKod", entity.cariKod);
            komut.Parameters.AddWithValue("@cUnv", entity.cariUnvan);
           
            komut.Parameters.AddWithValue("@grp", entity.grup);
            
            komut.Parameters.AddWithValue("@tel1", entity.tel1);
            
            komut.Parameters.AddWithValue("@kTar", entity.kayitTarih);
            komut.Parameters.AddWithValue("@tKK",entity.tekkullanimlikkod);
            komut.Parameters.AddWithValue("@iYapan",entity.islemiyapan);

            return Araclar.komut_calisma(komut);
        }

        public static bool Sil(MusteriDetay silEntity)
        {
            SqlCommand komut = new SqlCommand("musteriDetaySil", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@id", silEntity.id);
            return Araclar.komut_calisma(komut);
        }
        public static bool Guncelle (MusteriDetay guncelleEntity)
        {
            SqlCommand komut = new SqlCommand("musteriDetayGuncelle", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@cKod", guncelleEntity.cariKod);
            komut.Parameters.AddWithValue("@cUnv", guncelleEntity.cariUnvan);
            komut.Parameters.AddWithValue("@kat", guncelleEntity.kategori);
            komut.Parameters.AddWithValue("@grp", guncelleEntity.grup);
            komut.Parameters.AddWithValue("@foto", guncelleEntity.resim);
            komut.Parameters.AddWithValue("@yetk", guncelleEntity.yetkili);
            komut.Parameters.AddWithValue("@tel1", guncelleEntity.tel1);
            komut.Parameters.AddWithValue("@tel2", guncelleEntity.tel2);
            komut.Parameters.AddWithValue("@eps", guncelleEntity.eposta);
            komut.Parameters.AddWithValue("@web", guncelleEntity.web);
            komut.Parameters.AddWithValue("@adr", guncelleEntity.adres);
            komut.Parameters.AddWithValue("@il", guncelleEntity.il);
            komut.Parameters.AddWithValue("@ilc", guncelleEntity.ilce);
            komut.Parameters.AddWithValue("@not", guncelleEntity.not);
            komut.Parameters.AddWithValue("@fb", guncelleEntity.facebook);
            komut.Parameters.AddWithValue("@tw", guncelleEntity.twitter);
            komut.Parameters.AddWithValue("@dgr", guncelleEntity.diger);
            komut.Parameters.AddWithValue("@kTar", guncelleEntity.kayitTarih);
            komut.Parameters.AddWithValue("@id", guncelleEntity.id);
            komut.Parameters.AddWithValue("@iYapan", guncelleEntity.islemiyapan);

            return Araclar.komut_calisma(komut);

        }



    }
}

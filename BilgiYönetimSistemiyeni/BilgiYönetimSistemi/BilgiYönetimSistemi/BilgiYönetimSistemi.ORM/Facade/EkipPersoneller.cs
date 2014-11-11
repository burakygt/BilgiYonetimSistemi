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
    public class EkipPersoneller
    {
        public static DataTable Listele()
        {
            return Araclar.Listele("ekipPersonelListele");
        }
        public static bool Ekle(EkipPersonel entity)
        {
            SqlCommand komut = new SqlCommand("ekipPersonelEkle", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@adsoyad", entity.adsoyad);
            komut.Parameters.AddWithValue("@tel",entity.tel);
            komut.Parameters.AddWithValue("@statu",entity.statu);
            komut.Parameters.AddWithValue("@birim",entity.birim);
            komut.Parameters.AddWithValue("@calisiyor",entity.calisiyor);
            return Araclar.komut_calisma(komut);

        }
        public static bool Sil(EkipPersonel silEntity)
        {
            SqlCommand komut = new SqlCommand("ekipPersonelSil", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@id", silEntity.id);
            return Araclar.komut_calisma(komut);
        }
        public static bool Guncelle(EkipPersonel guncelleEntity)
        {
            SqlCommand komut = new SqlCommand("ekipPersonelGuncelle", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@id",guncelleEntity.id);
            komut.Parameters.AddWithValue("@adsoyad", guncelleEntity.adsoyad);
            komut.Parameters.AddWithValue("@tel", guncelleEntity.tel);
            komut.Parameters.AddWithValue("@statu", guncelleEntity.statu);
            komut.Parameters.AddWithValue("@birim", guncelleEntity.birim);
            komut.Parameters.AddWithValue("@calisiyor", guncelleEntity.calisiyor);
            return Araclar.komut_calisma(komut);
        }
    }
}

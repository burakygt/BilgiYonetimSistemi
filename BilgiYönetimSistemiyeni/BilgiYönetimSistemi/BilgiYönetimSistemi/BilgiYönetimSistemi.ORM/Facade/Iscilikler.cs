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
    public class Iscilikler
    {
        public static DataTable Listele()
        {
            return Araclar.Listele("iscilikListele");
        }
        public static bool Ekle(Iscilik entity)
        {
            SqlCommand komut = new SqlCommand("iscilikEkle", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@cKod", entity.carikod);
            komut.Parameters.AddWithValue("@iTarih", entity.isciliktarihi);
            komut.Parameters.AddWithValue("@yIsler", entity.yapilanisler);
            komut.Parameters.AddWithValue("@sure", entity.sure);
            komut.Parameters.AddWithValue("@ucret", entity.ucret);
            // komut.Parameters.AddWithValue("@kdv", entity.kdv);
            komut.Parameters.AddWithValue("@yTutar", entity.yereltutar);
            komut.Parameters.AddWithValue("@iNot", entity.isciliknot);


            return Araclar.komut_calisma(komut);

        }
        public static bool Sil(Iscilik silEntity)
        {
            SqlCommand komut = new SqlCommand("iscilikSil", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@id", silEntity.id);
            return Araclar.komut_calisma(komut);
        }
        public static bool Guncelle(Iscilik guncelleEntity)
        {
            SqlCommand komut = new SqlCommand("iscilikGuncelle", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@id", guncelleEntity.id);
            komut.Parameters.AddWithValue("@cKod", guncelleEntity.carikod);
            komut.Parameters.AddWithValue("@iTarih", guncelleEntity.isciliktarihi);
            komut.Parameters.AddWithValue("@yIsler", guncelleEntity.yapilanisler);
            komut.Parameters.AddWithValue("@sure", guncelleEntity.sure);
            komut.Parameters.AddWithValue("@ucret", guncelleEntity.ucret);
            // komut.Parameters.AddWithValue("@kdv", guncelleEntity.kdv);
            komut.Parameters.AddWithValue("@yTutar", guncelleEntity.yereltutar);
            komut.Parameters.AddWithValue("@iNot", guncelleEntity.isciliknot);
            return Araclar.komut_calisma(komut);
        }

    }
}

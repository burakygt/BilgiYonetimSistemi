using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BilgiYönetimSistemi.ORM.Entity;


namespace BilgiYönetimSistemi.ORM.Facade
{
   public class Urunler
    {
       public static DataTable Listele()
       {
           return Araclar.Listele("urunListele");

       }
       public static bool Ekle(Urun entity)
       {
           SqlCommand komut = new SqlCommand("urunEkle", Araclar.Baglanti);
           komut.CommandType = CommandType.StoredProcedure;
           komut.Parameters.AddWithValue("@uCins", entity.uruncinsi);
           komut.Parameters.AddWithValue("@mrka", entity.marka);
           komut.Parameters.AddWithValue("@mdel", entity.model);
           return Araclar.komut_calisma(komut);
       }
       public static bool Sil(Urun silEntity)
       {
           SqlCommand komut = new SqlCommand("urunSil", Araclar.Baglanti);
           komut.CommandType = CommandType.StoredProcedure;
           komut.Parameters.AddWithValue("@id", silEntity.id);
           return Araclar.komut_calisma(komut);
       }
       public static bool Guncelle(Urun guncelleEntity)
       {
           SqlCommand komut = new SqlCommand("urunGuncelle", Araclar.Baglanti);
           komut.CommandType = CommandType.StoredProcedure;
           komut.Parameters.AddWithValue("@id",guncelleEntity.id);
           komut.Parameters.AddWithValue("@uCins", guncelleEntity.uruncinsi);
           komut.Parameters.AddWithValue("@mrka", guncelleEntity.marka);
           komut.Parameters.AddWithValue("@mdel", guncelleEntity.model);
           return Araclar.komut_calisma(komut);

       }

    }
}

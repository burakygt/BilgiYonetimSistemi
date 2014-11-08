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
    public class Gruplar
    {
        public static DataTable Listele()
        {
            return Araclar.Listele("grupListele");
        }

        public static bool Ekle(Grup entity)
        {
            SqlCommand komut = new SqlCommand("grupEkle", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@ad", entity.grupadi);
            return Araclar.komut_calisma(komut);

        }
        public static bool Sil(Grup silEntity)
        {
            SqlCommand komut = new SqlCommand("grupSil", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@id", silEntity.id);
            return Araclar.komut_calisma(komut);
        }
        public static bool Guncelle(Grup guncelleEntity)
        {
            SqlCommand komut = new SqlCommand("grupGuncelle", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@ad", guncelleEntity.grupadi);
            komut.Parameters.AddWithValue("@id", guncelleEntity.id);
            return Araclar.komut_calisma(komut);
        }
    }
}

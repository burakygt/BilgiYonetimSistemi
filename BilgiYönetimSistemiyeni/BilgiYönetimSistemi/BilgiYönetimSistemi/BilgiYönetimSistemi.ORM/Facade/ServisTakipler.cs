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
    public class ServisTakipler
    {
        public static DataTable Listele()
        {
            return Araclar.Listele("servisTakipListele");

        }
        public static bool Ekle(ServisTakip entity)
        {
            SqlCommand komut = new SqlCommand("servisTakipEkle", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@cKod", entity.carikod);
            komut.Parameters.AddWithValue("@fNo",entity.formno);
            komut.Parameters.AddWithValue("@cUnv",entity.cariunvan);
            komut.Parameters.AddWithValue("@kat",entity.kategori);
            komut.Parameters.AddWithValue("@gBilg",entity.girisbilgisi);
            komut.Parameters.AddWithValue("@oDur", entity.onaydurum);
            komut.Parameters.AddWithValue("@oBilg", entity.onaybilgisi);
            komut.Parameters.AddWithValue("@tDur", entity.teslimdurum);
            komut.Parameters.AddWithValue("@tBilg", entity.teslimbilgisi);
            komut.Parameters.AddWithValue("@onarim", entity.onarim);
            komut.Parameters.AddWithValue("@hizmet", entity.hizmet);
            komut.Parameters.AddWithValue("@montaj", entity.montaj);
            komut.Parameters.AddWithValue("@uCins", entity.uruncinsi);
            komut.Parameters.AddWithValue("@mrka", entity.marka);
            komut.Parameters.AddWithValue("@modl", entity.model);
            komut.Parameters.AddWithValue("@sNo", entity.serino);
            komut.Parameters.AddWithValue("@bNo", entity.barkodno);
            komut.Parameters.AddWithValue("@iYapan", entity.isiyapan);
            komut.Parameters.AddWithValue("@uTesEden", entity.urunteslimeden);
            komut.Parameters.AddWithValue("@ekpPers", entity.ekippersonel);
            komut.Parameters.AddWithValue("@iDurum", entity.islemdurumu);
            komut.Parameters.AddWithValue("@gDurum", entity.garantidurumu);
            komut.Parameters.AddWithValue("@pTuru", entity.probturu);
            komut.Parameters.AddWithValue("@s1", entity.soru1);
            komut.Parameters.AddWithValue("@c1", entity.cevap1);
            komut.Parameters.AddWithValue("@s2", entity.soru2);
            komut.Parameters.AddWithValue("@c2", entity.cevap2);
            komut.Parameters.AddWithValue("@s3", entity.soru3);
            komut.Parameters.AddWithValue("@c3", entity.cevap3);
            komut.Parameters.AddWithValue("@isletim", entity.isletimsistemi);
            komut.Parameters.AddWithValue("@konsol", entity.konsolturu);
            komut.Parameters.AddWithValue("@kol", entity.kolsayisi);
            komut.Parameters.AddWithValue("@islemiYapan",entity.islemiyapan);
            return Araclar.komut_calisma(komut);
        }
        public static bool Sil(ServisTakip silEntity)
        {
            SqlCommand komut = new SqlCommand("servisTakipSil", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@id", silEntity.id);
            return Araclar.komut_calisma(komut);
        }
        public static bool Guncelle(ServisTakip guncelleEntity)
        {
            SqlCommand komut = new SqlCommand("servisTakipGuncelle", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@fNo", guncelleEntity.formno);

            komut.Parameters.AddWithValue("@cKod", guncelleEntity.carikod);
            komut.Parameters.AddWithValue("@cUnv", guncelleEntity.cariunvan);
            komut.Parameters.AddWithValue("@kat", guncelleEntity.kategori);
            komut.Parameters.AddWithValue("@gBilg", guncelleEntity.girisbilgisi);
            komut.Parameters.AddWithValue("@oDur", guncelleEntity.onaydurum);
            komut.Parameters.AddWithValue("@oBilg", guncelleEntity.onaybilgisi);
            komut.Parameters.AddWithValue("@tDur", guncelleEntity.teslimdurum);
            komut.Parameters.AddWithValue("@tBilg", guncelleEntity.teslimbilgisi);
            komut.Parameters.AddWithValue("@onarim", guncelleEntity.onarim);
            komut.Parameters.AddWithValue("@hizmet", guncelleEntity.hizmet);
            komut.Parameters.AddWithValue("@montaj", guncelleEntity.montaj);
            komut.Parameters.AddWithValue("@uCins", guncelleEntity.uruncinsi);
            komut.Parameters.AddWithValue("@mrka", guncelleEntity.marka);
            komut.Parameters.AddWithValue("@modl", guncelleEntity.model);
            komut.Parameters.AddWithValue("@sNo", guncelleEntity.serino);
            komut.Parameters.AddWithValue("@bNo", guncelleEntity.barkodno);
            komut.Parameters.AddWithValue("@iYapan", guncelleEntity.isiyapan);
            komut.Parameters.AddWithValue("@uTesEden", guncelleEntity.urunteslimeden);
            komut.Parameters.AddWithValue("@ekpPers", guncelleEntity.ekippersonel);
            komut.Parameters.AddWithValue("@iDurum", guncelleEntity.islemdurumu);
            komut.Parameters.AddWithValue("@gDurum", guncelleEntity.garantidurumu);
            komut.Parameters.AddWithValue("@pTuru", guncelleEntity.probturu);
            komut.Parameters.AddWithValue("@s1", guncelleEntity.soru1);
            komut.Parameters.AddWithValue("@c1", guncelleEntity.cevap1);
            komut.Parameters.AddWithValue("@s2", guncelleEntity.soru2);
            komut.Parameters.AddWithValue("@c2", guncelleEntity.cevap2);
            komut.Parameters.AddWithValue("@s3", guncelleEntity.soru3);
            komut.Parameters.AddWithValue("@c3", guncelleEntity.cevap3);
            komut.Parameters.AddWithValue("@id", guncelleEntity.id);
            komut.Parameters.AddWithValue("@isletim", guncelleEntity.isletimsistemi );
            komut.Parameters.AddWithValue("@konsol", guncelleEntity.konsolturu );
            komut.Parameters.AddWithValue("@kol", guncelleEntity.kolsayisi );
            komut.Parameters.AddWithValue("@islemiYapan", guncelleEntity.islemiyapan);


            return Araclar.komut_calisma(komut);


        }
    }
}

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
    public class AktiviteGörevler
    {
        public static DataTable Listele()
        {
            return Araclar.Listele("aktiviteGörevListele");
        }
        public static bool Ekle(AktiviteGörev entity)
        {
            SqlCommand komut = new SqlCommand("aktiviteGörevEkle", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@gKodu", entity.görevkodu);
            komut.Parameters.AddWithValue("@gStatusu", entity.görevstatusu);
            komut.Parameters.AddWithValue("@kategori", entity.kategori);
            komut.Parameters.AddWithValue("@gBasTarih", entity.görevbaslamatarihi);
            komut.Parameters.AddWithValue("@gBasSaat", entity.görevbaslamasaati);
            komut.Parameters.AddWithValue("@tGöSüSaat", entity.tahgörevsüresiSaat);
            komut.Parameters.AddWithValue("@tGöSüDakika", entity.tahgörevsüresiDakika);
            komut.Parameters.AddWithValue("@gBitDurum", entity.görevbitisDurum);
            komut.Parameters.AddWithValue("@gBitTarih", entity.görevbitisTarih);
            komut.Parameters.AddWithValue("@gBitSaat", entity.görevbitisSaat);
            komut.Parameters.AddWithValue("@hatirDurum", entity.hatirlamaDurum);
            komut.Parameters.AddWithValue("@hatirTarih", entity.hatirlamaTarih);
            komut.Parameters.AddWithValue("@hatirSaat", entity.hatirlamaSaat);
            komut.Parameters.AddWithValue("@cKod", entity.carikod);
            komut.Parameters.AddWithValue("@tUnvan", entity.ticariunvan);
            komut.Parameters.AddWithValue("@serFormNo", entity.servisformno);
            komut.Parameters.AddWithValue("@uDetay", entity.urundetay);
            komut.Parameters.AddWithValue("@iDurum", entity.islemdurum);
            komut.Parameters.AddWithValue("@gDurum", entity.garantidurum);
            komut.Parameters.AddWithValue("@pAdi", entity.personeladi);
            komut.Parameters.AddWithValue("@gGüzergah", entity.görevGüzergah);
            komut.Parameters.AddWithValue("@gKonu", entity.görevKonu);
            komut.Parameters.AddWithValue("@prob", entity.problem);
            komut.Parameters.AddWithValue("@pNotu", entity.personelnotu);
            komut.Parameters.AddWithValue("@iYapan",entity.islemiyapan);
            return Araclar.komut_calisma(komut);




        }
        public static bool Sil(AktiviteGörev silEntity)
        {
            SqlCommand komut = new SqlCommand("aktiviteGörevSil", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@id", silEntity.id);
            return Araclar.komut_calisma(komut);
        }
        public static bool Guncelle(AktiviteGörev guncelleEntity)
        {
            SqlCommand komut = new SqlCommand("aktiviteGörevGuncelle", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@gKodu", guncelleEntity.görevkodu);
            komut.Parameters.AddWithValue("@gStatusu", guncelleEntity.görevstatusu);
            komut.Parameters.AddWithValue("@kategori", guncelleEntity.kategori);
            komut.Parameters.AddWithValue("@gBasTarih", guncelleEntity.görevbaslamatarihi);
            komut.Parameters.AddWithValue("@gBasSaat", guncelleEntity.görevbaslamasaati);
            komut.Parameters.AddWithValue("@tGöSüSaat", guncelleEntity.tahgörevsüresiSaat);
            komut.Parameters.AddWithValue("@tGöSüDakika", guncelleEntity.tahgörevsüresiDakika);
            komut.Parameters.AddWithValue("@gBitDurum", guncelleEntity.görevbitisDurum);
            komut.Parameters.AddWithValue("@gBitTarih", guncelleEntity.görevbitisTarih);
            komut.Parameters.AddWithValue("@gBitSaat", guncelleEntity.görevbitisSaat);
            komut.Parameters.AddWithValue("@hatirDurum", guncelleEntity.hatirlamaDurum);
            komut.Parameters.AddWithValue("@hatirTarih", guncelleEntity.hatirlamaTarih);
            komut.Parameters.AddWithValue("@hatirSaat", guncelleEntity.hatirlamaSaat);
            komut.Parameters.AddWithValue("@cKod", guncelleEntity.carikod);
            komut.Parameters.AddWithValue("@tUnvan", guncelleEntity.ticariunvan);
            komut.Parameters.AddWithValue("@serFormNo", guncelleEntity.servisformno);
            komut.Parameters.AddWithValue("@uDetay", guncelleEntity.urundetay);
            komut.Parameters.AddWithValue("@iDurum", guncelleEntity.islemdurum);
            komut.Parameters.AddWithValue("@gDurum", guncelleEntity.garantidurum);
            komut.Parameters.AddWithValue("@pAdi", guncelleEntity.personeladi);
            komut.Parameters.AddWithValue("@gGüzergah", guncelleEntity.görevGüzergah);
            komut.Parameters.AddWithValue("@gKonu", guncelleEntity.görevKonu);
            komut.Parameters.AddWithValue("@prob", guncelleEntity.problem);
            komut.Parameters.AddWithValue("@pNotu", guncelleEntity.personelnotu);
            komut.Parameters.AddWithValue("@iYapan", guncelleEntity.islemiyapan);
            return Araclar.komut_calisma(komut);
        }
    }
}

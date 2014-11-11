using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using BilgiYönetimSistemi.ORM;
using BilgiYönetimSistemi.ORM.Entity;
using BilgiYönetimSistemi.ORM.Facade;

namespace BilgiYönetimSistemi.ORM
{
    public class Sorgular
    {
        public static SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["BYS_baglanti"].ConnectionString);

        public static DataTable musteriAl()
        {
            SqlCommand komut = new SqlCommand("select id,carikod,cariunvan from MusteriDetay", baglanti);
            DataTable tbl = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(tbl);
            return tbl;


        }
        public static DataTable UrunSelect()
        {
            SqlCommand komut = new SqlCommand("select id ID,UrunCinsi URUNCINS,Marka MARKA,Model MODEL from Urunler", baglanti);
            DataTable tbl = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(tbl);
            return tbl;
        }

        public static DataSet ComboDoldurma()
        {
            SqlDataAdapter verial = new SqlDataAdapter("Select UrunCinsi from Urunler", baglanti);
            DataSet dset = new DataSet();
            verial.Fill(dset);

            return dset;
        }
        public static DataSet ComboDoldurma2()
        {
            SqlDataAdapter verial = new SqlDataAdapter("Select Marka from Urunler", baglanti);
            DataSet dset = new DataSet();
            verial.Fill(dset);

            return dset;
        }
        public static DataSet GarantiComboDoldurma()
        {
            SqlDataAdapter da = new SqlDataAdapter("select GarantiDurumAdi from GarantiDurum", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public static DataTable IslemSorgu()
        {
            SqlCommand komut = new SqlCommand("select id ID,IslemDurumAdi IDURUM,Renk RENK from IslemDurum", baglanti);
            DataTable tblo = new DataTable();
            SqlDataAdapter dad = new SqlDataAdapter(komut);
            dad.Fill(tblo);
            return tblo;
        }
        public static DataSet IslemComboDoldurma()
        {
            SqlDataAdapter dasdas = new SqlDataAdapter("Select IslemDurumAdi from IslemDurum", baglanti);
            DataSet dse = new DataSet();
            dasdas.Fill(dse);

            return dse;
        }
        public static DataSet EkipPersonel()
        {
            SqlDataAdapter dsad = new SqlDataAdapter("Select AdiSoyadi from EkipPersonel", baglanti);
            DataSet dsdsds = new DataSet();
            dsad.Fill(dsdsds);
            return dsdsds;
        }
        public static DataSet ProblemDoldurma()
        {
            SqlDataAdapter cs = new SqlDataAdapter("Select  ProblemTuru  from Problemler", baglanti);
            DataSet asd = new DataSet();
            cs.Fill(asd,"Problemler");
            return asd;
        }
        public static DataSet AnaFormGridDoldurma()
        {
            SqlDataAdapter csa = new SqlDataAdapter("Select id ID,carikod CARIKOD,cariunvan CARIUNVAN,tel1 TEL1  from MusteriDetay", baglanti);
            DataSet asda = new DataSet();
            csa.Fill(asda);
            return asda;
        }
        public static DataSet IscilikCombo()
        {
            SqlDataAdapter csaa = new SqlDataAdapter("Select HizmetBilgisi from IscilikTanimlari", baglanti);
            DataSet asdaa= new DataSet();
            csaa.Fill(asdaa);
            return asdaa;
        }
        public static DataSet KullanıcıListele()
        {
            SqlDataAdapter sdaptr = new SqlDataAdapter("select kullaniciAdi,sifre from Kullanıcılar",baglanti);
            DataSet dtst=new DataSet();
            sdaptr.Fill(dtst);
            return dtst;
        }
    }
}

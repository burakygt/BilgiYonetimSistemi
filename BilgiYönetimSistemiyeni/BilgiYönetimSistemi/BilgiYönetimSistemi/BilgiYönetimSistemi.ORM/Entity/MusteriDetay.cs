using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BilgiYönetimSistemi.ORM.Entity
{
    public class MusteriDetay
    {
        public int id { get; set; }
        public int cariKod { get; set; }
        public string cariUnvan { get; set; }
        public string kategori { get; set; }
        public string grup { get; set; }
        public string resim { get; set; } // burada prob cıkabilir..
        public string yetkili { get; set; }
        public decimal tel1 { get; set; }
        public decimal tel2 { get; set; }
        public string eposta { get; set; }
        public string web { get; set; }
        public string adres { get; set; }
        public string il { get; set; }
        public string ilce { get; set; }
        public string not { get; set; }
        public string facebook { get; set; }
        public string twitter { get; set; }
        public string diger { get; set; }
        public DateTime kayitTarih { get; set; }
        public string tekkullanimlikkod { get; set; }
        public string islemiyapan { get; set; }
    }
}

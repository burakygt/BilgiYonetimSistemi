using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiYönetimSistemi.ORM.Entity
{
    public class AktiviteGörev
    {
        public int id { get; set; }
        public int görevkodu { get; set; }
        public string görevstatusu { get; set; }
        public string kategori { get; set; }
        public DateTime görevbaslamatarihi  { get; set; }
        public DateTime görevbaslamasaati { get; set; }
        public int tahgörevsüresiSaat { get; set; }
        public int tahgörevsüresiDakika { get;set; }
        public bool görevbitisDurum { get; set; }
        public DateTime görevbitisTarih { get; set; }
        public DateTime görevbitisSaat { get; set; }
        public bool hatirlamaDurum { get; set; }
        public DateTime hatirlamaTarih { get; set; }
        public DateTime hatirlamaSaat { get; set; }
        public int carikod { get; set; }
        public string ticariunvan { get; set; }
        public int servisformno { get; set; }
        public string urundetay { get; set; }
        public string islemdurum { get; set; }
        public string garantidurum { get; set; }
        public string personeladi { get; set; }
        public string görevGüzergah { get; set; }
        public string görevKonu { get; set; }
        public string problem { get; set; }
        public string personelnotu { get; set; }
        public string islemiyapan { get; set; }

    }
}

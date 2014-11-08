using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiYönetimSistemi.ORM.Entity
{
    public class ServisTakip
    {
        public int id { get; set; }
        public int carikod { get; set; }
        public int formno { get; set; }
        public string cariunvan { get; set; }
        public string kategori { get; set; }
        public DateTime girisbilgisi { get; set; }
        public bool onaydurum { get; set; }
        public DateTime onaybilgisi { get; set; }
        public bool teslimdurum { get; set; }
        public DateTime teslimbilgisi { get; set; }
        public bool onarim { get; set; }
        public bool hizmet { get; set; }
        public bool montaj { get; set; }
        public string uruncinsi { get; set; }
        public string marka { get; set; }
        public string model { get; set; }
        public int serino { get; set; }
        public int barkodno { get; set; }
        public string isiyapan { get; set; }
        public string urunteslimeden { get; set; }
        public string ekippersonel { get; set; }
        public string islemdurumu { get; set; }
        public string garantidurumu { get; set; }
        public string probturu { get; set; }
        public string soru1 { get; set; }
        public string cevap1 { get; set; }
        public string soru2 { get; set; }
        public string cevap2 { get; set; }
        public string soru3 { get; set; }
        public string cevap3 { get; set; }
        public string isletimsistemi { get; set; }
        public string konsolturu { get; set; }
        public int kolsayisi { get; set; }
        public string islemiyapan { get; set; }

    }
}

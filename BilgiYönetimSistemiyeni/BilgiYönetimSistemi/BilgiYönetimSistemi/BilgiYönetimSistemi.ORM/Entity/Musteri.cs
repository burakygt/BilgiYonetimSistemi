using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiYönetimSistemi.ORM.Entity
{
    public class Musteri
    {
        public int id { get; set; }
        public int musteriNo { get; set; }
        public string musteriAdi { get; set; }
        public string musteriSoyadi { get; set; }
        public decimal tel { get; set; }
        public string Sifre { get; set; }
    }
}

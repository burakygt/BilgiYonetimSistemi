using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiYönetimSistemi.ORM.Entity
{
    public class EkipPersonel
    {
        public int id { get; set; }
        public string adsoyad  { get; set; }
        public decimal tel { get; set; }
        public string statu { get; set; }
        public string birim { get; set; }
        public int calisiyor { get; set; }
    }
}

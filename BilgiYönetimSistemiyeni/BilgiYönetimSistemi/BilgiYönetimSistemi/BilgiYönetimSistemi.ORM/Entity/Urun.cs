using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiYönetimSistemi.ORM.Entity
{
   public class Urun
    {
        public int id { get; set; }
        public string uruncinsi { get; set; }
        public string marka { get; set; }
        public string model { get; set; }
    }
}

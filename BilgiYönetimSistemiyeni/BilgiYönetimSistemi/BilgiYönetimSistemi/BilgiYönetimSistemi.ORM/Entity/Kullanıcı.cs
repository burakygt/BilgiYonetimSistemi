using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiYönetimSistemi.ORM.Entity
{
    public class Kullanıcı
    {
        public int id { get; set; }
        public string kullanıcıAdi { get; set; }
        public decimal sifre { get; set; }
    }
}

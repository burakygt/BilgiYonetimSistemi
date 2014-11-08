using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiYönetimSistemi.ORM.Entity
{
    public class IscilikTanim
    {
        public int id { get; set; }
        public string hizmetbilgisi { get; set; }
        public decimal ucret { get; set; }
        public decimal kdv { get; set; }
        public string notlar { get; set; }
    }
}

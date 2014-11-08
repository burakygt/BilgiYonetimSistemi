using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiYönetimSistemi.ORM.Entity
{
    public class Problem
    {
        public int id { get; set; }
        public string probTuru { get; set; }
        public string cihazTuru { get; set; }
        public string soru1 { get; set; }
        public string soru2 { get; set; }
        public string soru3 { get; set; }
    }
}

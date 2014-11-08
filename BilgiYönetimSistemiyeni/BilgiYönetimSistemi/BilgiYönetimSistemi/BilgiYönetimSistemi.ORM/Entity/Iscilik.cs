using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiYönetimSistemi.ORM.Entity
{
    public class Iscilik
    {
        public int id { get; set; }
        public int carikod { get; set; }
        public DateTime isciliktarihi { get; set; }
        public string yapilanisler { get; set; }
        public decimal sure { get; set; }
        public decimal ucret { get; set; }
        //public decimal kdv { get; set; }
        public decimal yereltutar { get; set; }
        public string isciliknot { get; set; }
    }
}

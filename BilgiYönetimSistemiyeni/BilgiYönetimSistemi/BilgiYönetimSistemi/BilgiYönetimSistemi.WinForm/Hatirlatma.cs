using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using BilgiYönetimSistemi.ORM;

namespace BilgiYönetimSistemi.WinForm
{
    public partial class Hatirlatma : Form
    {
        public Hatirlatma()
        {
            InitializeComponent();
        }
        public static SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["BYS_baglanti"].ConnectionString);
        DataTable verilerial = new DataTable();
        public static string sistemsaati, hatirlatmasaati;
        int toplamdakika, kalandakika;
        private void Hatirlatma_Load(object sender, EventArgs e)
        {
            hatirlat();
           
        }
        public void sorgugetir()
        {
            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.Date.ToString("yyyy-MM-dd HH:mm:ss");

            SqlDataAdapter da = new SqlDataAdapter("select görevkodu,görevbaslamatarihi,görevbitistarihi,substring(convert(varchar, hatirlatmasaati, 24),1, 5) as HatırlatmaSaati,servisformno,problem,personelnotu from AktiviteGörev where HatirlatmaTarih = '" + sqlFormattedDate + "' and islemiYapan='" + Araclar.kullaniciadi + "' and hatirlatmadurum=1 order by hatirlatmasaati desc ", baglanti);

            
            da.Fill(verilerial);
        }
        public void saathatirlat()
        {
            sistemsaati = DateTime.Now.ToLongTimeString();
            hatirlatmasaati = dataGridView1.Rows[0].Cells[3].Value.ToString();
            DateTime ilkdeger = Convert.ToDateTime(sistemsaati);
            DateTime sondeger = Convert.ToDateTime(hatirlatmasaati);

            System.TimeSpan zaman;
            zaman = sondeger.Subtract(ilkdeger);
            toplamdakika = Convert.ToInt32(zaman.TotalMinutes);


        }
        public void hatirlat()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            sorgugetir();

            if (verilerial.Rows.Count > 0)
            {
                dataGridView1.DataSource = verilerial;
                //label1.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();    gridden veri almak    
               

            }
            baglanti.Close();


        }

       
    }
}

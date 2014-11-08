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
            saathatirlat();

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
            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.Date.ToString("yyyy-MM-dd HH:mm:ss");

            SqlDataAdapter da = new SqlDataAdapter("select görevkodu,görevbaslamatarihi,görevbitistarihi,hatirlatmasaati,servisformno,problem,personelnotu from AktiviteGörev where HatirlatmaTarih = '" + sqlFormattedDate + "' and islemiYapan='" + Araclar.kullaniciadi + "' order by hatirlatmasaati desc ", baglanti);

            DataTable verilerial = new DataTable();
            da.Fill(verilerial);

            if (verilerial.Rows.Count > 0)
            {
                dataGridView1.DataSource = verilerial;
                //label1.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();    gridden veri almak    
                timer1.Enabled = true;

            }
            baglanti.Close();



        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (toplamdakika != 0)
            {
                kalandakika = toplamdakika - 1;
                if (toplamdakika == 60)
                {
                    MessageBox.Show("Hatırlatma için son 1 saat !", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Show();
                    timer1.Enabled = false;
                }
            }



        }

        private void Hatirlatma_Shown(object sender, EventArgs e)
        {
            if (toplamdakika < 60)
            {
                MessageBox.Show("Hatırlatma için kalan süre " + toplamdakika + " dakikadır", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

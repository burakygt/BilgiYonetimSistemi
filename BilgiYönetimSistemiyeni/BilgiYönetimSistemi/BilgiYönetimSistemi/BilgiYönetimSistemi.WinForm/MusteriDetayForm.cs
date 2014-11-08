using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BilgiYönetimSistemi.ORM;
using BilgiYönetimSistemi.ORM.Entity;
using BilgiYönetimSistemi.ORM.Facade;
using System.Data.SqlClient;
using System.Configuration;

namespace BilgiYönetimSistemi.WinForm
{
    public partial class MusteriDetayForm : Form
    {
        public MusteriDetayForm()
        {
            InitializeComponent();
        }

        public static SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["BYS_baglanti"].ConnectionString);

        public DataSet dt = new DataSet();
        public DataSet dt1 = new DataSet();
        string tel1, tel2;
        decimal number, number2;
        public static int cariKod;
        public static int satir;

        private void MusteriDetay_Load(object sender, EventArgs e)
        {
            xtraEkle.Show();
            txtcarikod.Enabled = false;
            gridControl1.DataSource = Sorgular.musteriAl();
            #region illeri doldurma

            SqlDataAdapter da = new SqlDataAdapter("select ilid, il from iller", baglanti);
            da.Fill(dt);
            satir = dt.Tables[0].Rows.Count;

            int satiruser;
            satiruser = dt.Tables[0].Rows.Count;
            for (int i = 0; i <= satiruser - 1; i++)
            {

                //comboİl.Items.Add(dt.Tables[0].Rows[i][1].ToString());
                comboİl.Items.Add(dt.Tables[0].Rows[i][0].ToString());
            }

            #endregion
            #region hakan_carikoddoldurma
            if (txtcarikod.Text == "")
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                SqlCommand adp = new SqlCommand("select top 1 carikod from MusteriDetay order by id desc ", baglanti);
                SqlDataReader dr1;

                dr1 = adp.ExecuteReader();
                string deger;

                while (dr1.Read())
                {

                    deger = dr1["carikod"].ToString();
                    cariKod = Convert.ToInt32(deger);
                    cariKod++;
                    txtcarikod.Text = "MU" + cariKod.ToString();

                }
                baglanti.Close();
            }


            #endregion
            #region hakan_telefon
            txttel1.Mask = "999-000-0000";
            txttel2.Mask = "999-000-0000";
            txttel1.BeepOnError = true;
            txttel2.BeepOnError = true;



            #endregion
            // Click eventide var
        }

        public void hakan_telduzeltme()
        {

            tel1 = txttel1.Text;
            tel1 = tel1.Replace("-", "");
            number =Convert.ToDecimal((tel1));

            //tel2 = txttel2.Text;
            //tel2 = tel2.Replace("-", "");
            //number2 = int.Parse(tel2);

        }
        private void bKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                hakan_telduzeltme();


                MusteriDetay entity = new MusteriDetay();
                entity.cariKod = cariKod;
                entity.cariUnvan = txtcariunvan.Text.ToString();
                //entity.kategori = beKategori.Text.ToString();
                entity.grup = beGrup.Text.ToString();
                //entity.resim = txtpath.Text.ToString();
                //entity.yetkili = txtyetkili.Text.ToString();
                entity.tel1 = Convert.ToDecimal(number);
               // entity.tel2 = Convert.ToDecimal(number2);
                //entity.eposta = txteposta.Text.ToString();
                //entity.web = txtweb.Text.ToString();
                //entity.adres = txtadres.Text.ToString();
                //entity.il = comboİl.Text.ToString();
                //entity.ilce = comboİlce.Text.ToString();
                //entity.not = txtnot.Text.ToString();
                //entity.facebook = beFace.Text.ToString();
                //entity.twitter = beTwitter.Text.ToString();
                //entity.diger = beDiger.Text.ToString();
                entity.kayitTarih = dateTimePicker1.Value;
                entity.tekkullanimlikkod = txtTekKullanımlık.Text;
                entity.islemiyapan = Araclar.kullaniciadi;

                if (!MusteriDetaylar.Ekle(entity))
                    MessageBox.Show("Musteri Eklenemedi");
            }
            catch
            {

                MessageBox.Show("Hata");
            }

            ServisTakipFormu stf = new ServisTakipFormu();
            stf.txtCariKod.Text = txtcarikod.Text;
            stf.txtUnvan.Text = txtcariunvan.Text;
            stf.txtCariKod.Enabled = false;
            stf.txtUnvan.Enabled = false;
           // stf.MdiParent = AnaForm;
            stf.Show();
            this.Close();
            // gridControl1.DataSource = MusteriDetaylar.Listele();
            //gridControl1.DataSource = Sorgular.musteriAl();

            #region temizleme
            foreach (Control item in this.Controls)
            {

                if (item is TextBox)
                {

                    TextBox tbox = (TextBox)item;

                    tbox.Clear();
                }
                dt.Clear();
                dt1.Clear();
            }
            #endregion

        }
        #region ilceleri doldurma
        private void comboİl_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt1.Clear();
            comboİlce.DataSource = null;
            comboİlce.Items.Clear();


            SqlDataAdapter da = new SqlDataAdapter("select ilceid, ilce from ilceler where ilid=" + comboİl.SelectedItem + "", baglanti);
            da.Fill(dt1);



            int satiruser;
            satiruser = dt1.Tables[0].Rows.Count;
            for (int i = 0; i <= satiruser - 1; i++)
            {
                //ComboBox1.Items.Add(ds1.Tables(0).Rows(i)(0).ToString)
                comboİlce.Items.Add(dt1.Tables[0].Rows[i][1].ToString());




            }
        #endregion
        }

        


        

        private void tümBilgileriniGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = MusteriDetaylar.Listele();
        }

        private void beKategori_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            KategorilerForm ktg = new KategorilerForm();
            ktg.ShowDialog();
        }

        private void beGrup_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GruplarForm grp = new GruplarForm();
            grp.ShowDialog();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Data.DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            MusteriDetay silincek = new MusteriDetay();
            silincek.id = (int)row["id"];
            if (!MusteriDetaylar.Sil(silincek))
                MessageBox.Show("Silinemedi");
            gridControl1.DataSource = MusteriDetaylar.Listele();
        }
        public string GenerateNewPassword(int size)
        {
            char[] cr = "0123456789abcdefghijklmnopqrstuvwxyz".ToCharArray();
            string result = string.Empty;
            Random r = new Random();
            for (int i = 0; i < size; i++)
            {
                result += cr[r.Next(0, cr.Length - 1)].ToString();
            }
            return result;
        }
        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hakan_telduzeltme();
            MusteriDetay guncelle = new MusteriDetay();
            guncelle.id = (int)gridView1.GetFocusedRowCellValue("id");
            guncelle.cariKod = Convert.ToInt32(AnaForm.carikod);
            guncelle.cariUnvan = txtcariunvan.Text.ToString();
            guncelle.kategori = beKategori.Text.ToString();
            guncelle.grup = beGrup.Text.ToString();
            guncelle.resim = txtpath.Text.ToString();
            guncelle.yetkili = txtyetkili.Text.ToString();
            guncelle.tel1 = Convert.ToDecimal(txttel1.Text);
            guncelle.tel2 = Convert.ToDecimal(txttel2.Text);
            guncelle.eposta = txteposta.Text.ToString();
            guncelle.web = txtweb.Text.ToString();
            guncelle.adres = txtadres.Text.ToString();
            guncelle.il = comboİl.Text.ToString();
            guncelle.ilce = comboİlce.Text.ToString();
            guncelle.not = txtnot.Text.ToString();
            guncelle.facebook = beFace.Text.ToString();
            guncelle.twitter = beTwitter.Text.ToString();
            guncelle.diger = beDiger.Text.ToString();
            guncelle.kayitTarih = dateTimePicker1.Value;
            guncelle.islemiyapan = Araclar.kullaniciadi;

            if (!MusteriDetaylar.Guncelle(guncelle))
            {
                MessageBox.Show("Duzenleme Başarısız");
            }
            gridControl1.DataSource = MusteriDetaylar.Listele();
        }

        

        private void cariÖzetiniGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = Sorgular.musteriAl();
        }

        private void txttel1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Geçersiz Karakter Girişi Yapıldı", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txttel2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Geçersiz Karakter Girişi Yapıldı", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
          txtTekKullanımlık.Text= GenerateNewPassword(8);
        }


    }
}

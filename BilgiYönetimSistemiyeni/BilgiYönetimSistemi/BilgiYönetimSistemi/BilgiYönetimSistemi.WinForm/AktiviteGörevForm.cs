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
using System.Threading;
using DevExpress.XtraEditors;

namespace BilgiYönetimSistemi.WinForm
{
    public partial class AktiviteGörevForm : Form
    {
        public AktiviteGörevForm()
        {
            InitializeComponent();
        }
        public static SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["BYS_baglanti"].ConnectionString);
        int gorevKodu,carikod,formno;
        string islemteslim, teslimsaat;
        private void simpleButton8_Click(object sender, EventArgs e)
        {
            GörevStatüleriForm gsf = new GörevStatüleriForm();
            gsf.BringToFront();
            gsf.ShowDialog();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            IslemDurumForm idf = new IslemDurumForm();
            idf.BringToFront();
            idf.ShowDialog();
        }

        private void buttonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            KategorilerForm ktg = new KategorilerForm();
            ktg.BringToFront();
            ktg.Show();
        }

        private void AktiviteGörevForm_Load(object sender, EventArgs e)
        {
            #region checkKontrol
            if (cGörevBitis.Checked == false)
            {
                dtGörevBitis.Enabled = false;
                teGörBitisTarih.Enabled = false;


            }
            if (cHatirlatma.Checked == false)
            {
                dtHatirlatma.Enabled = false;
                teHatirlatma.Enabled = false;
            }
            #endregion
            #region hakan_gorevkoduarttırma

            if (txtGorevKodu.Text == "")
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                SqlCommand adp = new SqlCommand("select top 1 GörevKodu from AktiviteGörev order by id desc ", baglanti);
                SqlDataReader dr1;

                dr1 = adp.ExecuteReader();
                string deger;

                while (dr1.Read())
                {

                    deger = dr1["GörevKodu"].ToString();
                    gorevKodu  = Convert.ToInt32(deger);
                    gorevKodu++;
                    txtGorevKodu.Text = "GR" + gorevKodu.ToString();

                }
                baglanti.Close();
            }


            #endregion
            #region hakan_telefon
            txtTel1.Mask = "(999)-000-0000";
            txtTel2.Mask = "(999)-000-0000";
            txtTel1.BeepOnError = true;
            txtTel2.BeepOnError = true;
            #endregion 
            // Click eventide var


        }

        private void cGörevBitis_CheckedChanged(object sender, EventArgs e)
        {
            if (cGörevBitis.Checked)
            {
                dtGörevBitis.Enabled = true;
                teGörBitisTarih.Enabled = true;
            }
            else
            {
                dtGörevBitis.Enabled = false;
                teGörBitisTarih.Enabled = false;
            }
        }

        private void cHatirlatma_CheckedChanged(object sender, EventArgs e)
        {
            if (cHatirlatma.Checked)
            {
                dtHatirlatma.Enabled = true;
                teHatirlatma.Enabled = true;
            }
            else
            {
                dtHatirlatma.Enabled = false;
                teHatirlatma.Enabled = false;
            }    
            }
        public void kayit()
        {
            try
            {

                AktiviteGörev entity = new AktiviteGörev();
                entity.görevkodu = gorevKodu;
                entity.görevstatusu = comboGörevStatüsü.Text;
                entity.kategori = beKategoriler.Text;
                entity.görevbaslamatarihi = dtGörevBasTarih.Value;

                entity.görevbaslamasaati = Convert.ToDateTime(maskedTextBox1.Text);
                entity.tahgörevsüresiSaat = Convert.ToInt32(nudSaat.Value);
                entity.tahgörevsüresiDakika = Convert.ToInt32(nudDakika.Value);
                #region checkKayıt
                if (cGörevBitis.Checked)
                {
                    entity.görevbitisDurum = Convert.ToBoolean(1);
                }
                else
                {
                    entity.görevbitisDurum = Convert.ToBoolean(0);

                }
                if (cHatirlatma.Checked)
                {
                    entity.hatirlamaDurum = Convert.ToBoolean(1);
                }
                else
                {
                    entity.hatirlamaDurum = Convert.ToBoolean(0);

                }
                #endregion
                entity.görevbitisTarih = dtGörevBitis.Value;

                entity.görevbitisSaat = Convert.ToDateTime(teGörBitisTarih.Text);
                entity.hatirlamaTarih = dtHatirlatma.Value;

                entity.hatirlamaSaat = Convert.ToDateTime(teHatirlatma.Text);
                entity.carikod = Convert.ToInt32(carikod);
                entity.ticariunvan = txtTicariUnvan.Text;
                entity.servisformno = Convert.ToInt32(formno);
                entity.urundetay = txtUrunDetay.Text;
                entity.islemdurum = comboIslemDurum.Text;
                entity.garantidurum = txtGarantiDurum.Text;
                entity.personeladi = comboPersAdi.Text;
                entity.görevGüzergah = comboGüzergah.Text;
                entity.görevKonu = txtGörevKonusu.Text;
                entity.problem = txtProblem.Text;
                entity.personelnotu = txtPersNotu.Text;
                entity.islemiyapan = Araclar.kullaniciadi;
                if (!AktiviteGörevler.Ekle(entity))
                    MessageBox.Show("Görev Eklenemedi");
                else
                {
                    MessageBox.Show("Görev başarıyla eklenmiştir..");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {

            kayit();
            
            
        
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            BilgilendirmeForm bgf = new BilgilendirmeForm();
            bgf.ShowDialog();
        }

        private void txtTel1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Geçersiz Karakter Girişi Yapıldı", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txtTel2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Geçersiz Karakter Girişi Yapıldı", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void comboIslemDurum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboIslemDurum.Text == "Teslim Edildi")
            {
                DateTime myDateTime = DateTime.Now;
                islemteslim = myDateTime.Date.ToString("yyyy-MM-dd HH:mm:ss");
                dtGörevBitis.Text = islemteslim;
                DateTime myDateTime2 = Convert.ToDateTime(DateTime.Now.ToShortTimeString());
                teslimsaat = myDateTime.Date.Hour.ToString("HH:mm:ss");
                teGörBitisTarih.Text = teslimsaat;

            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BilgiYönetimSistemi.ORM;
using BilgiYönetimSistemi.ORM.Entity;
using BilgiYönetimSistemi.ORM.Facade;
using DevExpress.Utils.Animation;
using DevExpress.XtraEditors;


namespace BilgiYönetimSistemi.WinForm
{
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }
        public static SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["BYS_baglanti"].ConnectionString);

        Control animatedControl;
        private void MusteriForm_Load(object sender, EventArgs e)
        {
            combodoldur();
            animatedControl = xtraTabControl1;
           // txtTel.Mask = "(999)-000-0000";

            // Populate the ImageComboBox with available transition types.
            imageComboBoxEdit1.Properties.Items.AddEnum(typeof(DevExpress.Utils.Animation.Transitions));
            imageComboBoxEdit1.SelectedIndexChanged += imageComboBoxEdit1_SelectedIndexChanged;
            imageComboBoxEdit1.SelectedIndex = 0;
        }
        public void combodoldur()
        {
            DataSet ds3 = Sorgular.KullanıcıListele();
            foreach (DataRow dr3 in ds3.Tables[0].Rows)
            {
               comboBox1.Items.Add(dr3["kullaniciAdi"].ToString());
            }
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

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            
        }
        
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand dr = new SqlCommand("select kullaniciAdi,sifre from Kullanıcılar where kullaniciAdi='" + comboBox1.Text.ToString() + "' and sifre='" + txtSoyad.Text.ToString() + "'", baglanti);
            SqlDataReader kullanicivarmi = dr.ExecuteReader();
            if (kullanicivarmi.HasRows == false)
            {
                txtSoyad.Text = "";
                comboBox1.Text = "";
                MessageBox.Show("Yanlış kullanıcı adı veya şifre.!!");
                
            }
            else
            {

                AnaForm anf = new AnaForm();
                Araclar.kullaniciadi = comboBox1.Text;
                anf.Show();
                this.Hide();

            }
            kullanicivarmi.Close();
            baglanti.Close();
            
            #region textcontrolü
            string metin,metin2;

            metin = comboBox1.Text;
            metin2 = txtSoyad.Text;
            //metin3 = txtTel.Text;
            if (metin.Length <=0)
            {
                errorProvider1.SetError(comboBox1, "Boş geçilemez");
            }
            if (metin2.Length<=0)
            {
                errorProvider2.SetError(txtSoyad, "Boş geçilemez");
            }
            
            #endregion
            //else
            //{
            //    Musteri entity = new Musteri();
            //    //entity.musteriNo = tx
            //    entity.musteriAdi = txtAd.Text.ToString();
            //    entity.musteriSoyadi = txtSoyad.Text.ToString();
            //    //entity.tel = Convert.ToDecimal(txtTel.Text);
            //    entity.Sifre = txtSifre.Text.ToString();

            //    if (!Musteriler.Ekle(entity))
            //        MessageBox.Show("Müşteri Eklenemedi");
            //    else
            //    {
            //        MessageBox.Show("Müşteri Başarıyla Eklenmiştir. Programa Yönlendiriliyorsunuz.");
            //        timer1.Enabled = true;
            //    }
            //}

            
            
        }

        private void imageComboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ImageComboBoxEdit imComboBox = sender as ImageComboBoxEdit;

            if (transitionManager1.Transitions[animatedControl] == null)
            {
                // Add a transition, associated with the xtraTabControl1, to the TransitionManager.
                Transition transition1 = new Transition();
                transition1.Control = animatedControl;
                transitionManager1.Transitions.Add(transition1);
            }
            DevExpress.Utils.Animation.Transitions trType = (DevExpress.Utils.Animation.Transitions)imComboBox.EditValue;
            transitionManager1.Transitions[animatedControl].TransitionType = CreateTransitionInstance(trType);
        }
        DevExpress.Data.Utils.IEasingFunction myEasingFunc = new DevExpress.Data.Utils.BackEase();

        BaseTransition CreateTransitionInstance(Transitions transitionType)
        {
            switch (transitionType)
            {
                case Transitions.Dissolve: return new DissolveTransition();
                case Transitions.Fade: return new FadeTransition();
                case Transitions.Shape: return new ShapeTransition();
                case Transitions.Clock: return new ClockTransition();
                case Transitions.SlideFade: return new SlideFadeTransition();
                case Transitions.Cover: return new CoverTransition();
                case Transitions.Comb: return new CombTransition();
                default: return new PushTransition();
            }
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            transitionManager1.EndTransition();
        }

        private void xtraTabControl1_SelectedPageChanging(object sender, DevExpress.XtraTab.TabPageChangingEventArgs e)
        {
            if (animatedControl == null) return;
            transitionManager1.StartTransition(animatedControl);
        }

        private void transitionManager1_CustomTransition(ITransition transition, CustomTransitionEventArgs e)
        {
            // Set a clip region for the state transition.
            e.Regions = new Rectangle[] { xtraTabPage1.Bounds };
            // Specify a custom easing function.
            e.EasingFunction = myEasingFunc;
        }

        

        

        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
            txtSifre.Text = GenerateNewPassword(8);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AnaForm anf = new AnaForm();
            anf.Show();
            this.Hide();
            timer1.Enabled = false;
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            AnaForm anf = new AnaForm();
            anf.Show();
            this.Hide();
        }

        private void txtTel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Geçersiz Karakter Girişi Yapıldı", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            xtraTabPage2.Show();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            Kullanıcı entity = new Kullanıcı();
            entity.kullanıcıAdi = textEdit1.Text;
            entity.sifre =Convert.ToDecimal( textEdit2.Text);
            if (!Kullanıcılar.Ekle(entity))
                MessageBox.Show("Kullanıcı Eklenemedi");
            else
            {
                MessageBox.Show("Kullanıcı Başarıyla Eklenmiştir.");
            }
            comboBox1.Items.Clear();
            combodoldur();
            xtraTabPage1.Show();
        }

        
    }
}

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
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraReports.Data;
using DevExpress.XtraReports.Configuration;
using DevExpress.XtraReports.Design;
using DevExpress.XtraReports.UI;

namespace BilgiYönetimSistemi.WinForm
{
    public partial class ServisTakipFormu : Form
    {
        public ServisTakipFormu()
        {
            InitializeComponent();
        }
        public static SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["BYS_baglanti"].ConnectionString);
        #region Datasetler
        DataSet ds1 = Sorgular.ComboDoldurma();
        DataSet ds2 = Sorgular.ComboDoldurma2();
        DataSet ds3 = Sorgular.GarantiComboDoldurma();
        DataSet tbl = Sorgular.IslemComboDoldurma();
        DataSet ds5 = Sorgular.ProblemDoldurma();
        DataSet ds4 = Sorgular.EkipPersonel();


        #endregion
        int formkodu;
        string tel;
        public static int cariKodd;// yeni eklenen kod_hakan
        
        private void ServisTakipFormu_Load(object sender, EventArgs e)
        {
            AnaForm anf1=new AnaForm();
            //tel = anf1.gridView2.GetFocusedRowCellValue(anf1.col_tel11).ToString();
            //gridControl1.DataSource = Iscilikler.Listele();
            //yenileme();
            #region iscilik doldurma
            SqlDataAdapter sdpp = new SqlDataAdapter("select islemTarihi TARIH,yapilanIscilik YAPILAN,sure SURE,birimFiyat UCRET,yerelTutar TUTAR from Iscilik where carikod like '%" + txtCariKod.Text + "%'", baglanti);
            DataSet dst = new DataSet();
            sdpp.Fill(dst);
            gridIsci.DataSource=dst.Tables[0];
            #endregion
            #region CheckKontrol
            if (cOnay.Checked == false)
            {
                dtOnay.Enabled = false;

            }
            if (cTeslim.Checked == false)
            {
                dtTeslim.Enabled = false;
            }
            #endregion
            #region Combobox doldurma


            foreach (DataRow dr in ds1.Tables[0].Rows)
            {

                comboUrun.Items.Add(dr["UrunCinsi"].ToString());
            }
            foreach (DataRow dr2 in ds2.Tables[0].Rows)
            {
                comboMarka.Items.Add(dr2["Marka"].ToString());
            }

            #endregion
            #region GarantiComboDoldurma

            foreach (DataRow dr3 in ds3.Tables[0].Rows)
            {
                comboGarantiDurum.Items.Add(dr3["GarantiDurumAdi"].ToString());
            }
            #endregion
            #region işlem combo doldurma
            foreach (DataRow tbl1 in tbl.Tables[0].Rows)
            {

                comboIslemDurum.Items.Add(tbl1["IslemDurumAdi"].ToString());
                //comboIslemDurum.ForeColor=
            }

            #endregion
            #region Personel combolarını doldurma
            foreach (DataRow dr3 in ds4.Tables[0].Rows)
            {
                comboIsiYapan.Items.Add(dr3["AdiSoyadi"].ToString());
                comboEkipPersonel.Items.Add(dr3["AdiSoyadi"].ToString());
                comboUrunTeslimEden.Items.Add(dr3["AdiSoyadi"].ToString());
            }
            #endregion

            cariKodd =Convert.ToInt32( AnaForm.carikod);//yeni eklenen kod_hakan

            iscidoldur();
            ComboDoldur();
            UrunDoldurma();

            
            #region hakan_formkoduarttırma
            if (beFormNo.Text == "")
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                SqlCommand adp = new SqlCommand("select top 1 formNo from ServisTakip order by id desc ", baglanti);
                SqlDataReader dr1;

                dr1 = adp.ExecuteReader();
                string deger;

                while (dr1.Read())
                {

                    deger = dr1["formNo"].ToString();
                    formkodu = Convert.ToInt32(deger);
                    formkodu++;
                    beFormNo.Text = "AS"+formkodu.ToString();

                }
                baglanti.Close();
            }
                #endregion
           
        }
        public void iscidoldur()
        {
            #region iscilik doldurma

            SqlDataAdapter sdpp = new SqlDataAdapter("select islemTarihi TARIH,yapilanIscilik YAPILAN,sure SURE,birimFiyat UCRET,yerelTutar TUTAR from Iscilik where carikod=" + Convert.ToInt32(AnaForm.formno) + "", baglanti);
            DataTable dst = new DataTable();
            sdpp.Fill(dst);
            gridIsci.DataSource = dst;
            //gridIsci.DataSource = ServisTakipler.Listele();
            //gridIsci.RefreshDataSource();
            //gridIsci.Refresh();
            #endregion
        }
            #region urunmarkamodel_doldurma

        public void UrunDoldurma() //formload olayında çağrılacak
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            DataTable dt1 = new DataTable();
            string sorgu2 = "select distinct UrunCinsi from Urunler";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = sorgu2;
            komut.Connection = baglanti;
            SqlDataReader reader;
            reader = komut.ExecuteReader();

            comboUrun.Items.Clear();
            while (reader.Read())
            {
                comboUrun.Items.Add(reader["UrunCinsi"].ToString());
            }
        }

                private void comboUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            numericUpDown1.Value = 0;
            comboMarka.Enabled = true;
            comboModel.Items.Clear();
            comboMarka.SelectedItem = null;
            comboModel.Text = null;
            comboKonsol.Items.Clear();
            comboIsletim.Items.Clear();
            comboIsletim.Text = null;
            comboProbTur.Text = null;
            
            
            DataTable dt2 = new DataTable();
            string sorgu = "SELECT distinct Marka FROM Urunler WHERE UrunCinsi like '%" + comboUrun.Text + "%'";
             SqlCommand komut = new SqlCommand();
             SqlDataReader reader;
            komut.CommandText = sorgu;
            komut.Connection = baglanti;
            reader = komut.ExecuteReader();
            comboMarka.Items.Clear();
            
           while (reader.Read())
            {
                comboMarka.Items.Add(reader["Marka"].ToString());
               comboIsletim.Enabled  = true;
                numericUpDown1.Enabled = true;
               comboKonsol.Enabled  = true;
           
               
            }
           if (comboUrun.Text == "Notebook" || comboUrun.Text == "Desktop")
           {
               comboKonsol.Enabled = false;
               numericUpDown1.Enabled = false;
               comboKonsol.Text = null;
               numericUpDown1.Value = 0;
               comboIsletim.Items.Add("Win XP");
               comboIsletim.Items.Add("Win 7");
               comboIsletim.Items.Add("Win 8");
               comboIsletim.Items.Add("Win 8.1");
               comboIsletim.Items.Add("Linux");
               comboIsletim.Items.Add("Macintosh");

           }
           else if (comboUrun.Text == "Konsol")
           {
               comboIsletim.Enabled = false;
               comboIsletim.Text = null;
               //numericUpDown1.Value = 0; sıfırlaması yoksa sıfırlamaması iyi karar veremedim :))
                                           
              
           }
           else if (comboUrun.Text == "Tablet")
           {
               comboKonsol.Enabled = false;
               numericUpDown1.Enabled = false;
               comboKonsol.Text = null;
               numericUpDown1.Value = 0;
               comboIsletim.Items.Add("Android");
               comboIsletim.Items.Add("iOS");
           }
           comboModel.Enabled = false;

           baglanti.Close();
           }
                private void comboMarka_SelectedIndexChanged(object sender, EventArgs e)
                {
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }

                    comboKonsol.Items.Clear();
                    comboKonsol.Text = null;
                   comboModel.Enabled = true;
                   
                    DataTable dt2 = new DataTable();
                    string sorgu = "SELECT Model FROM Urunler WHERE Marka like '%" + comboMarka.Text + "%' and UrunCinsi like'%"+comboUrun.Text +"%'";
                    SqlCommand komut = new SqlCommand();
                    SqlDataReader reader;
                    komut.CommandText = sorgu;
                    komut.Connection = baglanti;
                    reader = komut.ExecuteReader();
                    comboModel.Items.Clear();
                    comboModel.Text = null;
                    checkDiger.Enabled = true;
                    while (reader.Read())
                    {
                        comboModel.Items.Add(reader["Model"].ToString());
                    }
                    if (comboMarka.Text == "Sony")
                    {
                        comboKonsol.Items.Add("PS3 Fat");
                        comboKonsol.Items.Add("PS3 Slim");
                        comboKonsol.Items.Add("PS3 Super Slim");
                        comboKonsol.Items.Add("PS4 Fat");
                        comboKonsol.Items.Add("PS4 Slim");
                        comboKonsol.Items.Add("PS4 Super Slim");
                        comboKonsol.Items.Add("PSP");
                    }
                    else if (comboMarka.Text == "Nintendo")
                    {
                        comboKonsol.Items.Add("Wii");
                    }
                    else if (comboMarka.Text == "Xbox")
                    {
                        comboKonsol.Items.Add("Xbox");
                    }

                   
                }
                private void checkDiger_CheckedChanged(object sender, EventArgs e)
                {
                    if (checkDiger.Checked == true)
                    {
                        textModel.Enabled = true;
                       comboModel.Text = null;
                        comboModel.Enabled = false;
                    }
                    else
                    {
                        textModel.Enabled = false;
                       comboModel.Enabled = true;
                    }
  baglanti.Close();
                }


       

            #endregion
                      
                public void ComboDoldur()
                {
                   
                    SqlCommand kmt = new SqlCommand();
            SqlDataReader rdr;
            kmt.Connection = baglanti;
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            kmt.CommandText = "Select  id,ProblemTuru  from Problemler";
            rdr = kmt.ExecuteReader();
            while (rdr.Read())
            {
                //comboProbTur.Items.Add(rdr["id"].ToString()+" | "+rdr["ProblemTuru"].ToString());
                comboProbTur.Items.Add(rdr["ProblemTuru"].ToString());
            }
            rdr.Close();
            baglanti.Close();
        }
        public void yenileme()
        {
            ds1.Clear();
            #region Combobox doldurma


            foreach (DataRow dr in ds1.Tables[0].Rows)
            {

                comboUrun.Items.Add(dr["UrunCinsi"].ToString());
            }
            foreach (DataRow dr2 in ds2.Tables[0].Rows)
            {
                comboMarka.Items.Add(dr2["Marka"].ToString());
            }

            #endregion
            //ds1 = Sorgular.ComboDoldurma();
            ds2.Clear();
            ds2 = Sorgular.ComboDoldurma2();
            ds3.Clear();
            #region GarantiComboDoldurma

            foreach (DataRow dr3 in ds3.Tables[0].Rows)
            {
                comboGarantiDurum.Items.Add(dr3["GarantiDurumAdi"].ToString());
            }
            #endregion
            ds4.Clear();
            #region Personel combolarını doldurma
            foreach (DataRow dr3 in ds4.Tables[0].Rows)
            {
                comboIsiYapan.Items.Add(dr3["AdiSoyadi"].ToString());
                comboEkipPersonel.Items.Add(dr3["AdiSoyadi"].ToString());
                comboUrunTeslimEden.Items.Add(dr3["AdiSoyadi"].ToString());
            }
            #endregion
            //ds3 = Sorgular.GarantiComboDoldurma();

        }
        private void bKaydet_Click(object sender, EventArgs e)
        {
            
            try
            {
                #region kayıt
                ServisTakip entity = new ServisTakip();
                entity.formno = formkodu;
                entity.carikod =cariKodd;
                entity.cariunvan = txtUnvan.Text;
                entity.kategori = beKategori.Text;
                entity.girisbilgisi = dtGiris.Value;
                entity.onaybilgisi = dtOnay.Value;
                entity.teslimbilgisi = dtTeslim.Value;

                #region checkKontrol
                if (cOnay.Checked)
                {
                    entity.onaydurum = Convert.ToBoolean(1);
                }
                else
                {
                    entity.onaydurum = Convert.ToBoolean(0);
                }
                if (cTeslim.Checked)
                {
                    entity.teslimdurum = Convert.ToBoolean(1);
                }
                else
                {
                    entity.teslimdurum = Convert.ToBoolean(0);
                }
                if (radioButton1.Checked)
                {
                    entity.onarim = Convert.ToBoolean(1);
                }
                else
                {
                    entity.onarim = Convert.ToBoolean(0);
                }
                if (radioButton2.Checked)
                {
                    entity.hizmet = Convert.ToBoolean(1);
                }
                else
                {
                    entity.hizmet = Convert.ToBoolean(0);
                }
                if (radioButton3.Checked)
                {
                    entity.montaj = Convert.ToBoolean(1);
                }
                else
                {
                    entity.montaj = Convert.ToBoolean(0);
                }

                #endregion
                entity.uruncinsi = comboUrun.Text;
                entity.marka = comboMarka.Text;
                entity.model = comboModel.Text; 
                entity.serino = Convert.ToInt32(comboSeriNo.Text);
                entity.barkodno = Convert.ToInt32(beBarkod.Text);
                entity.isiyapan = comboIsiYapan.Text;
                entity.urunteslimeden = comboUrunTeslimEden.Text;
                entity.ekippersonel = comboEkipPersonel.Text;
                entity.islemdurumu = comboIslemDurum.Text;
                entity.garantidurumu = comboGarantiDurum.Text;
                entity.probturu = comboProbTur.Text;
                entity.soru1 = txtSoru1.Text;
                entity.cevap1 = txtCevap1.Text;
                entity.soru2 = txtSoru2.Text;
                entity.cevap2 = txtCevap2.Text;
                entity.soru3 = txtSoru3.Text;
                entity.cevap3 = txtCevap3.Text;
                entity.isletimsistemi = comboIsletim.Text;
                entity.konsolturu = comboKonsol.Text;
                entity.kolsayisi =Convert.ToInt32( numericUpDown1.Value);
                entity.islemiyapan = Araclar.kullaniciadi;
                if (!ServisTakipler.Ekle(entity))
                    MessageBox.Show("Servis Eklenemedi");
                else
                {
                    MessageBox.Show("Servis başarıyla eklenmiştir..");
                }
                gridIsci.DataSource = ServisTakipler.Listele();
                #endregion
                
            }
            catch (Exception)
            {

                MessageBox.Show("Hata");
            }
            AktiviteGörevForm akt = new AktiviteGörevForm();
            akt.txtCariKod.Text = txtCariKod.Text;
            akt.txtTicariUnvan.Text = txtUnvan.Text;
            akt.dtGörevBasTarih.Value = dtGiris.Value;
            // hakan tahmini görev süresi
            akt.dtGörevBitis.Value = dtTeslim.Value;
            akt.dtHatirlatma.Value = dtTaahhüt.Value;
            akt.txtServisFormno.Text = formkodu.ToString();
            akt.txtGarantiDurum.Text = comboGarantiDurum.Text;
            akt.txtUrunDetay.Text = comboUrun.Text + comboMarka.Text + comboModel.Text;
            akt.comboIslemDurum.Text = comboIslemDurum.Text;
            akt.comboPersAdi.Text = comboIsiYapan.Text;


            akt.txtCariKod.Enabled = false;
            akt.txtTicariUnvan.Enabled = false;
            akt.dtGörevBasTarih.Enabled = false;
            akt.dtGörevBitis.Enabled = false;
            akt.dtHatirlatma.Enabled = false;
            akt.txtServisFormno.Enabled = false;
            akt.txtGarantiDurum.Enabled = false;
            akt.txtUrunDetay.Enabled = false;
            akt.comboIslemDurum.Enabled = false;
            akt.comboPersAdi.Enabled = false;
            //akt.kayit();
            akt.Show();
            this.Close();

        }

        private void bKaydetKapat_Click(object sender, EventArgs e)
        {
            // Guncelleme işlemi
            ServisTakip guncelleentity = new ServisTakip();
            guncelleentity.formno =formkodu;
            guncelleentity.carikod =cariKodd;
            guncelleentity.cariunvan = txtUnvan.Text;
            guncelleentity.kategori = beKategori.Text;
            guncelleentity.girisbilgisi = dtGiris.Value;
            guncelleentity.onaybilgisi = dtOnay.Value;
            guncelleentity.teslimbilgisi = dtTeslim.Value;

            #region checkKontrol
            if (cOnay.Checked)
            {
                guncelleentity.onaydurum = Convert.ToBoolean(1);
            }
            else
            {
                guncelleentity.onaydurum = Convert.ToBoolean(0);
            }
            if (cTeslim.Checked)
            {
                guncelleentity.teslimdurum = Convert.ToBoolean(1);
            }
            else
            {
                guncelleentity.teslimdurum = Convert.ToBoolean(0);
            }
            if (radioButton1.Checked)
            {
                guncelleentity.onarim = Convert.ToBoolean(1);
            }
            else
            {
                guncelleentity.onarim = Convert.ToBoolean(0);
            }
            if (radioButton2.Checked)
            {
                guncelleentity.hizmet = Convert.ToBoolean(1);
            }
            else
            {
                guncelleentity.hizmet = Convert.ToBoolean(0);
            }
            if (radioButton3.Checked)
            {
                guncelleentity.montaj = Convert.ToBoolean(1);
            }
            else
            {
                guncelleentity.montaj = Convert.ToBoolean(0);
            }

            #endregion
            guncelleentity.uruncinsi = comboUrun.Text;
            guncelleentity.marka = comboMarka.Text;
            guncelleentity.model = comboModel.Text;
            guncelleentity.serino = Convert.ToInt32(comboSeriNo.Text);
            guncelleentity.barkodno = Convert.ToInt32(beBarkod.Text);
            guncelleentity.isiyapan = comboIsiYapan.Text;
            guncelleentity.urunteslimeden = comboUrunTeslimEden.Text;
            guncelleentity.ekippersonel = comboEkipPersonel.Text;
            guncelleentity.islemdurumu = comboIslemDurum.Text;
            guncelleentity.garantidurumu = comboGarantiDurum.Text;
            guncelleentity.probturu = comboProbTur.Text;
            guncelleentity.soru1 = txtSoru1.Text;
            guncelleentity.cevap1 = txtCevap1.Text;
            guncelleentity.soru2 = txtSoru2.Text;
            guncelleentity.cevap2 = txtCevap2.Text;
            guncelleentity.soru3 = txtSoru3.Text;
            guncelleentity.cevap3 = txtCevap3.Text;
            guncelleentity.isletimsistemi = comboIsletim.Text;
            guncelleentity.konsolturu = comboKonsol.Text;
            guncelleentity.kolsayisi = Convert.ToInt32(numericUpDown1.Value);
            guncelleentity.islemiyapan = Araclar.kullaniciadi;
            if (!ServisTakipler.Guncelle(guncelleentity))
                MessageBox.Show("Servis Guncellenemedi");
            else
            {
                MessageBox.Show("Servis başarıyla eklenmiştir..");
            }
        }

        private void cOnay_CheckedChanged(object sender, EventArgs e)
        {
            if (cOnay.Checked)
            {
                dtOnay.Enabled = true;
            }
            else
            {
                dtOnay.Enabled = false;
            }
        }

        private void cTeslim_CheckedChanged(object sender, EventArgs e)
        {

            if (cTeslim.Checked)
            {
                dtTeslim.Enabled = true;
            }
            else
            {
                dtTeslim.Enabled = false;
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            UrunlerForm urn = new UrunlerForm();
            urn.ShowDialog();
        }

        private void beKategori_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            KategorilerForm ktf = new KategorilerForm();
            ktf.ShowDialog();
        }

        private void bGaranti_Click(object sender, EventArgs e)
        {
            GarantiDurumForm gdf = new GarantiDurumForm();
            gdf.ShowDialog();
        }
        
        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iscidoldur();
            
        }

        private void bIslem_Click(object sender, EventArgs e)
        {
            IslemDurumForm idf = new IslemDurumForm();
            idf.ShowDialog();
        }

        private void bEkip_Click(object sender, EventArgs e)
        {
            EkipPersonelForm ekf = new EkipPersonelForm();
            ekf.Show();
        }
        #region SMS gönderme

        System.Windows.Forms.WebBrowser api = new System.Windows.Forms.WebBrowser(); // Api icin WebBrowser olusturuyoruz 


        string num_kont(string num) //yazilan numara Kontrolu 
        {
            if (num.Length != 10)
            {
                string islem = "error"; //Numara hatasi varsa geriye donen deger 
                return islem;

            }
            else
            {
                return num; // Numarada hata yoksa isleme devam 
            }
        }
        string msj_kont(string msj) //Mesaj Karekter SAyisi Kontrol 
        {

            if (msj.Length > 120)
            {
                return msj.Substring(0, 120); // 120 Karakterden fazlaysa geriye 120 . karektere kadar olani donder 

            }
            else
            {
                return msj; //120 karakterden azsa oldugu gibi birak 

            }
        }




        void sms_send(string numara, string mesaj) //Sms Gonderme 
        {


            if (num_kont(numara) == "error")
            {
                MessageBox.Show("Yazılan Numarada Hata Var"); // Numarada hata var 

            }
            else
            {

                string number = num_kont(numara);
                string message = mesaj;
                this.api.Navigate("http://www.s-sms.com/api.asp?num=" + number + "&msj=" + message + "&way=api"); // eger hata yoksa www.s-sms.com un api yoluna gonder 
                //burda dikkat edilmesi gereken numara hatasiz olmali ve basina sifir koyulmadan yazilmali 
                //sms metini ise 120 karekterden fazla olmamali yoksa api bize kapilarini acmaz :) 
            }
        }

            private void bSms_Click(object sender, EventArgs e)
        {
            sms_send(txtCariKod.Text, txtUnvan.Text);   // Sms_send fonksiyonuna numara olarak text1 deki degeri, mesaj olarak text2 deki metini gönder    
        }

        private void api_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) //www.s-sms.com dan donen degerler 
        {
            string durum = api.Document.GetElementById("status").InnerHtml; // islem durumu 

            if (durum == "Num_Hata") //api islemindeki numara hatasi ( siteden donen ) 
            {
                MessageBox.Show("Yazılan Numarada Hata Var SMS Gönderilmedi");

            }
            if (durum == "Mesaj_Gonderildi") // Sorun yoksa donen 
            {
                MessageBox.Show("SMS Gönderildi");
            } 
        
        } 

        #endregion

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            BilgilendirmeForm bgf = new BilgilendirmeForm();
            bgf.ShowDialog();
            
        }

        private void bProb_Click(object sender, EventArgs e)
        {
            ProblemForm prf = new ProblemForm();
            prf.BringToFront();
            prf.ShowDialog();
        }
        
        private void comboProbTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSoru1.Text = null;
            txtSoru2.Text = null;
            txtSoru3.Text = null;
            SqlCommand kmt = new SqlCommand();
            SqlDataReader rdr;
            kmt.Connection = baglanti;
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            kmt.CommandText = "Select  Soru1,Soru2,Soru3  from Problemler where ProblemTuru like '%"+comboProbTur.Text +"%'";
            rdr = kmt.ExecuteReader();
            while (rdr.Read())
            {
                txtSoru1.Text=rdr["Soru1"].ToString();
                txtSoru2.Text=rdr["Soru2"].ToString();
                txtSoru3.Text=rdr["Soru3"].ToString();
            }
            rdr.Close();
            baglanti.Close();
           
                //SqlDataAdapter cs = new SqlDataAdapter("Select * from Problemler where id like '" + comboProbTur.Text + "%'", baglanti);
                //DataSet asd = new DataSet();
                //cs.Fill(asd);

                //#region ProblemCombosunu doldurma
                //foreach (DataRow dr6 in asd.Tables[0].Rows)
                //{
                //    //richTextBox1.Text = dr6["id"].ToString();
                //    txtSoru1.Text = dr6["Soru1"].ToString();
                //    txtSoru2.Text = dr6["Soru2"].ToString();
                //    txtSoru3.Text = dr6["Soru3"].ToString();
                //}



                //#endregion
            
            
        }

        private void bGorev_Click(object sender, EventArgs e)
        {
            AktiviteGörevForm agf = new AktiviteGörevForm();
            agf.BringToFront();
            agf.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            IscilikForm igf = new IscilikForm();
            igf.txtcarikodd.Text = txtCariKod.Text; ;
            igf.BringToFront();
            igf.Show();
        }
        
        private void bYazdir_Click(object sender, EventArgs e)
        {
            AnaForm anf = new AnaForm();
            XtraReport1 xtrp = new XtraReport1();
            xtrp.xrFormKodu1.Text = beFormNo.Text;
            xtrp.xrTarih1.Text = DateTime.Now.ToShortDateString();
            xtrp.xrCariUnvan1.Text = txtUnvan.Text;
            //xtrp.xrKod.Text=
            xtrp.xrYetkili1.Text = txtUnvan.Text;
            xtrp.xrTel1.Text = tel;
            xtrp.xrSehir1.Text = "SAKARYA";
            xtrp.xrCins1.Text= comboUrun.Text;
           xtrp.xrMarka1.Text = comboMarka.Text;
           xtrp.xrModel1.Text = comboModel.Text;
           xtrp.xrSeriNo1.Text = comboSeriNo.Text;
           xtrp.xrBarkod1.Text = beBarkod.Text;
           xtrp.xrSikayet1.Text = comboProbTur.Text;


           xtrp.xrFormKodu2.Text = beFormNo.Text;
           xtrp.xrTarih2.Text = DateTime.Now.ToShortDateString();
           xtrp.xrCariUnvan2.Text = txtUnvan.Text;
          // xtrp.xrKod.Text = GenerateNewPassword(8);
           xtrp.xrYetkili2.Text = txtUnvan.Text;
           xtrp.xrTel2.Text = tel;
           xtrp.xrSehir2.Text = "SAKARYA";
           xtrp.xrCins2.Text = comboUrun.Text;
           xtrp.xrMarka2.Text = comboMarka.Text;
           xtrp.xrModel2.Text = comboModel.Text;
           xtrp.xrSeriNo2.Text = comboSeriNo.Text;
           xtrp.xrBarkod2.Text = beBarkod.Text;
           xtrp.xrSikayet2.Text = comboProbTur.Text;
           xtrp.xrSoru1.Text = txtSoru1.Text;
           xtrp.xrSoru2.Text = txtSoru2.Text;
           xtrp.xrSoru3.Text = txtSoru3.Text;
           xtrp.xrCevap1.Text = txtCevap1.Text;
           xtrp.xrCevap2.Text = txtCevap2.Text;
           xtrp.xrCevap3.Text = txtCevap3.Text;

            xtrp.ShowPreview();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            iscidoldur();
        }

        

    }
}

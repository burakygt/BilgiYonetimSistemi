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
using System.Data.SqlClient;
using System.Configuration;

namespace BilgiYönetimSistemi.WinForm
{
    public partial class AnaForm : Form
    {
        private int childFormNumber = 0;
        public static SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["BYS_baglanti"].ConnectionString);
        public static string carikod, formno, sorgu1;
        SqlCommand verial = new SqlCommand();
        DataTable verilerial = new DataTable();
        public AnaForm()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void barListItem1_ListItemClick(object sender, DevExpress.XtraBars.ListItemClickEventArgs e)
        {

        }
        DataSet ds = Sorgular.AnaFormGridDoldurma();
        private void AnaForm_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = Araclar.kullaniciadi;
            gridControl1.DataSource = ds.Tables[0];
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MusteriDetayForm mdf = new MusteriDetayForm();
            mdf.MdiParent = this;
            mdf.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ServisTakipFormu stf = new ServisTakipFormu();
            stf.MdiParent = this;
            stf.Show();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //   

            SqlDataAdapter csa = new SqlDataAdapter("Select id SID,formNo FORMNO,carikod CARIK,cariunvan CARIUNV, kategori SKATEGORI,onayDurum SONAYDURUM,onayBilgisi SONAYBILGISI,teslimDurum STESLIMDURUM,barkodno SBARKODNO,isiYapan SISIYAPAN,urunTeslimEden SURUNTESLIMEDEN,probTuru SPROBLEM,soru1 SSORU1,cevap1 SCEVAP1,soru2 SSORU2,cevap2 SCEVAP2,soru3 SSORU3,cevap3 SCEVAP3, isletimsistemi SISLETIMSISTEMI,konsolturu SKONSOLTURU,kolsayisi SKOLSAYISI,serino SERINO,garantiDurumu GARANTIDURUM,islemDurumu ISLEMDURUM,(urunCinsi  + ' ' + marka  + ' ' + model ) as URUNDETAY ,girisBilgisi GIRISBILGISI,teslimBilgisi CIKISBILGISI,ekipPersonel EKIPPERSONEL from ServisTakip where carikod like '%" + gridView1.GetFocusedRowCellValue(col_carikod) + "%' and islemiYapan = '" + Araclar.kullaniciadi + "'", baglanti);
            DataSet asda = new DataSet();
            csa.Fill(asda);
            gridControl2.DataSource = asda.Tables[0];

            SqlDataAdapter csaa = new SqlDataAdapter("Select id AID,GörevKodu AGOREVKODU,GörevStatusu ASTATU, Kategoriler AKATEGORI,GörevBaslamaSaati AGOREVBASSAAT,TahminiGörevSüresiSaat ATAHGORSUSAAT,TahminiGörevSüresiDakika ATAHGORSUDAKIKA, GörevBitisDurum AGORBITDUR, GörevBitisSaati AGORBITSAAT,HatirlatmaDurum AHATIRDUR,HatirlatmaTarih AHATIRTARIH,HatirlatmaSaati AHATIRSAAT,ServisFormNo ASERFORMNO,UrunDetayi AURUNDETAY, GarantiDurumu AGARDUR,GörevGüzergahi AGORGUZ,GörevKonusu AGORKONU,Problem APROB, PersonelNotu APERNOT,GörevBaslamaTarihi ABASTARIH,GörevBitisTarihi ABITTARIH, PersonelAdi AEKIPPERSONEL, IslemDurumu AISLEMDURUM,CariKod ACARIKOD,TicariUnvan ACARIUNVAN from AktiviteGörev where CariKod like '%" + gridView1.GetFocusedRowCellValue(col_carikod) + "%'", baglanti);
            DataSet asdaa = new DataSet();
            csaa.Fill(asdaa);
            gridControl3.DataSource = asdaa.Tables[0];

        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            //carikod değişkenini burdan kaldırıp genel tanımladım 
            Araclar.müsteriId = gridView1.GetFocusedRowCellValue(col_id).ToString();
            carikod = gridView1.GetFocusedRowCellValue(col_carikod).ToString();
            MusteriDetayForm mdf = new MusteriDetayForm();
            mdf.txtcarikod.Text = "MU" + carikod.ToString();
            mdf.txtcariunvan.Text = gridView1.GetFocusedRowCellValue(col_cariunvan).ToString();
            mdf.MdiParent = this;
            mdf.Show();

        }
        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            ServisTakipFormu stf = new ServisTakipFormu();
            //Araclar.servisId = gridView2.GetFocusedRowCellValue("");
            stf.comboIsletim.Enabled = true;
            stf.comboKonsol.Enabled = true;
            stf.numericUpDown1.Enabled = true;
            stf.comboIsletim.Items.Clear();
            stf.comboIsletim.Text = null;
            stf.comboKonsol.Items.Clear();
            stf.comboKonsol.Text = null;
            stf.numericUpDown1.Value = 0;

            formno = gridView2.GetFocusedRowCellValue(col_FormNo).ToString();//yeni eklenen kod_hakan
            carikod = gridView2.GetFocusedRowCellValue(col_carik).ToString();

            stf.beFormNo.Text = "AS" + formno.ToString();
            stf.txtCariKod.Text = "MU" + carikod.ToString();
            stf.txtUnvan.Text = gridView2.GetFocusedRowCellValue(col_cariunv).ToString();
            stf.beKategori.Text = gridView2.GetFocusedRowCellValue(col_SKategori).ToString();
            stf.dtGiris.Value = Convert.ToDateTime(gridView2.GetFocusedRowCellValue(col_girisBilgisi));
            //stf.cOnay.
            stf.dtOnay.Value = Convert.ToDateTime(gridView2.GetFocusedRowCellValue(col_SonayBilgisi));
            //stf.cTeslim
            stf.dtTeslim.Value = Convert.ToDateTime(gridView2.GetFocusedRowCellValue(col_cikisBilgisi));
            //stf.comboUrun.Text = gridView2.GetFocusedRowCellValue().ToString();
            //stf.comboMarka.Text = gridView2.GetFocusedRowCellValue().ToString();
            //stf.comboModel.Text = gridView2.GetFocusedRowCellValue().ToString();
            stf.comboSeriNo.Text = gridView2.GetFocusedRowCellValue(col_serino).ToString();
            stf.comboIslemDurum.Text = gridView2.GetFocusedRowCellValue(col_islemdurum).ToString();
            stf.comboGarantiDurum.Text = gridView2.GetFocusedRowCellValue(col_garantidurum).ToString();
            stf.beBarkod.Text = gridView2.GetFocusedRowCellValue(col_SBarkodNo).ToString();
            stf.comboIsiYapan.Text = gridView2.GetFocusedRowCellValue(col_SisiYapan).ToString();
            stf.comboUrunTeslimEden.Text = gridView2.GetFocusedRowCellValue(col_SurunTesEden).ToString();
            stf.comboProbTur.Text = gridView2.GetFocusedRowCellValue(col_SProblem).ToString();
            stf.txtSoru1.Text = gridView2.GetFocusedRowCellValue(col_SSoru1).ToString();
            stf.txtSoru2.Text = gridView2.GetFocusedRowCellValue(col_SSoru2).ToString();
            stf.txtSoru3.Text = gridView2.GetFocusedRowCellValue(col_SSoru3).ToString();
            stf.txtCevap1.Text = gridView2.GetFocusedRowCellValue(col_SCevap1).ToString();
            stf.txtCevap2.Text = gridView2.GetFocusedRowCellValue(col_SCevap2).ToString();
            stf.txtCevap3.Text = gridView2.GetFocusedRowCellValue(col_SCevap3).ToString();
            stf.comboIsletim.Text = gridView2.GetFocusedRowCellValue(col_SisletSis).ToString();
            stf.comboKonsol.Text = gridView2.GetFocusedRowCellValue(col_SKonsTuru).ToString();
            //stf.numericUpDown1.Value =Convert.ToDecimal( gridView2.GetFocusedRowCellValue(col_SKolSayisi).ToString());


            stf.MdiParent = this;
            stf.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AktiviteGörevForm agf = new AktiviteGörevForm();
            agf.MdiParent = this;
            agf.Show();
        }



        private void servisFormuOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {

            carikod = (gridView1.GetFocusedRowCellValue(col_carikod).ToString());
            ServisTakipFormu stf = new ServisTakipFormu();
            stf.txtCariKod.Text = "MU" + carikod.ToString();
            stf.txtUnvan.Text = gridView1.GetFocusedRowCellValue(col_cariunvan).ToString();
            stf.MdiParent = this;
            stf.Show();
        }

        private void aktiviteVeGörevAtaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AktiviteGörevForm agf = new AktiviteGörevForm();
            agf.txtCariKod.Text = gridView2.GetFocusedRowCellValue(col_carik).ToString();
            agf.txtTicariUnvan.Text = gridView2.GetFocusedRowCellValue(col_cariunv).ToString();
            agf.txtTel1.Text = gridView1.GetFocusedRowCellValue(col_tel1).ToString();
            agf.txtUrunDetay.Text = gridView2.GetFocusedRowCellValue(col_urundetay).ToString();
            agf.txtServisFormno.Text = gridView2.GetFocusedRowCellValue(col_FormNo).ToString();
            agf.txtGarantiDurum.Text = gridView2.GetFocusedRowCellValue(col_garantidurum).ToString();
            agf.comboIslemDurum.Text = gridView2.GetFocusedRowCellValue(col_islemdurum).ToString();
            agf.comboPersAdi.Text = gridView2.GetFocusedRowCellValue(col_ekipPersonel).ToString();
            AktiviteGörevForm.hatirlat =Convert.ToInt32( gridView3.GetFocusedRowCellValue(col_AHatirDur));
            agf.MdiParent = this;
            agf.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Raporlar rpr = new Raporlar();
            rpr.MdiParent = this;
            rpr.Show();
            rpr.Visible = false;
            YönetimForm ynt = new YönetimForm();
            ynt.BringToFront();
            ynt.Show();

        }

        private void gridView3_DoubleClick(object sender, EventArgs e)
        {
            AktiviteGörevForm akt = new AktiviteGörevForm();
            Araclar.aktiviteId = gridView3.GetFocusedRowCellValue(col_AId).ToString();
            akt.txtGorevKodu.Text = gridView3.GetFocusedRowCellValue(col_AGorevKodu).ToString();
            akt.comboGörevStatüsü.Text = gridView3.GetFocusedRowCellValue(col_Statu).ToString();
            akt.beKategoriler.Text = gridView3.GetFocusedRowCellValue(col_AKategoriler).ToString();
            akt.dtGörevBasTarih.Value = Convert.ToDateTime(gridView3.GetFocusedRowCellValue(col_ABasTarihi));
            //akt.maskedTextBox1.Text = gridView3.GetFocusedRowCellValue(col_AGorBasSaat).ToString();
            akt.nudSaat.Value = Convert.ToDecimal(gridView3.GetFocusedRowCellValue(col_ATarGorSuSaat));
            akt.nudDakika.Value = Convert.ToDecimal(gridView3.GetFocusedRowCellValue(col_ATahGorSuDakika));
            //akt.cGörevBitis
            akt.dtGörevBitis.Value = Convert.ToDateTime(gridView3.GetFocusedRowCellValue(col_ABitTarih));
            akt.teGörBitisTarih.Text = gridView3.GetFocusedRowCellValue(col_AGorBitSaat).ToString();
            //akt.cHatirlatma
            akt.dtHatirlatma.Value = Convert.ToDateTime(gridView3.GetFocusedRowCellValue(col_AHatirTarih));
            akt.teHatirlatma.Text = gridView3.GetFocusedRowCellValue(col_AHatirSaat).ToString();
            akt.txtCariKod.Text = gridView3.GetFocusedRowCellValue(col_ACariKod).ToString();
            akt.txtTicariUnvan.Text = gridView3.GetFocusedRowCellValue(col_ACariUnvan).ToString();
            akt.txtServisFormno.Text = gridView3.GetFocusedRowCellValue(col_ASerFormNo).ToString();
            //akt.txtUrunDetay.Text = gridView3.GetFocusedRowCellValue(col_urundetay).ToString();
            akt.comboIslemDurum.Text = gridView3.GetFocusedRowCellValue(col_AIslemDurum).ToString();
            akt.txtGarantiDurum.Text = gridView3.GetFocusedRowCellValue(col_AGarDur).ToString();
            akt.comboPersAdi.Text = gridView3.GetFocusedRowCellValue(col_AEkipPersonel).ToString();
            akt.comboGüzergah.Text = gridView3.GetFocusedRowCellValue(col_AGorGuz).ToString();
            akt.txtProblem.Text = gridView3.GetFocusedRowCellValue(col_AProb).ToString();
            akt.txtPersNotu.Text = gridView3.GetFocusedRowCellValue(col_APersNot).ToString();

            akt.MdiParent = this;
            akt.Show();
        }

        private void AnaForm_Shown(object sender, EventArgs e)
        {
            Hatirlatma hatir = new Hatirlatma();
            //DateTime myDateTime = DateTime.Now;
            //string sqlFormattedDate = myDateTime.Date.ToString("yyyy-MM-dd HH:mm:ss");

            SqlDataAdapter da = new SqlDataAdapter("select görevkodu,görevbaslamatarihi,görevbitistarihi,hatirlatmasaati,servisformno,problem,personelnotu from AktiviteGörev where HatirlatmaTarih = '" + DateTime.Today.ToString("yyyy-MM-dd") + "' and islemiYapan='" + Araclar.kullaniciadi + "' and hatirlatmadurum=1 order by hatirlatmasaati desc ", baglanti);


            da.Fill(verilerial);
            if(verilerial.Rows.Count>0)
            {
                MessageBox.Show("Bugün tarihli hatırlatmalarınız var !", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                hatir.Show();
            }
            else
            {
                MessageBox.Show("Bugün tarihli hatırlatmanız bulunmamaktadır", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
    }
        
    }
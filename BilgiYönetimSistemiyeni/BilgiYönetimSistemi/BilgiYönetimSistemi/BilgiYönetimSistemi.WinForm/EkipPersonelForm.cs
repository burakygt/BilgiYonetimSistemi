using DevExpress.Data.Mask;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.Utils.Animation;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using BilgiYönetimSistemi.ORM;
using BilgiYönetimSistemi.ORM.Entity;
using BilgiYönetimSistemi.ORM.Facade;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace BilgiYönetimSistemi.WinForm
{
    public partial class EkipPersonelForm : Form
    {
        public EkipPersonelForm()
        {
            InitializeComponent();
        }
        public static SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["BYS_baglanti"].ConnectionString);
        int calis;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EkipPersonel entity = new EkipPersonel();
            entity.adsoyad = txtAdSoyad.Text;
            entity.tel = Convert.ToDecimal(txtTel.Text);
            entity.statu = txtStatu.Text;
            entity.birim = comboBirim.Text;
            entity.calisiyor = calis;
            if (!EkipPersoneller.Ekle(entity))
            {
                MessageBox.Show("Personel Eklenemedi");
            }
            gridControl1.DataSource = EkipPersoneller.Listele();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EkipPersonel guncelle = new EkipPersonel();
            guncelle.id = (int)gridView1.GetFocusedRowCellValue("id");
            guncelle.adsoyad = txtAdSoyad.Text;
            guncelle.tel = Convert.ToDecimal(txtTel.Text);
            guncelle.statu = txtStatu.Text;
            guncelle.birim = comboBirim.Text;
            guncelle.calisiyor = calis;

            if (!EkipPersoneller.Guncelle(guncelle))
            {
                MessageBox.Show("Personel Guncellenemedi.");
            }
            gridControl1.DataSource = EkipPersoneller.Listele();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Data.DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            EkipPersonel silincek = new EkipPersonel();
            silincek.id = (int)gridView1.GetFocusedRowCellValue("id");

            if (!EkipPersoneller.Sil(silincek))
                MessageBox.Show("Silinemedi");
            gridControl1.DataSource = EkipPersoneller.Listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            if (view.RowCount == 0)
                MessageBox.Show("Gridview Boş");
            return;

            txtAdSoyad.Text = gridView1.GetFocusedRowCellValue("AdiSoyadi").ToString();
            txtTel.Text = gridView1.GetFocusedRowCellValue("Tel").ToString();
            txtStatu.Text = gridView1.GetFocusedRowCellValue("Statu").ToString();
            comboBirim.Text = gridView1.GetFocusedRowCellValue("Birim").ToString();

        }

        private void gridView1_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            if (view.RowCount != 0) return;

            StringFormat drawFormat = new StringFormat();

            drawFormat.Alignment = drawFormat.LineAlignment = StringAlignment.Center;

            e.Graphics.DrawString("Herhangi bir veri bulunmamaktadır.", e.Appearance.Font, SystemBrushes.ControlDark, new RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height), drawFormat);

        }

        private void EkipPersonelForm_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = EkipPersoneller.Listele();
            toggleSwitch1.Properties.OffText = "Çalışmıyor";
            toggleSwitch1.Properties.OnText = "Çalışıyor";
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                iTextSharp.text.Document raporum = new iTextSharp.text.Document();

                // PDF oluşturması ve konumun belirlenmesi

                PdfWriter.GetInstance(raporum, new FileStream("C:\\Raporum.pdf", FileMode.Create));

                //PDF yi yazan özelliğine eklenecek

                raporum.AddAuthor(txtAdSoyad.Text); // PDF Oluşturma Tarihi Ekle

                raporum.AddCreationDate(); // PDF Oluşturma Tarihi

                // PDF oluşturan kişi özelliğine yazılacak

                raporum.AddCreator(txtStatu.Text);

                if (raporum.IsOpen() == false)
                {

                    raporum.Open();

                }

                raporum.Add(new Paragraph(txtTel.Text));

                raporum.Close();
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

        private void EkipPersonelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                ServisTakipFormu stf = new ServisTakipFormu();
                
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            ToggleSwitch toggleSwitch = sender as ToggleSwitch;
            if (toggleSwitch != null)
            {
                if (toggleSwitch.IsOn == true)
                {
                    calis = 1;
                }
                else
                {
                    calis = 0;
                }
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BilgiYönetimSistemi.ORM;
using BilgiYönetimSistemi.ORM.Entity;
using BilgiYönetimSistemi.ORM.Facade;

namespace BilgiYönetimSistemi.WinForm
{
    public partial class IscilikTanimlariForm : Form
    {
        public static SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["BYS_baglanti"].ConnectionString);

        public IscilikTanimlariForm()
        {
            InitializeComponent();
        }
        private void IscilikTanimlariForm_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = IscilikTanimlar.Listele();
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IscilikTanim entity = new IscilikTanim();
            entity.hizmetbilgisi = txtHizmetBilgis.Text;
            entity.ucret = Convert.ToDecimal(txtUcret.Text);
            entity.kdv = Convert.ToDecimal(txtKdv.Text);
            entity.notlar = textEdit4.Text;

            if (!IscilikTanimlar.Ekle(entity))
            {
                MessageBox.Show("İşçilik Eklenemedi..");
            }
            gridControl1.DataSource = IscilikTanimlar.Listele();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IscilikTanim guncelle = new IscilikTanim();
            guncelle.id = (int)gridView1.GetFocusedRowCellValue("id");
            guncelle.hizmetbilgisi = txtHizmetBilgis.Text;
            guncelle.ucret = Convert.ToDecimal(txtUcret.Text);
            guncelle.kdv = Convert.ToDecimal(txtKdv.Text);
            guncelle.notlar = textEdit4.Text;
            if (!IscilikTanimlar.Guncelle(guncelle))
            {
                MessageBox.Show("Guncelleme başarısız");
            }
            gridControl1.DataSource = IscilikTanimlar.Listele();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Data.DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            IscilikTanim silincek = new IscilikTanim();
            silincek.id = (int)row["id"];

            if (!IscilikTanimlar.Sil(silincek))
                MessageBox.Show("Silinemedi");
            gridControl1.DataSource = IscilikTanimlar.Listele();
        }

        private void gridView1_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            if (view.RowCount != 0) return;

            StringFormat drawFormat = new StringFormat();

            drawFormat.Alignment = drawFormat.LineAlignment = StringAlignment.Center;

            e.Graphics.DrawString("Herhangi bir veri bulunmamaktadır.", e.Appearance.Font, SystemBrushes.ControlDark, new RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height), drawFormat);

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            if (view.RowCount == 0)
                MessageBox.Show("Gridview Boş");
            return;
            txtHizmetBilgis.Text = gridView1.GetFocusedRowCellValue("HizmetBilgisi").ToString();
            txtKdv.Text = gridView1.GetFocusedRowCellValue("KDV").ToString();
            txtUcret.Text = gridView1.GetFocusedRowCellValue("Ucret").ToString();
            textEdit4.Text = gridView1.GetFocusedRowCellValue("Notlar").ToString();
        }

       
    }
}

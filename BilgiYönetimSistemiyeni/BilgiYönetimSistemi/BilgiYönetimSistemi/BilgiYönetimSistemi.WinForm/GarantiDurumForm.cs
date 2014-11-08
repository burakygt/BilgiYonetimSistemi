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
    public partial class GarantiDurumForm : Form
    {
        public GarantiDurumForm()
        {
            InitializeComponent();
        }
        public static SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["BYS_baglanti"].ConnectionString);

        private void GarantiDurumForm_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = GarantiDurumlar.Listele();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GarantiDurum entity = new GarantiDurum();
            entity.garantiadi = textEdit1.Text;
            if (!GarantiDurumlar.Ekle(entity))
            {
                MessageBox.Show("Garanti Durumu Eklenemedi");
            }
            gridControl1.DataSource = GarantiDurumlar.Listele();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GarantiDurum guncelle = new GarantiDurum();
            guncelle.id = (int)gridView1.GetFocusedRowCellValue("id");
            guncelle.garantiadi = textEdit1.Text;
            if (!GarantiDurumlar.Guncelle(guncelle))
            {
                MessageBox.Show("Garanti Durumu Guncellenemedi..");
            }
            gridControl1.DataSource = GarantiDurumlar.Listele();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Data.DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            GarantiDurum silincek = new GarantiDurum();
            silincek.id = (int)row["id"];

            if (!GarantiDurumlar.Sil(silincek))
                MessageBox.Show("Silinemedi");
            gridControl1.DataSource = GarantiDurumlar.Listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            if (view.RowCount == 0)
                MessageBox.Show("Gridview Boş");
            return;
            textEdit1.Text = gridView1.GetFocusedRowCellValue("GarantiDurumAdi").ToString();
        }

        private void gridView1_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            if (view.RowCount != 0) return;

            StringFormat drawFormat = new StringFormat();

            drawFormat.Alignment = drawFormat.LineAlignment = StringAlignment.Center;

            e.Graphics.DrawString("Herhangi bir veri bulunmamaktadır.", e.Appearance.Font, SystemBrushes.ControlDark, new RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height), drawFormat);

        }
    }
}

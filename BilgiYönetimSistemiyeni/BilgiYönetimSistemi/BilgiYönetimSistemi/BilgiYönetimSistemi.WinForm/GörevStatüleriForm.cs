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
using BilgiYönetimSistemi.ORM.Entity;
using BilgiYönetimSistemi.ORM.Facade;

namespace BilgiYönetimSistemi.WinForm
{
    public partial class GörevStatüleriForm : Form
    {
        public static SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["BYS_baglanti"].ConnectionString);

        public GörevStatüleriForm()
        {
            InitializeComponent();
        }

        private void GörevStatüleriForm_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = GörevStatuler.Listele();

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GörevStatu entity = new GörevStatu();
            entity.görevstatuadi = textEdit1.Text;
            if (!GörevStatuler.Ekle(entity) )
            {
                MessageBox.Show("Görev Statüsü Eklenemedi");
            }
            gridControl1.DataSource = GörevStatuler.Listele();

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GörevStatu guncelle = new GörevStatu();
            guncelle.id = (int)gridView1.GetFocusedRowCellValue("id");
            guncelle.görevstatuadi = textEdit1.Text;
            if (!GörevStatuler.Guncelle(guncelle))
            {
                MessageBox.Show("Görev Statü Güncellenemedi");
            }
            gridControl1.DataSource = GörevStatuler.Listele();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Data.DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            GörevStatu silincek = new GörevStatu();
            silincek.id = (int)row["id"];

            if (!GörevStatuler.Sil(silincek))
                MessageBox.Show("Silinemedi");
            gridControl1.DataSource = GörevStatuler.Listele();
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
            textEdit1.Text = gridView1.GetFocusedRowCellValue("GörevStatuAdi").ToString();
        }
    }
}

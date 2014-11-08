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
    public partial class GruplarForm : Form
    {
        public static SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["BYS_baglanti"].ConnectionString);


        public GruplarForm()
        {
            InitializeComponent();
        }

        private void Gruplar_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = Gruplar.Listele();

        }


        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Grup entity = new Grup();
            entity.grupadi = textEdit1.Text;

            if (!Gruplar.Ekle(entity))
            {
                MessageBox.Show("Grup Eklenemedi");
            }
            gridControl1.DataSource = Gruplar.Listele();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Grup guncelle = new Grup();
            guncelle.id = (int)gridView1.GetFocusedRowCellValue("id");
            guncelle.grupadi = textEdit1.Text;

            if (!Gruplar.Guncelle(guncelle))
            {
                MessageBox.Show("Guncelleme başarısız");
            }
            gridControl1.DataSource = Gruplar.Listele();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Data.DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            Grup silincek = new Grup();
            silincek.id = (int)row["id"];

            if (!Gruplar.Sil(silincek))
                MessageBox.Show("Silinemedi");
            gridControl1.DataSource = Gruplar.Listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            MusteriDetayForm mdf = (MusteriDetayForm)Application.OpenForms["MusteriDetayForm"];
            mdf.beGrup.Text = gridView1.GetFocusedRowCellValue("grupadi").ToString();
            mdf.BringToFront();
            this.Hide();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
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
            textEdit1.Text = gridView1.GetFocusedRowCellValue("grupadi").ToString();
        }

        
    }
}

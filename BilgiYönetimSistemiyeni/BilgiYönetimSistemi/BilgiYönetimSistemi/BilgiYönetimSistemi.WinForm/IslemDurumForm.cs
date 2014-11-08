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

namespace BilgiYönetimSistemi.WinForm
{
    public partial class IslemDurumForm : Form
    {
        public IslemDurumForm()
        {
            InitializeComponent();
        }
        
        public static SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["BYS_baglanti"].ConnectionString);

        private void colorPickEdit1_ColorChanged(object sender, EventArgs e)
        {
            //textEdit1.Text = colorPickEdit1.Text;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IslemDurum entity = new IslemDurum();
            entity.islemdurumadi = textEdit1.Text;
            entity.renk = colorPickEdit1.Text;

            if (!IslemDurumlar.Ekle(entity))
            {
                MessageBox.Show("İslem Eklenemedi");
            }
            //else
            //{
            //    MessageBox.Show("İslem başarıyla eklendi.");
            //}
            gridControl1.DataSource = Sorgular.IslemSorgu();

            //gridControl1.DataSource = IslemDurumlar.Listele();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IslemDurum guncelle = new IslemDurum();
            guncelle.id = (int)gridView1.GetFocusedRowCellValue(col_id);
            guncelle.islemdurumadi = textEdit1.Text;
            guncelle.renk = colorPickEdit1.Text;

            if (!IslemDurumlar.Guncelle(guncelle))
            {
                MessageBox.Show("Guncelleme başarısız");
            }
            //else
            //{
            //    MessageBox.Show("Guncelleme başarılı");
            //}
           gridControl1.DataSource = Sorgular.IslemSorgu();

            //gridControl1.DataSource = IslemDurumlar.Listele();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Data.DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            IslemDurum silincek = new IslemDurum();
            silincek.id = (int)gridView1.GetFocusedRowCellValue(col_id);

            if (!IslemDurumlar.Sil(silincek))
                MessageBox.Show("Silinemedi");
            gridControl1.DataSource = Sorgular.IslemSorgu();

            //gridControl1.DataSource = IslemDurumlar.Listele();
        }

        private void IslemDurumForm_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = Sorgular.IslemSorgu();
            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            if (view.RowCount == 0)
               MessageBox.Show("Gridview Boş");
                return;
            textEdit1.Text = gridView1.GetFocusedRowCellValue(col_iDurum).ToString();
            colorPickEdit1.Text = gridView1.GetFocusedRowCellValue(col_renk).ToString();
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

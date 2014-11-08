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

namespace BilgiYönetimSistemi.WinForm
{
    public partial class UrunlerForm : Form
    {
        public UrunlerForm()
        {
            InitializeComponent();
        }
        public static SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["BYS_baglanti"].ConnectionString);

        private void UrunlerForm_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = Sorgular.UrunSelect();
            
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Urun entity = new Urun();
            entity.uruncinsi = txtUrunCinsi.Text;
            entity.marka = txtMarka.Text;
            entity.model = txtModel.Text;
            if (!Urunler.Ekle(entity))
                MessageBox.Show("Urun Eklenemedi");
            gridControl1.DataSource = Sorgular.UrunSelect();

        }


        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Urun guncelle = new Urun();
            guncelle.id = Convert.ToInt32(gridView1.GetFocusedRowCellValue(col_id));
            guncelle.uruncinsi = txtUrunCinsi.Text;
            guncelle.marka = txtMarka.Text;
            guncelle.model = txtModel.Text;
            if (!Urunler.Guncelle(guncelle))
            {
                MessageBox.Show("Urun Guncelleme başarısız");
            }
            else
            {
                
            }
            gridControl1.DataSource = Sorgular.UrunSelect();

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Data.DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            Urun silincek = new Urun();
            silincek.id = (int)(gridView1.GetFocusedRowCellValue(col_id));

            if (!Urunler.Sil(silincek))
                MessageBox.Show("Silinemedi");
            gridControl1.DataSource = Sorgular.UrunSelect();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            if (view.RowCount == 0)
                MessageBox.Show("Gridview Boş");
            return;
            txtUrunCinsi.Text = gridView1.GetFocusedRowCellValue(col_UrunCinsi).ToString();
            txtMarka.Text = gridView1.GetFocusedRowCellValue(col_Marka).ToString();
            txtModel.Text = gridView1.GetFocusedRowCellValue(col_Model).ToString();
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

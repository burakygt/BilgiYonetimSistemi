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
    public partial class ProblemForm : Form
    {
        public static SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["BYS_baglanti"].ConnectionString);

        public ProblemForm()
        {
            InitializeComponent();
        }

        private void ProblemForm_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource=Problemler.Listele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Problem entity = new Problem();
            entity.probTuru = txtprobturu.Text;
            entity.cihazTuru = combocihazturu.Text;
            entity.soru1 = txtsoru1.Text;
            entity.soru2 = txtsoru2.Text;
            entity.soru3 = txtsoru3.Text;
            if (!Problemler.Ekle(entity))
            {
                MessageBox.Show("Problem Eklenemedi");
            }
            gridControl1.DataSource = Problemler.Listele();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Problem guncelle = new Problem();
            guncelle.id = (int)gridView1.GetFocusedRowCellValue("id");
            guncelle.probTuru = txtprobturu.Text;
            guncelle.cihazTuru = combocihazturu.Text;
            guncelle.soru1 = txtsoru1.Text;
            guncelle.soru2 = txtsoru2.Text;
            guncelle.soru3 = txtsoru3.Text;
            if (!Problemler.Guncelle(guncelle))
            {
                MessageBox.Show("Problem Guncellenemedi.");
            }
            gridControl1.DataSource = Problemler.Listele();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            System.Data.DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            Problem silincek = new Problem();
            silincek.id = (int)row["id"];

            if (!Problemler.Sil(silincek))
                MessageBox.Show("Silinemedi");
            gridControl1.DataSource = Problemler.Listele();

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
            txtprobturu.Text = gridView1.GetFocusedRowCellValue("ProblemTuru").ToString();
            combocihazturu.Text = gridView1.GetFocusedRowCellValue("CihazTuru").ToString();
            txtsoru1.Text = gridView1.GetFocusedRowCellValue("Soru1").ToString();
            txtsoru2.Text = gridView1.GetFocusedRowCellValue("Soru2").ToString();

            txtsoru3.Text = gridView1.GetFocusedRowCellValue("Soru3").ToString();

        }
    }
}

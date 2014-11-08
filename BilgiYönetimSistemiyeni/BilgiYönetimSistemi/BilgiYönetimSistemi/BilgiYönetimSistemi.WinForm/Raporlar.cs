using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Layout;
using DevExpress.XtraGrid.Views.Layout.ViewInfo;
using DevExpress.XtraLayout;

namespace BilgiYönetimSistemi.WinForm
{
    public partial class Raporlar : Form
    {
        private ChartControl chart;
        private Dictionary<int, Bitmap> unboundData = new Dictionary<int, Bitmap>();
        public Raporlar()
        {
            InitializeComponent();
            //InitializeChart();
        }

        private void Raporlar_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
            //this.productsTableAdapter.Fill(this.nwindDataSet.Products);
            //// TODO: This line of code loads data into the 'nwindDataSet.Categories' table. You can move, or remove it, as needed.
            //this.categoriesTableAdapter.Fill(this.nwindDataSet.Categories);
        }
        //private void InitializeChart()
        //{
        //    chart = new ChartControl();
        //    Series series1 = new Series("series1", ViewType.Bar);
        //    series1.ArgumentDataMember = "ProductName";
        //    series1.ValueDataMembers.AddRange(new string[] { "UnitPrice" });
        //    series1.ShowInLegend = false;
        //    Series series2 = new Series("series2", ViewType.Point);
        //    series2.ArgumentDataMember = "ProductName";
        //    series2.ValueDataMembers.AddRange(new string[] { "UnitPrice" });
        //    series2.ShowInLegend = false;
        //    series2.Label.Visible = false;
        //    chart.Series.AddRange(new Series[] { series1, series2 });
        //    ((XYDiagram)chart.Diagram).AxisX.Label.Angle = 20;
        //}
    }
}

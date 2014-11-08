using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using System.Threading;

namespace BilgiYönetimSistemi.WinForm
{
    public partial class BilgilendirmeForm : Form
    {
        public BilgilendirmeForm()
        {
            InitializeComponent();
        }

        private void BilgilendirmeForm_Load(object sender, EventArgs e)
        {
            Thread.Sleep(9000);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

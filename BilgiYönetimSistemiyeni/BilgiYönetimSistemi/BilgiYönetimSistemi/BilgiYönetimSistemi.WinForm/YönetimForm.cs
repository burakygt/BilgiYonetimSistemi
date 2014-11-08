using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiYönetimSistemi.WinForm
{
    public partial class YönetimForm : Form
    {
        public YönetimForm()
        {
            InitializeComponent();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            
            Raporlar rpr = new Raporlar();
            rpr.Visible = true;
            this.Close();
        }
    }
}

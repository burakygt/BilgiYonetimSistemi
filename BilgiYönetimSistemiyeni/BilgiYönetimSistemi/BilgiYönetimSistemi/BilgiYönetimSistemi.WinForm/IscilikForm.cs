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
namespace BilgiYönetimSistemi.WinForm
{
    public partial class IscilikForm : Form
    {
        public IscilikForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IscilikTanimlariForm itf = new IscilikTanimlariForm();
            itf.Show();
        }
        DataSet ds3 = Sorgular.IscilikCombo();

        private void IscilikForm_Load(object sender, EventArgs e)
        {

            #region combo doldurma
            foreach (DataRow dr3 in ds3.Tables[0].Rows)
            {
                comboIscilik.Items.Add(dr3["HizmetBilgisi"].ToString());
            }
            #endregion
        }

        private void bTamam_Click(object sender, EventArgs e)
        {
            ServisTakipFormu stf = new ServisTakipFormu();
            //stf.col_Tarih = dtIslem.Value;

            Iscilik entity = new Iscilik();
            entity.carikod = Convert.ToInt32(AnaForm.formno);
            entity.isciliktarihi = dtIslem.Value;
            entity.yapilanisler = comboIscilik.Text;
            entity.sure = nudSaat.Value;
            entity.ucret = Convert.ToDecimal(txtBirim.Text);
            //entity.kdv = nudKdv.Value;
            entity.yereltutar = Convert.ToDecimal(txtYerelTutar.Text);
            entity.isciliknot = txtNot.Text;

            if (!Iscilikler.Ekle(entity))
            {
                MessageBox.Show("İşçilik Eklenemedi..");
            }
            else
            {
                MessageBox.Show("Ekleme başarılı");//-------yenikod
                stf.iscidoldur();
                this.Close();
            }

            this.Close();



        }
    }
}

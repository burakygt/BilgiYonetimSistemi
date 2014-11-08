namespace BilgiYönetimSistemi.WinForm
{
    partial class IscilikForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtcarikodd = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYerelTutar = new System.Windows.Forms.MaskedTextBox();
            this.txtBirim = new System.Windows.Forms.MaskedTextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.bIptal = new DevExpress.XtraEditors.SimpleButton();
            this.bTamam = new DevExpress.XtraEditors.SimpleButton();
            this.txtNot = new System.Windows.Forms.RichTextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.nudKdv = new System.Windows.Forms.NumericUpDown();
            this.nudDakika = new System.Windows.Forms.NumericUpDown();
            this.nudSaat = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.comboIscilik = new System.Windows.Forms.ComboBox();
            this.dtIslem = new System.Windows.Forms.DateTimePicker();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcarikodd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDakika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSaat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtcarikodd);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtYerelTutar);
            this.groupControl1.Controls.Add(this.txtBirim);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.bIptal);
            this.groupControl1.Controls.Add(this.bTamam);
            this.groupControl1.Controls.Add(this.txtNot);
            this.groupControl1.Controls.Add(this.comboBox2);
            this.groupControl1.Controls.Add(this.nudKdv);
            this.groupControl1.Controls.Add(this.nudDakika);
            this.groupControl1.Controls.Add(this.nudSaat);
            this.groupControl1.Controls.Add(this.button1);
            this.groupControl1.Controls.Add(this.comboIscilik);
            this.groupControl1.Controls.Add(this.dtIslem);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(350, 507);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "İşlem Tanımları";
            // 
            // txtcarikodd
            // 
            this.txtcarikodd.Location = new System.Drawing.Point(113, 68);
            this.txtcarikodd.Name = "txtcarikodd";
            this.txtcarikodd.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.txtcarikodd.Size = new System.Drawing.Size(171, 20);
            this.txtcarikodd.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Cari Kod";
            // 
            // txtYerelTutar
            // 
            this.txtYerelTutar.Location = new System.Drawing.Point(113, 273);
            this.txtYerelTutar.Mask = "0,00";
            this.txtYerelTutar.Name = "txtYerelTutar";
            this.txtYerelTutar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtYerelTutar.Size = new System.Drawing.Size(202, 20);
            this.txtYerelTutar.TabIndex = 22;
            // 
            // txtBirim
            // 
            this.txtBirim.Location = new System.Drawing.Point(113, 220);
            this.txtBirim.Mask = "0,00";
            this.txtBirim.Name = "txtBirim";
            this.txtBirim.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBirim.Size = new System.Drawing.Size(130, 20);
            this.txtBirim.TabIndex = 21;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(236, 155);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(31, 13);
            this.labelControl9.TabIndex = 20;
            this.labelControl9.Text = "Dakika";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(159, 155);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(22, 13);
            this.labelControl8.TabIndex = 19;
            this.labelControl8.Text = "Saat";
            // 
            // bIptal
            // 
            this.bIptal.Location = new System.Drawing.Point(240, 472);
            this.bIptal.Name = "bIptal";
            this.bIptal.Size = new System.Drawing.Size(75, 23);
            this.bIptal.TabIndex = 18;
            this.bIptal.Text = "İPTAL";
            // 
            // bTamam
            // 
            this.bTamam.Location = new System.Drawing.Point(155, 472);
            this.bTamam.Name = "bTamam";
            this.bTamam.Size = new System.Drawing.Size(75, 23);
            this.bTamam.TabIndex = 17;
            this.bTamam.Text = "TAMAM";
            this.bTamam.Click += new System.EventHandler(this.bTamam_Click);
            // 
            // txtNot
            // 
            this.txtNot.Location = new System.Drawing.Point(113, 326);
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(202, 115);
            this.txtNot.TabIndex = 16;
            this.txtNot.Text = "";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "TL"});
            this.comboBox2.Location = new System.Drawing.Point(249, 219);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(66, 21);
            this.comboBox2.TabIndex = 14;
            // 
            // nudKdv
            // 
            this.nudKdv.Location = new System.Drawing.Point(113, 188);
            this.nudKdv.Name = "nudKdv";
            this.nudKdv.Size = new System.Drawing.Size(43, 20);
            this.nudKdv.TabIndex = 12;
            // 
            // nudDakika
            // 
            this.nudDakika.Location = new System.Drawing.Point(187, 153);
            this.nudDakika.Name = "nudDakika";
            this.nudDakika.Size = new System.Drawing.Size(43, 20);
            this.nudDakika.TabIndex = 11;
            // 
            // nudSaat
            // 
            this.nudSaat.Location = new System.Drawing.Point(113, 153);
            this.nudSaat.Name = "nudSaat";
            this.nudSaat.Size = new System.Drawing.Size(43, 20);
            this.nudSaat.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 21);
            this.button1.TabIndex = 9;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboIscilik
            // 
            this.comboIscilik.FormattingEnabled = true;
            this.comboIscilik.Location = new System.Drawing.Point(113, 93);
            this.comboIscilik.Name = "comboIscilik";
            this.comboIscilik.Size = new System.Drawing.Size(171, 21);
            this.comboIscilik.TabIndex = 8;
            // 
            // dtIslem
            // 
            this.dtIslem.Location = new System.Drawing.Point(113, 40);
            this.dtIslem.Name = "dtIslem";
            this.dtIslem.Size = new System.Drawing.Size(200, 20);
            this.dtIslem.TabIndex = 7;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(13, 326);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(17, 13);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "Not";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(13, 276);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(53, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Yerel Tutar";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(13, 222);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(49, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Birim Fiyat";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(13, 188);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(19, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "KDV";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 153);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(22, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Süre";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 96);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Yapılan İşçilik";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "İşlem Tarihi";
            // 
            // IscilikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(350, 507);
            this.Controls.Add(this.groupControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IscilikForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IscilikForm";
            this.Load += new System.EventHandler(this.IscilikForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcarikodd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDakika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSaat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.MaskedTextBox txtYerelTutar;
        private System.Windows.Forms.MaskedTextBox txtBirim;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton bIptal;
        private DevExpress.XtraEditors.SimpleButton bTamam;
        private System.Windows.Forms.RichTextBox txtNot;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.NumericUpDown nudKdv;
        private System.Windows.Forms.NumericUpDown nudDakika;
        private System.Windows.Forms.NumericUpDown nudSaat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboIscilik;
        private System.Windows.Forms.DateTimePicker dtIslem;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label label1;
        public DevExpress.XtraEditors.TextEdit txtcarikodd;
    }
}
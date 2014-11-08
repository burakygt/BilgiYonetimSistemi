namespace BilgiYönetimSistemi.WinForm
{
    partial class ServisTakipFormu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServisTakipFormu));
            DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator2 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.bEposta = new DevExpress.XtraEditors.SimpleButton();
            this.bSms = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.txtCariKod = new DevExpress.XtraEditors.TextEdit();
            this.bGorev = new DevExpress.XtraEditors.SimpleButton();
            this.cTeslim = new DevExpress.XtraEditors.CheckEdit();
            this.cOnay = new DevExpress.XtraEditors.CheckEdit();
            this.dtTeslim = new System.Windows.Forms.DateTimePicker();
            this.dtOnay = new System.Windows.Forms.DateTimePicker();
            this.dtGiris = new System.Windows.Forms.DateTimePicker();
            this.txtUnvan = new DevExpress.XtraEditors.TextEdit();
            this.beKategori = new DevExpress.XtraEditors.ButtonEdit();
            this.beFormNo = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl7 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.comboKonsol = new System.Windows.Forms.ComboBox();
            this.comboIsletim = new System.Windows.Forms.ComboBox();
            this.labelControl26 = new DevExpress.XtraEditors.LabelControl();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelControl25 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtCevap3 = new DevExpress.XtraEditors.TextEdit();
            this.txtSoru3 = new DevExpress.XtraEditors.TextEdit();
            this.txtCevap2 = new DevExpress.XtraEditors.TextEdit();
            this.txtSoru2 = new DevExpress.XtraEditors.TextEdit();
            this.txtCevap1 = new DevExpress.XtraEditors.TextEdit();
            this.txtSoru1 = new DevExpress.XtraEditors.TextEdit();
            this.bProb = new DevExpress.XtraEditors.SimpleButton();
            this.comboProbTur = new System.Windows.Forms.ComboBox();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl6 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dtTaahhüt = new System.Windows.Forms.DateTimePicker();
            this.labelControl27 = new DevExpress.XtraEditors.LabelControl();
            this.textModel = new System.Windows.Forms.TextBox();
            this.checkDiger = new System.Windows.Forms.CheckBox();
            this.barCodeControl1 = new DevExpress.XtraEditors.BarCodeControl();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.beBarkod = new DevExpress.XtraEditors.ButtonEdit();
            this.comboSeriNo = new System.Windows.Forms.ComboBox();
            this.bGaranti = new DevExpress.XtraEditors.SimpleButton();
            this.bIslem = new DevExpress.XtraEditors.SimpleButton();
            this.bEkip = new DevExpress.XtraEditors.SimpleButton();
            this.comboGarantiDurum = new System.Windows.Forms.ComboBox();
            this.comboIslemDurum = new System.Windows.Forms.ComboBox();
            this.comboEkipPersonel = new System.Windows.Forms.ComboBox();
            this.comboUrunTeslimEden = new System.Windows.Forms.ComboBox();
            this.comboIsiYapan = new System.Windows.Forms.ComboBox();
            this.comboModel = new System.Windows.Forms.ComboBox();
            this.comboMarka = new System.Windows.Forms.ComboBox();
            this.comboUrun = new System.Windows.Forms.ComboBox();
            this.gridIsci = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_Tarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_YapilanIsler = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Sure = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Saat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_YerelTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.colorPickEdit3 = new DevExpress.XtraEditors.ColorPickEdit();
            this.colorPickEdit2 = new DevExpress.XtraEditors.ColorPickEdit();
            this.colorPickEdit1 = new DevExpress.XtraEditors.ColorPickEdit();
            this.labelControl24 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.bKapat = new DevExpress.XtraEditors.SimpleButton();
            this.bHesapMakinesi = new DevExpress.XtraEditors.SimpleButton();
            this.bYazdir = new DevExpress.XtraEditors.SimpleButton();
            this.bGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.bKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnYenile = new DevExpress.XtraEditors.SimpleButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTeslim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOnay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnvan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beKategori.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beFormNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).BeginInit();
            this.panelControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCevap3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoru3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCevap2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoru2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCevap1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoru1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).BeginInit();
            this.panelControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beBarkod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridIsci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorPickEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorPickEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorPickEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.düzenToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(904, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // düzenToolStripMenuItem
            // 
            this.düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            this.düzenToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.düzenToolStripMenuItem.Text = "Düzen";
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton6);
            this.panelControl1.Controls.Add(this.simpleButton5);
            this.panelControl1.Controls.Add(this.bEposta);
            this.panelControl1.Controls.Add(this.bSms);
            this.panelControl1.Controls.Add(this.labelControl21);
            this.panelControl1.Controls.Add(this.txtCariKod);
            this.panelControl1.Controls.Add(this.bGorev);
            this.panelControl1.Controls.Add(this.cTeslim);
            this.panelControl1.Controls.Add(this.cOnay);
            this.panelControl1.Controls.Add(this.dtTeslim);
            this.panelControl1.Controls.Add(this.dtOnay);
            this.panelControl1.Controls.Add(this.dtGiris);
            this.panelControl1.Controls.Add(this.txtUnvan);
            this.panelControl1.Controls.Add(this.beKategori);
            this.panelControl1.Controls.Add(this.beFormNo);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 24);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(904, 108);
            this.panelControl1.TabIndex = 1;
            // 
            // simpleButton6
            // 
            this.simpleButton6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.simpleButton6.Appearance.Options.UseBackColor = true;
            this.simpleButton6.Location = new System.Drawing.Point(694, 10);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(198, 35);
            this.simpleButton6.TabIndex = 20;
            this.simpleButton6.Text = "Bilgilendir";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Image = global::BilgiYönetimSistemi.WinForm.Properties.Resources.social_facebook_box_blue_icon;
            this.simpleButton5.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton5.Location = new System.Drawing.Point(830, 47);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(62, 51);
            this.simpleButton5.TabIndex = 19;
            this.simpleButton5.Text = "FACEBOOK";
            // 
            // bEposta
            // 
            this.bEposta.Image = ((System.Drawing.Image)(resources.GetObject("bEposta.Image")));
            this.bEposta.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.bEposta.Location = new System.Drawing.Point(762, 47);
            this.bEposta.Name = "bEposta";
            this.bEposta.Size = new System.Drawing.Size(62, 52);
            this.bEposta.TabIndex = 18;
            this.bEposta.Text = "E-POSTA";
            // 
            // bSms
            // 
            this.bSms.Image = global::BilgiYönetimSistemi.WinForm.Properties.Resources.SMS_icon;
            this.bSms.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.bSms.Location = new System.Drawing.Point(694, 47);
            this.bSms.Name = "bSms";
            this.bSms.Size = new System.Drawing.Size(62, 51);
            this.bSms.TabIndex = 17;
            this.bSms.Text = "SMS";
            this.bSms.Click += new System.EventHandler(this.bSms_Click);
            // 
            // labelControl21
            // 
            this.labelControl21.Location = new System.Drawing.Point(13, 28);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(40, 13);
            this.labelControl21.TabIndex = 16;
            this.labelControl21.Text = "Cari Kod";
            // 
            // txtCariKod
            // 
            this.txtCariKod.Location = new System.Drawing.Point(92, 25);
            this.txtCariKod.Name = "txtCariKod";
            this.txtCariKod.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.txtCariKod.Size = new System.Drawing.Size(149, 20);
            this.txtCariKod.TabIndex = 15;
            // 
            // bGorev
            // 
            this.bGorev.Image = ((System.Drawing.Image)(resources.GetObject("bGorev.Image")));
            this.bGorev.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.bGorev.Location = new System.Drawing.Point(590, 28);
            this.bGorev.Name = "bGorev";
            this.bGorev.Size = new System.Drawing.Size(64, 58);
            this.bGorev.TabIndex = 13;
            this.bGorev.Text = "Görev Ata";
            this.bGorev.Click += new System.EventHandler(this.bGorev_Click);
            // 
            // cTeslim
            // 
            this.cTeslim.Location = new System.Drawing.Point(330, 70);
            this.cTeslim.Name = "cTeslim";
            this.cTeslim.Properties.Caption = "";
            this.cTeslim.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.cTeslim.Size = new System.Drawing.Size(18, 19);
            this.cTeslim.TabIndex = 12;
            this.cTeslim.CheckedChanged += new System.EventHandler(this.cTeslim_CheckedChanged);
            // 
            // cOnay
            // 
            this.cOnay.Location = new System.Drawing.Point(330, 39);
            this.cOnay.Name = "cOnay";
            this.cOnay.Properties.Caption = "";
            this.cOnay.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.cOnay.Size = new System.Drawing.Size(18, 19);
            this.cOnay.TabIndex = 10;
            this.cOnay.CheckedChanged += new System.EventHandler(this.cOnay_CheckedChanged);
            // 
            // dtTeslim
            // 
            this.dtTeslim.Location = new System.Drawing.Point(354, 69);
            this.dtTeslim.Name = "dtTeslim";
            this.dtTeslim.Size = new System.Drawing.Size(200, 20);
            this.dtTeslim.TabIndex = 11;
            // 
            // dtOnay
            // 
            this.dtOnay.Location = new System.Drawing.Point(354, 39);
            this.dtOnay.Name = "dtOnay";
            this.dtOnay.Size = new System.Drawing.Size(200, 20);
            this.dtOnay.TabIndex = 10;
            // 
            // dtGiris
            // 
            this.dtGiris.CustomFormat = "";
            this.dtGiris.Location = new System.Drawing.Point(354, 7);
            this.dtGiris.Name = "dtGiris";
            this.dtGiris.Size = new System.Drawing.Size(200, 20);
            this.dtGiris.TabIndex = 9;
            // 
            // txtUnvan
            // 
            this.txtUnvan.Location = new System.Drawing.Point(92, 51);
            this.txtUnvan.Name = "txtUnvan";
            this.txtUnvan.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.txtUnvan.Size = new System.Drawing.Size(149, 20);
            this.txtUnvan.TabIndex = 8;
            // 
            // beKategori
            // 
            this.beKategori.Location = new System.Drawing.Point(92, 75);
            this.beKategori.Name = "beKategori";
            this.beKategori.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.beKategori.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.beKategori.Size = new System.Drawing.Size(149, 20);
            this.beKategori.TabIndex = 7;
            this.beKategori.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beKategori_ButtonClick);
            // 
            // beFormNo
            // 
            this.beFormNo.Location = new System.Drawing.Point(92, 3);
            this.beFormNo.Name = "beFormNo";
            this.beFormNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.beFormNo.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.beFormNo.Size = new System.Drawing.Size(149, 20);
            this.beFormNo.TabIndex = 6;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(262, 75);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(57, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Teslim Bilgisi";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(262, 42);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(54, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Onay Bilgisi";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(262, 10);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Giriş Bilgisi";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(14, 81);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Kategoriler";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 51);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Ticari Unvan";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Form No";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.xtraTabControl1);
            this.panelControl2.Location = new System.Drawing.Point(0, 169);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(904, 391);
            this.panelControl2.TabIndex = 2;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(2, 2);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(900, 387);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.panelControl7);
            this.xtraTabPage1.Controls.Add(this.panelControl6);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(894, 359);
            this.xtraTabPage1.Text = "Ürün Bilgisi ve Problem";
            // 
            // panelControl7
            // 
            this.panelControl7.Controls.Add(this.groupControl2);
            this.panelControl7.Location = new System.Drawing.Point(658, 0);
            this.panelControl7.Name = "panelControl7";
            this.panelControl7.Size = new System.Drawing.Size(236, 354);
            this.panelControl7.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.comboKonsol);
            this.groupControl2.Controls.Add(this.comboIsletim);
            this.groupControl2.Controls.Add(this.labelControl26);
            this.groupControl2.Controls.Add(this.numericUpDown1);
            this.groupControl2.Controls.Add(this.labelControl25);
            this.groupControl2.Controls.Add(this.labelControl20);
            this.groupControl2.Controls.Add(this.labelControl19);
            this.groupControl2.Controls.Add(this.labelControl23);
            this.groupControl2.Controls.Add(this.labelControl22);
            this.groupControl2.Controls.Add(this.richTextBox1);
            this.groupControl2.Controls.Add(this.txtCevap3);
            this.groupControl2.Controls.Add(this.txtSoru3);
            this.groupControl2.Controls.Add(this.txtCevap2);
            this.groupControl2.Controls.Add(this.txtSoru2);
            this.groupControl2.Controls.Add(this.txtCevap1);
            this.groupControl2.Controls.Add(this.txtSoru1);
            this.groupControl2.Controls.Add(this.bProb);
            this.groupControl2.Controls.Add(this.comboProbTur);
            this.groupControl2.Controls.Add(this.labelControl18);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(2, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(232, 350);
            this.groupControl2.TabIndex = 27;
            this.groupControl2.Text = "Problem";
            // 
            // comboKonsol
            // 
            this.comboKonsol.FormattingEnabled = true;
            this.comboKonsol.Items.AddRange(new object[] {
            "PS3 Fat",
            "PS3 Slim",
            "PS3 Super Slim",
            "PS4 Fat",
            "PS4 Slim",
            "PS4 Super Slim",
            "Xbox",
            "Wii",
            "PSP"});
            this.comboKonsol.Location = new System.Drawing.Point(87, 94);
            this.comboKonsol.Name = "comboKonsol";
            this.comboKonsol.Size = new System.Drawing.Size(112, 21);
            this.comboKonsol.TabIndex = 44;
            // 
            // comboIsletim
            // 
            this.comboIsletim.FormattingEnabled = true;
            this.comboIsletim.Location = new System.Drawing.Point(87, 64);
            this.comboIsletim.Name = "comboIsletim";
            this.comboIsletim.Size = new System.Drawing.Size(112, 21);
            this.comboIsletim.TabIndex = 43;
            // 
            // labelControl26
            // 
            this.labelControl26.Location = new System.Drawing.Point(132, 128);
            this.labelControl26.Name = "labelControl26";
            this.labelControl26.Size = new System.Drawing.Size(22, 13);
            this.labelControl26.TabIndex = 42;
            this.labelControl26.Text = "adet";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(88, 126);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown1.TabIndex = 41;
            // 
            // labelControl25
            // 
            this.labelControl25.Location = new System.Drawing.Point(5, 126);
            this.labelControl25.Name = "labelControl25";
            this.labelControl25.Size = new System.Drawing.Size(44, 13);
            this.labelControl25.TabIndex = 40;
            this.labelControl25.Text = "Kol Sayısı";
            // 
            // labelControl20
            // 
            this.labelControl20.Location = new System.Drawing.Point(147, 154);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(43, 13);
            this.labelControl20.TabIndex = 39;
            this.labelControl20.Text = "Cevaplar";
            // 
            // labelControl19
            // 
            this.labelControl19.Location = new System.Drawing.Point(33, 154);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(34, 13);
            this.labelControl19.TabIndex = 38;
            this.labelControl19.Text = "Sorular";
            // 
            // labelControl23
            // 
            this.labelControl23.Location = new System.Drawing.Point(3, 96);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(56, 13);
            this.labelControl23.TabIndex = 35;
            this.labelControl23.Text = "Konsol Türü";
            // 
            // labelControl22
            // 
            this.labelControl22.Location = new System.Drawing.Point(3, 67);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(67, 13);
            this.labelControl22.TabIndex = 34;
            this.labelControl22.Text = "İşletim Sistemi";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(5, 273);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(212, 72);
            this.richTextBox1.TabIndex = 33;
            this.richTextBox1.Text = "";
            // 
            // txtCevap3
            // 
            this.txtCevap3.Location = new System.Drawing.Point(115, 249);
            this.txtCevap3.Name = "txtCevap3";
            this.txtCevap3.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.txtCevap3.Size = new System.Drawing.Size(101, 20);
            this.txtCevap3.TabIndex = 32;
            // 
            // txtSoru3
            // 
            this.txtSoru3.Location = new System.Drawing.Point(3, 249);
            this.txtSoru3.Name = "txtSoru3";
            this.txtSoru3.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.txtSoru3.Size = new System.Drawing.Size(101, 20);
            this.txtSoru3.TabIndex = 31;
            // 
            // txtCevap2
            // 
            this.txtCevap2.Location = new System.Drawing.Point(115, 209);
            this.txtCevap2.Name = "txtCevap2";
            this.txtCevap2.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.txtCevap2.Size = new System.Drawing.Size(101, 20);
            this.txtCevap2.TabIndex = 30;
            // 
            // txtSoru2
            // 
            this.txtSoru2.Location = new System.Drawing.Point(3, 209);
            this.txtSoru2.Name = "txtSoru2";
            this.txtSoru2.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.txtSoru2.Size = new System.Drawing.Size(101, 20);
            this.txtSoru2.TabIndex = 29;
            // 
            // txtCevap1
            // 
            this.txtCevap1.Location = new System.Drawing.Point(115, 173);
            this.txtCevap1.Name = "txtCevap1";
            this.txtCevap1.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.txtCevap1.Size = new System.Drawing.Size(101, 20);
            this.txtCevap1.TabIndex = 26;
            // 
            // txtSoru1
            // 
            this.txtSoru1.Location = new System.Drawing.Point(3, 173);
            this.txtSoru1.Name = "txtSoru1";
            this.txtSoru1.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.txtSoru1.Size = new System.Drawing.Size(101, 20);
            this.txtSoru1.TabIndex = 25;
            // 
            // bProb
            // 
            this.bProb.Location = new System.Drawing.Point(205, 32);
            this.bProb.Name = "bProb";
            this.bProb.Size = new System.Drawing.Size(20, 18);
            this.bProb.TabIndex = 24;
            this.bProb.Text = "...";
            this.bProb.Click += new System.EventHandler(this.bProb_Click);
            // 
            // comboProbTur
            // 
            this.comboProbTur.FormattingEnabled = true;
            this.comboProbTur.Location = new System.Drawing.Point(87, 32);
            this.comboProbTur.Name = "comboProbTur";
            this.comboProbTur.Size = new System.Drawing.Size(112, 21);
            this.comboProbTur.TabIndex = 6;
            this.comboProbTur.SelectedIndexChanged += new System.EventHandler(this.comboProbTur_SelectedIndexChanged);
            // 
            // labelControl18
            // 
            this.labelControl18.Location = new System.Drawing.Point(5, 34);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(63, 13);
            this.labelControl18.TabIndex = 0;
            this.labelControl18.Text = "Problem Türü";
            // 
            // panelControl6
            // 
            this.panelControl6.Controls.Add(this.groupControl1);
            this.panelControl6.Location = new System.Drawing.Point(3, 0);
            this.panelControl6.Name = "panelControl6";
            this.panelControl6.Size = new System.Drawing.Size(656, 356);
            this.panelControl6.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnYenile);
            this.groupControl1.Controls.Add(this.dtTaahhüt);
            this.groupControl1.Controls.Add(this.labelControl27);
            this.groupControl1.Controls.Add(this.textModel);
            this.groupControl1.Controls.Add(this.checkDiger);
            this.groupControl1.Controls.Add(this.barCodeControl1);
            this.groupControl1.Controls.Add(this.simpleButton4);
            this.groupControl1.Controls.Add(this.simpleButton3);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.beBarkod);
            this.groupControl1.Controls.Add(this.comboSeriNo);
            this.groupControl1.Controls.Add(this.bGaranti);
            this.groupControl1.Controls.Add(this.bIslem);
            this.groupControl1.Controls.Add(this.bEkip);
            this.groupControl1.Controls.Add(this.comboGarantiDurum);
            this.groupControl1.Controls.Add(this.comboIslemDurum);
            this.groupControl1.Controls.Add(this.comboEkipPersonel);
            this.groupControl1.Controls.Add(this.comboUrunTeslimEden);
            this.groupControl1.Controls.Add(this.comboIsiYapan);
            this.groupControl1.Controls.Add(this.comboModel);
            this.groupControl1.Controls.Add(this.comboMarka);
            this.groupControl1.Controls.Add(this.comboUrun);
            this.groupControl1.Controls.Add(this.gridIsci);
            this.groupControl1.Controls.Add(this.labelControl17);
            this.groupControl1.Controls.Add(this.labelControl16);
            this.groupControl1.Controls.Add(this.labelControl15);
            this.groupControl1.Controls.Add(this.labelControl14);
            this.groupControl1.Controls.Add(this.labelControl13);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(652, 352);
            this.groupControl1.TabIndex = 25;
            this.groupControl1.Text = "Ürün Bilgisi";
            // 
            // dtTaahhüt
            // 
            this.dtTaahhüt.Location = new System.Drawing.Point(458, 209);
            this.dtTaahhüt.Name = "dtTaahhüt";
            this.dtTaahhüt.Size = new System.Drawing.Size(185, 20);
            this.dtTaahhüt.TabIndex = 32;
            // 
            // labelControl27
            // 
            this.labelControl27.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl27.Location = new System.Drawing.Point(337, 212);
            this.labelControl27.Name = "labelControl27";
            this.labelControl27.Size = new System.Drawing.Size(115, 13);
            this.labelControl27.TabIndex = 31;
            this.labelControl27.Text = "Taahhüt Edilen Tarih";
            // 
            // textModel
            // 
            this.textModel.Enabled = false;
            this.textModel.Location = new System.Drawing.Point(203, 133);
            this.textModel.Name = "textModel";
            this.textModel.Size = new System.Drawing.Size(99, 20);
            this.textModel.TabIndex = 30;
            // 
            // checkDiger
            // 
            this.checkDiger.AutoSize = true;
            this.checkDiger.Enabled = false;
            this.checkDiger.Location = new System.Drawing.Point(116, 135);
            this.checkDiger.Name = "checkDiger";
            this.checkDiger.Size = new System.Drawing.Size(51, 17);
            this.checkDiger.TabIndex = 29;
            this.checkDiger.Text = "Diğer";
            this.checkDiger.UseVisualStyleBackColor = true;
            this.checkDiger.CheckedChanged += new System.EventHandler(this.checkDiger_CheckedChanged);
            // 
            // barCodeControl1
            // 
            this.barCodeControl1.Location = new System.Drawing.Point(239, 199);
            this.barCodeControl1.Name = "barCodeControl1";
            this.barCodeControl1.Padding = new System.Windows.Forms.Padding(10, 2, 10, 0);
            this.barCodeControl1.Size = new System.Drawing.Size(92, 23);
            this.barCodeControl1.Symbology = code128Generator2;
            this.barCodeControl1.TabIndex = 28;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(308, 65);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(20, 18);
            this.simpleButton4.TabIndex = 27;
            this.simpleButton4.Text = "...";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(188, 324);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 21);
            this.simpleButton3.TabIndex = 26;
            this.simpleButton3.Text = "Sil";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(99, 324);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 21);
            this.simpleButton2.TabIndex = 25;
            this.simpleButton2.Text = "Düzenle";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(4, 324);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 21);
            this.simpleButton1.TabIndex = 24;
            this.simpleButton1.Text = "İşçilik Ekle";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // beBarkod
            // 
            this.beBarkod.Location = new System.Drawing.Point(116, 201);
            this.beBarkod.Name = "beBarkod";
            this.beBarkod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.beBarkod.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.beBarkod.Size = new System.Drawing.Size(117, 20);
            this.beBarkod.TabIndex = 23;
            // 
            // comboSeriNo
            // 
            this.comboSeriNo.FormattingEnabled = true;
            this.comboSeriNo.Location = new System.Drawing.Point(116, 161);
            this.comboSeriNo.Name = "comboSeriNo";
            this.comboSeriNo.Size = new System.Drawing.Size(186, 21);
            this.comboSeriNo.TabIndex = 22;
            // 
            // bGaranti
            // 
            this.bGaranti.Location = new System.Drawing.Point(623, 175);
            this.bGaranti.Name = "bGaranti";
            this.bGaranti.Size = new System.Drawing.Size(20, 18);
            this.bGaranti.TabIndex = 21;
            this.bGaranti.Text = "...";
            this.bGaranti.Click += new System.EventHandler(this.bGaranti_Click);
            // 
            // bIslem
            // 
            this.bIslem.Location = new System.Drawing.Point(623, 136);
            this.bIslem.Name = "bIslem";
            this.bIslem.Size = new System.Drawing.Size(20, 18);
            this.bIslem.TabIndex = 20;
            this.bIslem.Text = "...";
            this.bIslem.Click += new System.EventHandler(this.bIslem_Click);
            // 
            // bEkip
            // 
            this.bEkip.Location = new System.Drawing.Point(623, 100);
            this.bEkip.Name = "bEkip";
            this.bEkip.Size = new System.Drawing.Size(20, 18);
            this.bEkip.TabIndex = 19;
            this.bEkip.Text = "...";
            this.bEkip.Click += new System.EventHandler(this.bEkip_Click);
            // 
            // comboGarantiDurum
            // 
            this.comboGarantiDurum.FormattingEnabled = true;
            this.comboGarantiDurum.Location = new System.Drawing.Point(431, 175);
            this.comboGarantiDurum.Name = "comboGarantiDurum";
            this.comboGarantiDurum.Size = new System.Drawing.Size(186, 21);
            this.comboGarantiDurum.TabIndex = 18;
            // 
            // comboIslemDurum
            // 
            this.comboIslemDurum.FormattingEnabled = true;
            this.comboIslemDurum.Location = new System.Drawing.Point(431, 135);
            this.comboIslemDurum.Name = "comboIslemDurum";
            this.comboIslemDurum.Size = new System.Drawing.Size(186, 21);
            this.comboIslemDurum.TabIndex = 17;
            // 
            // comboEkipPersonel
            // 
            this.comboEkipPersonel.FormattingEnabled = true;
            this.comboEkipPersonel.Location = new System.Drawing.Point(431, 99);
            this.comboEkipPersonel.Name = "comboEkipPersonel";
            this.comboEkipPersonel.Size = new System.Drawing.Size(186, 21);
            this.comboEkipPersonel.TabIndex = 16;
            // 
            // comboUrunTeslimEden
            // 
            this.comboUrunTeslimEden.FormattingEnabled = true;
            this.comboUrunTeslimEden.Location = new System.Drawing.Point(431, 64);
            this.comboUrunTeslimEden.Name = "comboUrunTeslimEden";
            this.comboUrunTeslimEden.Size = new System.Drawing.Size(186, 21);
            this.comboUrunTeslimEden.TabIndex = 15;
            // 
            // comboIsiYapan
            // 
            this.comboIsiYapan.FormattingEnabled = true;
            this.comboIsiYapan.Location = new System.Drawing.Point(431, 31);
            this.comboIsiYapan.Name = "comboIsiYapan";
            this.comboIsiYapan.Size = new System.Drawing.Size(186, 21);
            this.comboIsiYapan.TabIndex = 14;
            // 
            // comboModel
            // 
            this.comboModel.Enabled = false;
            this.comboModel.FormattingEnabled = true;
            this.comboModel.Location = new System.Drawing.Point(116, 99);
            this.comboModel.Name = "comboModel";
            this.comboModel.Size = new System.Drawing.Size(186, 21);
            this.comboModel.TabIndex = 13;
            // 
            // comboMarka
            // 
            this.comboMarka.Enabled = false;
            this.comboMarka.FormattingEnabled = true;
            this.comboMarka.Location = new System.Drawing.Point(116, 64);
            this.comboMarka.Name = "comboMarka";
            this.comboMarka.Size = new System.Drawing.Size(186, 21);
            this.comboMarka.TabIndex = 12;
            this.comboMarka.SelectedIndexChanged += new System.EventHandler(this.comboMarka_SelectedIndexChanged);
            // 
            // comboUrun
            // 
            this.comboUrun.FormattingEnabled = true;
            this.comboUrun.Location = new System.Drawing.Point(116, 31);
            this.comboUrun.Name = "comboUrun";
            this.comboUrun.Size = new System.Drawing.Size(186, 21);
            this.comboUrun.TabIndex = 11;
            this.comboUrun.SelectedIndexChanged += new System.EventHandler(this.comboUrun_SelectedIndexChanged);
            // 
            // gridIsci
            // 
            this.gridIsci.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridIsci.Location = new System.Drawing.Point(2, 240);
            this.gridIsci.MainView = this.gridView1;
            this.gridIsci.Name = "gridIsci";
            this.gridIsci.Size = new System.Drawing.Size(644, 105);
            this.gridIsci.TabIndex = 10;
            this.gridIsci.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_Tarih,
            this.col_YapilanIsler,
            this.col_Sure,
            this.col_Saat,
            this.col_YerelTutar});
            this.gridView1.GridControl = this.gridIsci;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // col_Tarih
            // 
            this.col_Tarih.Caption = "Tarih";
            this.col_Tarih.FieldName = "TARIH";
            this.col_Tarih.Name = "col_Tarih";
            this.col_Tarih.Visible = true;
            this.col_Tarih.VisibleIndex = 0;
            // 
            // col_YapilanIsler
            // 
            this.col_YapilanIsler.Caption = "Yapılan İşler";
            this.col_YapilanIsler.FieldName = "YAPILAN";
            this.col_YapilanIsler.Name = "col_YapilanIsler";
            this.col_YapilanIsler.Visible = true;
            this.col_YapilanIsler.VisibleIndex = 1;
            // 
            // col_Sure
            // 
            this.col_Sure.Caption = "Süre";
            this.col_Sure.FieldName = "SURE";
            this.col_Sure.Name = "col_Sure";
            this.col_Sure.Visible = true;
            this.col_Sure.VisibleIndex = 2;
            // 
            // col_Saat
            // 
            this.col_Saat.Caption = "Saat Ücret";
            this.col_Saat.FieldName = "UCRET";
            this.col_Saat.Name = "col_Saat";
            this.col_Saat.Visible = true;
            this.col_Saat.VisibleIndex = 3;
            // 
            // col_YerelTutar
            // 
            this.col_YerelTutar.Caption = "Yerel Tutar";
            this.col_YerelTutar.FieldName = "TUTAR";
            this.col_YerelTutar.Name = "col_YerelTutar";
            this.col_YerelTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.col_YerelTutar.Visible = true;
            this.col_YerelTutar.VisibleIndex = 4;
            // 
            // labelControl17
            // 
            this.labelControl17.Location = new System.Drawing.Point(342, 178);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(75, 13);
            this.labelControl17.TabIndex = 9;
            this.labelControl17.Text = "Garanti Durumu";
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(342, 138);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(65, 13);
            this.labelControl16.TabIndex = 8;
            this.labelControl16.Text = "İşlem Durumu";
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(342, 102);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(64, 13);
            this.labelControl15.TabIndex = 7;
            this.labelControl15.Text = "Ekip-Personel";
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(342, 67);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(82, 13);
            this.labelControl14.TabIndex = 6;
            this.labelControl14.Text = "Ürün Teslim Eden";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(342, 34);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(70, 13);
            this.labelControl13.TabIndex = 5;
            this.labelControl13.Text = "Kime Atanacak";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(12, 204);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(49, 13);
            this.labelControl12.TabIndex = 4;
            this.labelControl12.Text = "Barkod No";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(12, 164);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(34, 13);
            this.labelControl11.TabIndex = 3;
            this.labelControl11.Text = "Seri No";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(11, 102);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(28, 13);
            this.labelControl10.TabIndex = 2;
            this.labelControl10.Text = "Model";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(12, 67);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(29, 13);
            this.labelControl9.TabIndex = 1;
            this.labelControl9.Text = "Marka";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(12, 34);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(48, 13);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "Ürün Cinsi";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(894, 359);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.radioButton3);
            this.panelControl3.Controls.Add(this.radioButton2);
            this.panelControl3.Controls.Add(this.radioButton1);
            this.panelControl3.Controls.Add(this.labelControl7);
            this.panelControl3.Location = new System.Drawing.Point(0, 138);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(400, 30);
            this.panelControl3.TabIndex = 3;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(311, 7);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(57, 17);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Montaj";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(215, 7);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(57, 17);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Hizmet";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(124, 8);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 17);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Onarım";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(14, 9);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(51, 13);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "İş Emri Tipi";
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.colorPickEdit3);
            this.panelControl4.Controls.Add(this.colorPickEdit2);
            this.panelControl4.Controls.Add(this.colorPickEdit1);
            this.panelControl4.Controls.Add(this.labelControl24);
            this.panelControl4.Location = new System.Drawing.Point(402, 138);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(502, 30);
            this.panelControl4.TabIndex = 4;
            // 
            // colorPickEdit3
            // 
            this.colorPickEdit3.EditValue = System.Drawing.Color.Empty;
            this.colorPickEdit3.Location = new System.Drawing.Point(339, 6);
            this.colorPickEdit3.Name = "colorPickEdit3";
            this.colorPickEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.colorPickEdit3.Properties.CustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty};
            this.colorPickEdit3.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.colorPickEdit3.Size = new System.Drawing.Size(53, 20);
            this.colorPickEdit3.TabIndex = 9;
            // 
            // colorPickEdit2
            // 
            this.colorPickEdit2.EditValue = System.Drawing.Color.Empty;
            this.colorPickEdit2.Location = new System.Drawing.Point(207, 6);
            this.colorPickEdit2.Name = "colorPickEdit2";
            this.colorPickEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.colorPickEdit2.Properties.CustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty};
            this.colorPickEdit2.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.colorPickEdit2.Size = new System.Drawing.Size(53, 20);
            this.colorPickEdit2.TabIndex = 8;
            // 
            // colorPickEdit1
            // 
            this.colorPickEdit1.EditValue = System.Drawing.Color.Empty;
            this.colorPickEdit1.Location = new System.Drawing.Point(60, 6);
            this.colorPickEdit1.Name = "colorPickEdit1";
            this.colorPickEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.colorPickEdit1.Properties.CustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty};
            this.colorPickEdit1.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.colorPickEdit1.Size = new System.Drawing.Size(53, 20);
            this.colorPickEdit1.TabIndex = 7;
            // 
            // labelControl24
            // 
            this.labelControl24.Location = new System.Drawing.Point(5, 9);
            this.labelControl24.Name = "labelControl24";
            this.labelControl24.Size = new System.Drawing.Size(36, 13);
            this.labelControl24.TabIndex = 6;
            this.labelControl24.Text = "Renkler";
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.bKapat);
            this.panelControl5.Controls.Add(this.bHesapMakinesi);
            this.panelControl5.Controls.Add(this.bYazdir);
            this.panelControl5.Controls.Add(this.bGuncelle);
            this.panelControl5.Controls.Add(this.bKaydet);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl5.Location = new System.Drawing.Point(0, 559);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(904, 44);
            this.panelControl5.TabIndex = 5;
            // 
            // bKapat
            // 
            this.bKapat.Image = ((System.Drawing.Image)(resources.GetObject("bKapat.Image")));
            this.bKapat.Location = new System.Drawing.Point(785, 7);
            this.bKapat.Name = "bKapat";
            this.bKapat.Size = new System.Drawing.Size(106, 31);
            this.bKapat.TabIndex = 11;
            this.bKapat.Text = "VAZGEÇ";
            // 
            // bHesapMakinesi
            // 
            this.bHesapMakinesi.Image = global::BilgiYönetimSistemi.WinForm.Properties.Resources.Calculator_icon;
            this.bHesapMakinesi.Location = new System.Drawing.Point(143, 7);
            this.bHesapMakinesi.Name = "bHesapMakinesi";
            this.bHesapMakinesi.Size = new System.Drawing.Size(128, 31);
            this.bHesapMakinesi.TabIndex = 9;
            this.bHesapMakinesi.Text = "HESAP MAKİNESİ";
            // 
            // bYazdir
            // 
            this.bYazdir.Image = ((System.Drawing.Image)(resources.GetObject("bYazdir.Image")));
            this.bYazdir.Location = new System.Drawing.Point(14, 7);
            this.bYazdir.Name = "bYazdir";
            this.bYazdir.Size = new System.Drawing.Size(106, 31);
            this.bYazdir.TabIndex = 8;
            this.bYazdir.Text = "YAZDIR";
            this.bYazdir.Click += new System.EventHandler(this.bYazdir_Click);
            // 
            // bGuncelle
            // 
            this.bGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("bGuncelle.Image")));
            this.bGuncelle.Location = new System.Drawing.Point(623, 7);
            this.bGuncelle.Name = "bGuncelle";
            this.bGuncelle.Size = new System.Drawing.Size(144, 31);
            this.bGuncelle.TabIndex = 7;
            this.bGuncelle.Text = "KAYDET VE KAPAT";
            this.bGuncelle.Click += new System.EventHandler(this.bKaydetKapat_Click);
            // 
            // bKaydet
            // 
            this.bKaydet.Image = ((System.Drawing.Image)(resources.GetObject("bKaydet.Image")));
            this.bKaydet.Location = new System.Drawing.Point(420, 8);
            this.bKaydet.Name = "bKaydet";
            this.bKaydet.Size = new System.Drawing.Size(180, 31);
            this.bKaydet.TabIndex = 6;
            this.bKaydet.Text = "KAYDET VE GÖREV ATA";
            this.bKaydet.Click += new System.EventHandler(this.bKaydet_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yenileToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(107, 26);
            // 
            // yenileToolStripMenuItem
            // 
            this.yenileToolStripMenuItem.Name = "yenileToolStripMenuItem";
            this.yenileToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.yenileToolStripMenuItem.Text = "Yenile";
            this.yenileToolStripMenuItem.Click += new System.EventHandler(this.yenileToolStripMenuItem_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(285, 324);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(75, 21);
            this.btnYenile.TabIndex = 33;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // ServisTakipFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(904, 603);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panelControl5);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServisTakipFormu";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServisTakipFormu";
            this.Load += new System.EventHandler(this.ServisTakipFormu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTeslim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOnay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnvan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beKategori.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beFormNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).EndInit();
            this.panelControl7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCevap3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoru3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCevap2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoru2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCevap1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoru1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).EndInit();
            this.panelControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beBarkod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridIsci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorPickEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorPickEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorPickEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.ButtonEdit beKategori;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        public System.Windows.Forms.ComboBox comboModel;
        public System.Windows.Forms.ComboBox comboMarka;
        public System.Windows.Forms.ComboBox comboUrun;
        public DevExpress.XtraGrid.Columns.GridColumn col_Tarih;
        public DevExpress.XtraGrid.Columns.GridColumn col_YapilanIsler;
        public DevExpress.XtraGrid.Columns.GridColumn col_Sure;
        public DevExpress.XtraGrid.Columns.GridColumn col_Saat;
        public DevExpress.XtraGrid.Columns.GridColumn col_YerelTutar;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public System.Windows.Forms.ComboBox comboGarantiDurum;
        public System.Windows.Forms.ComboBox comboIslemDurum;
        public System.Windows.Forms.ComboBox comboEkipPersonel;
        public System.Windows.Forms.ComboBox comboUrunTeslimEden;
        public System.Windows.Forms.ComboBox comboIsiYapan;
        public DevExpress.XtraEditors.TextEdit txtUnvan;
        public DevExpress.XtraEditors.TextEdit txtCariKod;
        public DevExpress.XtraEditors.ButtonEdit beFormNo;
        public System.Windows.Forms.ComboBox comboProbTur;
        public DevExpress.XtraEditors.ButtonEdit beBarkod;
        public System.Windows.Forms.ComboBox comboSeriNo;
        public System.Windows.Forms.DateTimePicker dtTeslim;
        public System.Windows.Forms.DateTimePicker dtOnay;
        public System.Windows.Forms.DateTimePicker dtGiris;
        public DevExpress.XtraEditors.TextEdit txtCevap3;
        public DevExpress.XtraEditors.TextEdit txtSoru3;
        public DevExpress.XtraEditors.TextEdit txtCevap2;
        public DevExpress.XtraEditors.TextEdit txtSoru2;
        public DevExpress.XtraEditors.TextEdit txtCevap1;
        public DevExpress.XtraEditors.TextEdit txtSoru1;
        public System.Windows.Forms.NumericUpDown numericUpDown1;
        public System.Windows.Forms.ComboBox comboKonsol;
        public System.Windows.Forms.ComboBox comboIsletim;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem düzenToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        public DevExpress.XtraEditors.PanelControl panelControl1;
        public DevExpress.XtraEditors.SimpleButton bGorev;
        public DevExpress.XtraEditors.CheckEdit cTeslim;
        public DevExpress.XtraEditors.CheckEdit cOnay;
        public DevExpress.XtraEditors.LabelControl labelControl6;
        public DevExpress.XtraEditors.LabelControl labelControl5;
        public DevExpress.XtraEditors.LabelControl labelControl4;
        public DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraEditors.LabelControl labelControl2;
        public DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.PanelControl panelControl2;
        public DevExpress.XtraEditors.PanelControl panelControl3;
        public DevExpress.XtraEditors.LabelControl labelControl7;
        public DevExpress.XtraEditors.PanelControl panelControl4;
        public DevExpress.XtraEditors.ColorPickEdit colorPickEdit3;
        public DevExpress.XtraEditors.ColorPickEdit colorPickEdit2;
        public DevExpress.XtraEditors.ColorPickEdit colorPickEdit1;
        public DevExpress.XtraEditors.LabelControl labelControl24;
        public DevExpress.XtraEditors.PanelControl panelControl5;
        public DevExpress.XtraEditors.SimpleButton bKapat;
        public DevExpress.XtraEditors.SimpleButton bHesapMakinesi;
        public DevExpress.XtraEditors.SimpleButton bYazdir;
        public DevExpress.XtraEditors.SimpleButton bGuncelle;
        public DevExpress.XtraEditors.SimpleButton bKaydet;
        public DevExpress.XtraEditors.LabelControl labelControl21;
        public System.Windows.Forms.RadioButton radioButton3;
        public System.Windows.Forms.RadioButton radioButton2;
        public System.Windows.Forms.RadioButton radioButton1;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.ToolStripMenuItem yenileToolStripMenuItem;
        public DevExpress.XtraEditors.SimpleButton simpleButton6;
        public DevExpress.XtraEditors.SimpleButton simpleButton5;
        public DevExpress.XtraEditors.SimpleButton bEposta;
        public DevExpress.XtraEditors.SimpleButton bSms;
        public DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        public DevExpress.XtraEditors.PanelControl panelControl7;
        public DevExpress.XtraEditors.GroupControl groupControl2;
        public DevExpress.XtraEditors.LabelControl labelControl26;
        public DevExpress.XtraEditors.LabelControl labelControl25;
        public DevExpress.XtraEditors.LabelControl labelControl20;
        public DevExpress.XtraEditors.LabelControl labelControl19;
        public DevExpress.XtraEditors.LabelControl labelControl23;
        public DevExpress.XtraEditors.LabelControl labelControl22;
        public System.Windows.Forms.RichTextBox richTextBox1;
        public DevExpress.XtraEditors.SimpleButton bProb;
        public DevExpress.XtraEditors.LabelControl labelControl18;
        public DevExpress.XtraEditors.PanelControl panelControl6;
        public DevExpress.XtraEditors.GroupControl groupControl1;
        public DevExpress.XtraEditors.BarCodeControl barCodeControl1;
        public DevExpress.XtraEditors.SimpleButton simpleButton4;
        public DevExpress.XtraEditors.SimpleButton simpleButton3;
        public DevExpress.XtraEditors.SimpleButton simpleButton2;
        public DevExpress.XtraEditors.SimpleButton simpleButton1;
        public DevExpress.XtraEditors.SimpleButton bGaranti;
        public DevExpress.XtraEditors.SimpleButton bIslem;
        public DevExpress.XtraEditors.SimpleButton bEkip;
        public DevExpress.XtraGrid.GridControl gridIsci;
        public DevExpress.XtraEditors.LabelControl labelControl17;
        public DevExpress.XtraEditors.LabelControl labelControl16;
        public DevExpress.XtraEditors.LabelControl labelControl15;
        public DevExpress.XtraEditors.LabelControl labelControl14;
        public DevExpress.XtraEditors.LabelControl labelControl13;
        public DevExpress.XtraEditors.LabelControl labelControl12;
        public DevExpress.XtraEditors.LabelControl labelControl11;
        public DevExpress.XtraEditors.LabelControl labelControl10;
        public DevExpress.XtraEditors.LabelControl labelControl9;
        public DevExpress.XtraEditors.LabelControl labelControl8;
        public DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        public System.Windows.Forms.TextBox textModel;
        public System.Windows.Forms.CheckBox checkDiger;
        private System.Windows.Forms.DateTimePicker dtTaahhüt;
        public DevExpress.XtraEditors.LabelControl labelControl27;
        private DevExpress.XtraEditors.SimpleButton btnYenile;

    }
}
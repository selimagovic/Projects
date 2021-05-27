namespace YemekhaneTakipSistemi
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kullaniciHakkindaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkindaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisButton = new System.Windows.Forms.Button();
            this.kullaniciGroupBox = new System.Windows.Forms.GroupBox();
            this.sonSaatLabel = new System.Windows.Forms.Label();
            this.mevBakiyeLabel = new System.Windows.Forms.Label();
            this.bakiyeLabel = new System.Windows.Forms.Label();
            this.girisLabel = new System.Windows.Forms.Label();
            this.sonGirisLabel = new System.Windows.Forms.Label();
            this.soyadLabel = new System.Windows.Forms.Label();
            this.adLabel = new System.Windows.Forms.Label();
            this.yemekTab = new System.Windows.Forms.TabPage();
            this.gosterButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yemekIptalTab = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.aksamIptalCB = new System.Windows.Forms.CheckBox();
            this.ogleIptalCB = new System.Windows.Forms.CheckBox();
            this.kahvaltiIptalCB = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.iptalTarihine = new System.Windows.Forms.DateTimePicker();
            this.iptalButton = new System.Windows.Forms.Button();
            this.iptalTarihinden = new System.Windows.Forms.DateTimePicker();
            this.yemekSipTab = new System.Windows.Forms.TabPage();
            this.yemekSipGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tarihine = new System.Windows.Forms.DateTimePicker();
            this.ekleButton = new System.Windows.Forms.Button();
            this.tarihinden = new System.Windows.Forms.DateTimePicker();
            this.aksamCheckBox = new System.Windows.Forms.CheckBox();
            this.ogleCheckBox = new System.Windows.Forms.CheckBox();
            this.kahvCheckBox = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.anologClockControl1 = new YemekhaneTakipSistemi.AnologClockControl();
            this.menuStrip1.SuspendLayout();
            this.kullaniciGroupBox.SuspendLayout();
            this.yemekTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.yemekIptalTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.yemekSipTab.SuspendLayout();
            this.yemekSipGroupBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullaniciHakkindaToolStripMenuItem,
            this.hakkindaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(876, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kullaniciHakkindaToolStripMenuItem
            // 
            this.kullaniciHakkindaToolStripMenuItem.ForeColor = System.Drawing.Color.Gold;
            this.kullaniciHakkindaToolStripMenuItem.Name = "kullaniciHakkindaToolStripMenuItem";
            this.kullaniciHakkindaToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.kullaniciHakkindaToolStripMenuItem.Text = "Kullanici Hakkinda";
            this.kullaniciHakkindaToolStripMenuItem.Click += new System.EventHandler(this.kullaniciHakkindaToolStripMenuItem_Click);
            // 
            // hakkindaToolStripMenuItem
            // 
            this.hakkindaToolStripMenuItem.ForeColor = System.Drawing.Color.Gold;
            this.hakkindaToolStripMenuItem.Name = "hakkindaToolStripMenuItem";
            this.hakkindaToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.hakkindaToolStripMenuItem.Text = "Program Hakkinda";
            this.hakkindaToolStripMenuItem.Click += new System.EventHandler(this.hakkindaToolStripMenuItem_Click);
            // 
            // cikisButton
            // 
            this.cikisButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cikisButton.BackColor = System.Drawing.Color.Red;
            this.cikisButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cikisButton.BackgroundImage")));
            this.cikisButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cikisButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cikisButton.Location = new System.Drawing.Point(14, 461);
            this.cikisButton.Name = "cikisButton";
            this.cikisButton.Size = new System.Drawing.Size(194, 52);
            this.cikisButton.TabIndex = 5;
            this.cikisButton.UseVisualStyleBackColor = false;
            this.cikisButton.Click += new System.EventHandler(this.cikisButton_Click);
            // 
            // kullaniciGroupBox
            // 
            this.kullaniciGroupBox.Controls.Add(this.sonSaatLabel);
            this.kullaniciGroupBox.Controls.Add(this.mevBakiyeLabel);
            this.kullaniciGroupBox.Controls.Add(this.bakiyeLabel);
            this.kullaniciGroupBox.Controls.Add(this.girisLabel);
            this.kullaniciGroupBox.Controls.Add(this.sonGirisLabel);
            this.kullaniciGroupBox.Controls.Add(this.soyadLabel);
            this.kullaniciGroupBox.Controls.Add(this.adLabel);
            this.kullaniciGroupBox.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullaniciGroupBox.ForeColor = System.Drawing.Color.Gold;
            this.kullaniciGroupBox.Location = new System.Drawing.Point(14, 80);
            this.kullaniciGroupBox.Name = "kullaniciGroupBox";
            this.kullaniciGroupBox.Size = new System.Drawing.Size(213, 242);
            this.kullaniciGroupBox.TabIndex = 6;
            this.kullaniciGroupBox.TabStop = false;
            this.kullaniciGroupBox.Text = "Kullanici Bilgileri";
            // 
            // sonSaatLabel
            // 
            this.sonSaatLabel.AutoSize = true;
            this.sonSaatLabel.Location = new System.Drawing.Point(16, 154);
            this.sonSaatLabel.Name = "sonSaatLabel";
            this.sonSaatLabel.Size = new System.Drawing.Size(134, 25);
            this.sonSaatLabel.TabIndex = 6;
            this.sonSaatLabel.Text = "Son Giris Saat";
            // 
            // mevBakiyeLabel
            // 
            this.mevBakiyeLabel.AutoSize = true;
            this.mevBakiyeLabel.Location = new System.Drawing.Point(19, 204);
            this.mevBakiyeLabel.Name = "mevBakiyeLabel";
            this.mevBakiyeLabel.Size = new System.Drawing.Size(136, 25);
            this.mevBakiyeLabel.TabIndex = 5;
            this.mevBakiyeLabel.Text = "Mevcut Bakiye";
            // 
            // bakiyeLabel
            // 
            this.bakiyeLabel.AutoSize = true;
            this.bakiyeLabel.Location = new System.Drawing.Point(16, 182);
            this.bakiyeLabel.Name = "bakiyeLabel";
            this.bakiyeLabel.Size = new System.Drawing.Size(150, 25);
            this.bakiyeLabel.TabIndex = 4;
            this.bakiyeLabel.Text = "[Mevcut Bakiye]";
            // 
            // girisLabel
            // 
            this.girisLabel.AutoSize = true;
            this.girisLabel.Location = new System.Drawing.Point(16, 129);
            this.girisLabel.Name = "girisLabel";
            this.girisLabel.Size = new System.Drawing.Size(90, 25);
            this.girisLabel.TabIndex = 3;
            this.girisLabel.Text = "Son Giris";
            // 
            // sonGirisLabel
            // 
            this.sonGirisLabel.AutoSize = true;
            this.sonGirisLabel.Location = new System.Drawing.Point(16, 102);
            this.sonGirisLabel.Name = "sonGirisLabel";
            this.sonGirisLabel.Size = new System.Drawing.Size(104, 25);
            this.sonGirisLabel.TabIndex = 2;
            this.sonGirisLabel.Text = "[Son Giris]";
            // 
            // soyadLabel
            // 
            this.soyadLabel.AutoSize = true;
            this.soyadLabel.Location = new System.Drawing.Point(16, 69);
            this.soyadLabel.Name = "soyadLabel";
            this.soyadLabel.Size = new System.Drawing.Size(63, 25);
            this.soyadLabel.TabIndex = 1;
            this.soyadLabel.Text = "Soyad";
            // 
            // adLabel
            // 
            this.adLabel.AutoSize = true;
            this.adLabel.Location = new System.Drawing.Point(16, 42);
            this.adLabel.Name = "adLabel";
            this.adLabel.Size = new System.Drawing.Size(36, 25);
            this.adLabel.TabIndex = 0;
            this.adLabel.Text = "Ad";
            // 
            // yemekTab
            // 
            this.yemekTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yemekTab.BackgroundImage")));
            this.yemekTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yemekTab.Controls.Add(this.gosterButton);
            this.yemekTab.Controls.Add(this.dataGridView1);
            this.yemekTab.Location = new System.Drawing.Point(4, 24);
            this.yemekTab.Name = "yemekTab";
            this.yemekTab.Padding = new System.Windows.Forms.Padding(3);
            this.yemekTab.Size = new System.Drawing.Size(618, 413);
            this.yemekTab.TabIndex = 3;
            this.yemekTab.Text = "Yemek Bilgileri";
            this.yemekTab.UseVisualStyleBackColor = true;
            // 
            // gosterButton
            // 
            this.gosterButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.gosterButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gosterButton.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gosterButton.ForeColor = System.Drawing.Color.Lime;
            this.gosterButton.Location = new System.Drawing.Point(551, 3);
            this.gosterButton.Name = "gosterButton";
            this.gosterButton.Size = new System.Drawing.Size(64, 407);
            this.gosterButton.TabIndex = 1;
            this.gosterButton.Text = "G O S T E R";
            this.gosterButton.UseVisualStyleBackColor = true;
            this.gosterButton.Click += new System.EventHandler(this.gosterButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkRed;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(542, 407);
            this.dataGridView1.TabIndex = 0;
            // 
            // yemekIptalTab
            // 
            this.yemekIptalTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yemekIptalTab.BackgroundImage")));
            this.yemekIptalTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yemekIptalTab.Controls.Add(this.groupBox2);
            this.yemekIptalTab.Location = new System.Drawing.Point(4, 24);
            this.yemekIptalTab.Name = "yemekIptalTab";
            this.yemekIptalTab.Padding = new System.Windows.Forms.Padding(3);
            this.yemekIptalTab.Size = new System.Drawing.Size(618, 413);
            this.yemekIptalTab.TabIndex = 1;
            this.yemekIptalTab.Text = "Yemek Iptal";
            this.yemekIptalTab.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.aksamIptalCB);
            this.groupBox2.Controls.Add(this.ogleIptalCB);
            this.groupBox2.Controls.Add(this.kahvaltiIptalCB);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.iptalTarihine);
            this.groupBox2.Controls.Add(this.iptalButton);
            this.groupBox2.Controls.Add(this.iptalTarihinden);
            this.groupBox2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Gold;
            this.groupBox2.Location = new System.Drawing.Point(387, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 283);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Iptal Etmek istediginiz ogunleri isaretleyiniz : ";
            // 
            // aksamIptalCB
            // 
            this.aksamIptalCB.AutoSize = true;
            this.aksamIptalCB.Location = new System.Drawing.Point(16, 111);
            this.aksamIptalCB.Name = "aksamIptalCB";
            this.aksamIptalCB.Size = new System.Drawing.Size(168, 22);
            this.aksamIptalCB.TabIndex = 10;
            this.aksamIptalCB.Text = "Aksam Yemegi - 3.50 TL";
            this.aksamIptalCB.UseVisualStyleBackColor = true;
            // 
            // ogleIptalCB
            // 
            this.ogleIptalCB.AutoSize = true;
            this.ogleIptalCB.Location = new System.Drawing.Point(46, 83);
            this.ogleIptalCB.Name = "ogleIptalCB";
            this.ogleIptalCB.Size = new System.Drawing.Size(160, 22);
            this.ogleIptalCB.TabIndex = 9;
            this.ogleIptalCB.Text = "Ogle Yemegi -  3.25 TL";
            this.ogleIptalCB.UseVisualStyleBackColor = true;
            // 
            // kahvaltiIptalCB
            // 
            this.kahvaltiIptalCB.AutoSize = true;
            this.kahvaltiIptalCB.Location = new System.Drawing.Point(70, 55);
            this.kahvaltiIptalCB.Name = "kahvaltiIptalCB";
            this.kahvaltiIptalCB.Size = new System.Drawing.Size(136, 22);
            this.kahvaltiIptalCB.TabIndex = 8;
            this.kahvaltiIptalCB.Text = "Kahvalti - 2.25 TL";
            this.kahvaltiIptalCB.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(55, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "To -";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(7, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tarihinden -";
            // 
            // iptalTarihine
            // 
            this.iptalTarihine.CalendarMonthBackground = System.Drawing.SystemColors.Menu;
            this.iptalTarihine.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.iptalTarihine.Location = new System.Drawing.Point(91, 205);
            this.iptalTarihine.Name = "iptalTarihine";
            this.iptalTarihine.Size = new System.Drawing.Size(128, 25);
            this.iptalTarihine.TabIndex = 5;
            // 
            // iptalButton
            // 
            this.iptalButton.BackColor = System.Drawing.Color.Black;
            this.iptalButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iptalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iptalButton.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iptalButton.Location = new System.Drawing.Point(3, 250);
            this.iptalButton.Name = "iptalButton";
            this.iptalButton.Size = new System.Drawing.Size(219, 30);
            this.iptalButton.TabIndex = 4;
            this.iptalButton.Text = "SIL";
            this.iptalButton.UseVisualStyleBackColor = false;
            this.iptalButton.Click += new System.EventHandler(this.iptalButton_Click);
            // 
            // iptalTarihinden
            // 
            this.iptalTarihinden.CalendarFont = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iptalTarihinden.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.iptalTarihinden.Location = new System.Drawing.Point(91, 174);
            this.iptalTarihinden.Name = "iptalTarihinden";
            this.iptalTarihinden.Size = new System.Drawing.Size(128, 25);
            this.iptalTarihinden.TabIndex = 3;
            // 
            // yemekSipTab
            // 
            this.yemekSipTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yemekSipTab.BackgroundImage")));
            this.yemekSipTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yemekSipTab.Controls.Add(this.yemekSipGroupBox);
            this.yemekSipTab.Location = new System.Drawing.Point(4, 24);
            this.yemekSipTab.Name = "yemekSipTab";
            this.yemekSipTab.Padding = new System.Windows.Forms.Padding(3);
            this.yemekSipTab.Size = new System.Drawing.Size(618, 413);
            this.yemekSipTab.TabIndex = 0;
            this.yemekSipTab.Text = "Yemek Siparis";
            this.yemekSipTab.UseVisualStyleBackColor = true;
            // 
            // yemekSipGroupBox
            // 
            this.yemekSipGroupBox.Controls.Add(this.label2);
            this.yemekSipGroupBox.Controls.Add(this.label1);
            this.yemekSipGroupBox.Controls.Add(this.tarihine);
            this.yemekSipGroupBox.Controls.Add(this.ekleButton);
            this.yemekSipGroupBox.Controls.Add(this.tarihinden);
            this.yemekSipGroupBox.Controls.Add(this.aksamCheckBox);
            this.yemekSipGroupBox.Controls.Add(this.ogleCheckBox);
            this.yemekSipGroupBox.Controls.Add(this.kahvCheckBox);
            this.yemekSipGroupBox.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yemekSipGroupBox.ForeColor = System.Drawing.Color.Gold;
            this.yemekSipGroupBox.Location = new System.Drawing.Point(387, 104);
            this.yemekSipGroupBox.Name = "yemekSipGroupBox";
            this.yemekSipGroupBox.Size = new System.Drawing.Size(225, 283);
            this.yemekSipGroupBox.TabIndex = 0;
            this.yemekSipGroupBox.TabStop = false;
            this.yemekSipGroupBox.Text = "Almak istediginiz ogunleri isaretleyiniz : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(55, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "To -";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tarihinden -";
            // 
            // tarihine
            // 
            this.tarihine.CalendarMonthBackground = System.Drawing.SystemColors.Menu;
            this.tarihine.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tarihine.Location = new System.Drawing.Point(91, 205);
            this.tarihine.Name = "tarihine";
            this.tarihine.Size = new System.Drawing.Size(128, 25);
            this.tarihine.TabIndex = 5;
            // 
            // ekleButton
            // 
            this.ekleButton.BackColor = System.Drawing.Color.Black;
            this.ekleButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ekleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ekleButton.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ekleButton.Location = new System.Drawing.Point(3, 250);
            this.ekleButton.Name = "ekleButton";
            this.ekleButton.Size = new System.Drawing.Size(219, 30);
            this.ekleButton.TabIndex = 4;
            this.ekleButton.Text = "EKLE";
            this.ekleButton.UseVisualStyleBackColor = false;
            this.ekleButton.Click += new System.EventHandler(this.ekleButton_Click);
            // 
            // tarihinden
            // 
            this.tarihinden.CalendarFont = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarihinden.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tarihinden.Location = new System.Drawing.Point(91, 174);
            this.tarihinden.Name = "tarihinden";
            this.tarihinden.Size = new System.Drawing.Size(128, 25);
            this.tarihinden.TabIndex = 3;
            // 
            // aksamCheckBox
            // 
            this.aksamCheckBox.AutoSize = true;
            this.aksamCheckBox.Location = new System.Drawing.Point(29, 106);
            this.aksamCheckBox.Name = "aksamCheckBox";
            this.aksamCheckBox.Size = new System.Drawing.Size(168, 22);
            this.aksamCheckBox.TabIndex = 2;
            this.aksamCheckBox.Text = "Aksam Yemegi - 3.50 TL";
            this.aksamCheckBox.UseVisualStyleBackColor = true;
            // 
            // ogleCheckBox
            // 
            this.ogleCheckBox.AutoSize = true;
            this.ogleCheckBox.Location = new System.Drawing.Point(59, 78);
            this.ogleCheckBox.Name = "ogleCheckBox";
            this.ogleCheckBox.Size = new System.Drawing.Size(160, 22);
            this.ogleCheckBox.TabIndex = 1;
            this.ogleCheckBox.Text = "Ogle Yemegi -  3.25 TL";
            this.ogleCheckBox.UseVisualStyleBackColor = true;
            // 
            // kahvCheckBox
            // 
            this.kahvCheckBox.AutoSize = true;
            this.kahvCheckBox.Location = new System.Drawing.Point(83, 50);
            this.kahvCheckBox.Name = "kahvCheckBox";
            this.kahvCheckBox.Size = new System.Drawing.Size(136, 22);
            this.kahvCheckBox.TabIndex = 0;
            this.kahvCheckBox.Text = "Kahvalti - 2.25 TL";
            this.kahvCheckBox.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.yemekSipTab);
            this.tabControl1.Controls.Add(this.yemekIptalTab);
            this.tabControl1.Controls.Add(this.yemekTab);
            this.tabControl1.Location = new System.Drawing.Point(238, 72);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(626, 441);
            this.tabControl1.TabIndex = 3;
            // 
            // anologClockControl1
            // 
            this.anologClockControl1.Draw1MinuteTicks = true;
            this.anologClockControl1.Draw5MinuteTicks = true;
            this.anologClockControl1.HourHandColor = System.Drawing.Color.Aqua;
            this.anologClockControl1.Location = new System.Drawing.Point(53, 328);
            this.anologClockControl1.MinuteHandColor = System.Drawing.Color.LimeGreen;
            this.anologClockControl1.Name = "anologClockControl1";
            this.anologClockControl1.SecondHandColor = System.Drawing.Color.Black;
            this.anologClockControl1.Size = new System.Drawing.Size(127, 127);
            this.anologClockControl1.TabIndex = 7;
            this.anologClockControl1.TicksColor = System.Drawing.Color.Aquamarine;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(876, 528);
            this.ControlBox = false;
            //this.Controls.Add(this.anologClockControl1);
            this.Controls.Add(this.kullaniciGroupBox);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cikisButton);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yemekhane Ana Sayfa";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.kullaniciGroupBox.ResumeLayout(false);
            this.kullaniciGroupBox.PerformLayout();
            this.yemekTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.yemekIptalTab.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.yemekSipTab.ResumeLayout(false);
            this.yemekSipGroupBox.ResumeLayout(false);
            this.yemekSipGroupBox.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kullaniciHakkindaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkindaToolStripMenuItem;
        private System.Windows.Forms.Button cikisButton;
        private System.Windows.Forms.GroupBox kullaniciGroupBox;
        private System.Windows.Forms.Label mevBakiyeLabel;
        private System.Windows.Forms.Label bakiyeLabel;
        private System.Windows.Forms.Label girisLabel;
        private System.Windows.Forms.Label sonGirisLabel;
        private System.Windows.Forms.Label soyadLabel;
        private System.Windows.Forms.Label adLabel;
        private System.Windows.Forms.Label sonSaatLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.CheckBox kahvCheckBox;
        private System.Windows.Forms.CheckBox ogleCheckBox;
        private System.Windows.Forms.CheckBox aksamCheckBox;
        private System.Windows.Forms.DateTimePicker tarihinden;
        private System.Windows.Forms.Button ekleButton;
        private System.Windows.Forms.DateTimePicker tarihine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox yemekSipGroupBox;
        private System.Windows.Forms.TabPage yemekSipTab;
        private System.Windows.Forms.DateTimePicker iptalTarihinden;
        private System.Windows.Forms.Button iptalButton;
        private System.Windows.Forms.DateTimePicker iptalTarihine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox kahvaltiIptalCB;
        private System.Windows.Forms.CheckBox ogleIptalCB;
        private System.Windows.Forms.CheckBox aksamIptalCB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage yemekIptalTab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button gosterButton;
        private System.Windows.Forms.TabPage yemekTab;
        private AnologClockControl anologClockControl1;
    }
}
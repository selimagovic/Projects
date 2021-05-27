namespace YemekhaneTakipSistemi
{
    partial class GirisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisForm));
            this.ogrenciRadioButton = new System.Windows.Forms.RadioButton();
            this.personelRadioButton = new System.Windows.Forms.RadioButton();
            this.anaLabel = new System.Windows.Forms.Label();
            this.geriButton = new System.Windows.Forms.Button();
            this.girisButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sifreTextBox = new System.Windows.Forms.TextBox();
            this.gkartTextBox = new System.Windows.Forms.TextBox();
            this.sifreLabel = new System.Windows.Forms.Label();
            this.kartLabel = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.anologClockControl2 = new YemekhaneTakipSistemi.AnologClockControl();
            this.anologClockControl1 = new YemekhaneTakipSistemi.AnologClockControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ogrenciRadioButton
            // 
            this.ogrenciRadioButton.AutoSize = true;
            this.ogrenciRadioButton.BackColor = System.Drawing.Color.DarkGreen;
            this.ogrenciRadioButton.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ogrenciRadioButton.ForeColor = System.Drawing.Color.Chartreuse;
            this.ogrenciRadioButton.Location = new System.Drawing.Point(492, 104);
            this.ogrenciRadioButton.Name = "ogrenciRadioButton";
            this.ogrenciRadioButton.Size = new System.Drawing.Size(69, 22);
            this.ogrenciRadioButton.TabIndex = 19;
            this.ogrenciRadioButton.Text = "Ogrenci";
            this.ogrenciRadioButton.UseVisualStyleBackColor = false;
            this.ogrenciRadioButton.CheckedChanged += new System.EventHandler(this.ogrenciRadioButton_CheckedChanged);
            // 
            // personelRadioButton
            // 
            this.personelRadioButton.AutoSize = true;
            this.personelRadioButton.Checked = true;
            this.personelRadioButton.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personelRadioButton.ForeColor = System.Drawing.Color.Chartreuse;
            this.personelRadioButton.Location = new System.Drawing.Point(309, 104);
            this.personelRadioButton.Name = "personelRadioButton";
            this.personelRadioButton.Size = new System.Drawing.Size(73, 22);
            this.personelRadioButton.TabIndex = 18;
            this.personelRadioButton.TabStop = true;
            this.personelRadioButton.Text = "Personel";
            this.personelRadioButton.UseVisualStyleBackColor = true;
            this.personelRadioButton.CheckedChanged += new System.EventHandler(this.personelRadioButton_CheckedChanged);
            // 
            // anaLabel
            // 
            this.anaLabel.AutoSize = true;
            this.anaLabel.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anaLabel.ForeColor = System.Drawing.Color.Chartreuse;
            this.anaLabel.Location = new System.Drawing.Point(294, 38);
            this.anaLabel.Name = "anaLabel";
            this.anaLabel.Size = new System.Drawing.Size(266, 22);
            this.anaLabel.TabIndex = 17;
            this.anaLabel.Text = "Yemekhanenin Giris Sayfasi";
            // 
            // geriButton
            // 
            this.geriButton.BackColor = System.Drawing.Color.DarkGreen;
            this.geriButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geriButton.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geriButton.ForeColor = System.Drawing.Color.Chartreuse;
            this.geriButton.Location = new System.Drawing.Point(301, 232);
            this.geriButton.Name = "geriButton";
            this.geriButton.Size = new System.Drawing.Size(94, 43);
            this.geriButton.TabIndex = 16;
            this.geriButton.Text = "Geri";
            this.geriButton.UseVisualStyleBackColor = false;
            this.geriButton.Click += new System.EventHandler(this.geriButton_Click);
            // 
            // girisButton
            // 
            this.girisButton.BackColor = System.Drawing.Color.DarkGreen;
            this.girisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girisButton.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.girisButton.ForeColor = System.Drawing.Color.Chartreuse;
            this.girisButton.Location = new System.Drawing.Point(471, 232);
            this.girisButton.Name = "girisButton";
            this.girisButton.Size = new System.Drawing.Size(90, 42);
            this.girisButton.TabIndex = 15;
            this.girisButton.Text = "Giris";
            this.girisButton.UseVisualStyleBackColor = false;
            this.girisButton.Click += new System.EventHandler(this.girisButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.BackColor = System.Drawing.Color.ForestGreen;
            this.sifreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sifreTextBox.ForeColor = System.Drawing.Color.Aqua;
            this.sifreTextBox.Location = new System.Drawing.Point(423, 175);
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.PasswordChar = '*';
            this.sifreTextBox.Size = new System.Drawing.Size(138, 13);
            this.sifreTextBox.TabIndex = 13;
            this.sifreTextBox.UseSystemPasswordChar = true;
            // 
            // gkartTextBox
            // 
            this.gkartTextBox.BackColor = System.Drawing.Color.ForestGreen;
            this.gkartTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gkartTextBox.ForeColor = System.Drawing.Color.Aqua;
            this.gkartTextBox.Location = new System.Drawing.Point(423, 149);
            this.gkartTextBox.MaxLength = 11;
            this.gkartTextBox.Name = "gkartTextBox";
            this.gkartTextBox.Size = new System.Drawing.Size(138, 13);
            this.gkartTextBox.TabIndex = 12;
            this.gkartTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gkartTextBox_KeyPress);
            // 
            // sifreLabel
            // 
            this.sifreLabel.AutoSize = true;
            this.sifreLabel.BackColor = System.Drawing.Color.DarkGreen;
            this.sifreLabel.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifreLabel.ForeColor = System.Drawing.Color.Chartreuse;
            this.sifreLabel.Location = new System.Drawing.Point(337, 172);
            this.sifreLabel.Name = "sifreLabel";
            this.sifreLabel.Size = new System.Drawing.Size(71, 18);
            this.sifreLabel.TabIndex = 11;
            this.sifreLabel.Text = "Password :";
            // 
            // kartLabel
            // 
            this.kartLabel.AutoSize = true;
            this.kartLabel.BackColor = System.Drawing.Color.DarkGreen;
            this.kartLabel.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kartLabel.ForeColor = System.Drawing.Color.Chartreuse;
            this.kartLabel.Location = new System.Drawing.Point(314, 146);
            this.kartLabel.Name = "kartLabel";
            this.kartLabel.Size = new System.Drawing.Size(94, 18);
            this.kartLabel.TabIndex = 10;
            this.kartLabel.Text = "Card Number :";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Chartreuse;
            this.linkLabel1.Location = new System.Drawing.Point(468, 205);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(91, 13);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot password?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // anologClockControl2
            // 
            this.anologClockControl2.BackColor = System.Drawing.Color.Transparent;
            this.anologClockControl2.Draw1MinuteTicks = true;
            this.anologClockControl2.Draw5MinuteTicks = true;
            this.anologClockControl2.HourHandColor = System.Drawing.Color.Aqua;
            this.anologClockControl2.Location = new System.Drawing.Point(406, 78);
            this.anologClockControl2.MinuteHandColor = System.Drawing.Color.LimeGreen;
            this.anologClockControl2.Name = "anologClockControl2";
            this.anologClockControl2.SecondHandColor = System.Drawing.Color.Black;
            this.anologClockControl2.Size = new System.Drawing.Size(65, 65);
            this.anologClockControl2.TabIndex = 21;
            this.anologClockControl2.TicksColor = System.Drawing.Color.Aquamarine;
            // 
            // anologClockControl1
            // 
            this.anologClockControl1.BackColor = System.Drawing.Color.Transparent;
            this.anologClockControl1.Draw1MinuteTicks = true;
            this.anologClockControl1.Draw5MinuteTicks = true;
            this.anologClockControl1.HourHandColor = System.Drawing.Color.Aqua;
            this.anologClockControl1.Location = new System.Drawing.Point(412, 92);
            this.anologClockControl1.MinuteHandColor = System.Drawing.Color.LimeGreen;
            this.anologClockControl1.Name = "anologClockControl1";
            this.anologClockControl1.SecondHandColor = System.Drawing.Color.Black;
            this.anologClockControl1.Size = new System.Drawing.Size(51, 51);
            this.anologClockControl1.TabIndex = 21;
            this.anologClockControl1.TicksColor = System.Drawing.Color.Aquamarine;
            // 
            // GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(577, 287);
            this.ControlBox = false;
            this.Controls.Add(this.anologClockControl1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.ogrenciRadioButton);
            this.Controls.Add(this.personelRadioButton);
            this.Controls.Add(this.anaLabel);
            this.Controls.Add(this.geriButton);
            this.Controls.Add(this.girisButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sifreTextBox);
            this.Controls.Add(this.gkartTextBox);
            this.Controls.Add(this.sifreLabel);
            this.Controls.Add(this.kartLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GirisForm";
            this.Load += new System.EventHandler(this.GirisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton ogrenciRadioButton;
        private System.Windows.Forms.RadioButton personelRadioButton;
        private System.Windows.Forms.Label anaLabel;
        private System.Windows.Forms.Button geriButton;
        private System.Windows.Forms.Button girisButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox sifreTextBox;
        private System.Windows.Forms.TextBox gkartTextBox;
        private System.Windows.Forms.Label sifreLabel;
        private System.Windows.Forms.Label kartLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private AnologClockControl anologClockControl2;
        private AnologClockControl anologClockControl1;
    }
}
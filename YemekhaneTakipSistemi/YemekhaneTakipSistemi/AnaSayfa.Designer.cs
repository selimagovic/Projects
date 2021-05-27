namespace YemekhaneTakipSistemi
{
    partial class AnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.misafirButton = new System.Windows.Forms.Button();
            this.girisButton = new System.Windows.Forms.Button();
            this.uyeButton = new System.Windows.Forms.Button();
            this.enRadioButton = new System.Windows.Forms.RadioButton();
            this.trRadioButton = new System.Windows.Forms.RadioButton();
            this.digitalClockControl1 = new YemekhaneTakipSistemi.DigitalClockControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(365, 334);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // misafirButton
            // 
            this.misafirButton.BackColor = System.Drawing.Color.Transparent;
            this.misafirButton.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.misafirButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.misafirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.misafirButton.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.misafirButton.ForeColor = System.Drawing.Color.Gold;
            this.misafirButton.Location = new System.Drawing.Point(383, 298);
            this.misafirButton.Name = "misafirButton";
            this.misafirButton.Size = new System.Drawing.Size(134, 51);
            this.misafirButton.TabIndex = 7;
            this.misafirButton.Text = "Misafir";
            this.misafirButton.UseVisualStyleBackColor = false;
            this.misafirButton.Click += new System.EventHandler(this.misafirButton_Click);
            // 
            // girisButton
            // 
            this.girisButton.BackColor = System.Drawing.Color.Transparent;
            this.girisButton.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.girisButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.girisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girisButton.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.girisButton.ForeColor = System.Drawing.Color.Gold;
            this.girisButton.Location = new System.Drawing.Point(383, 241);
            this.girisButton.Name = "girisButton";
            this.girisButton.Size = new System.Drawing.Size(134, 51);
            this.girisButton.TabIndex = 6;
            this.girisButton.Text = "Giris";
            this.girisButton.UseVisualStyleBackColor = false;
            this.girisButton.Click += new System.EventHandler(this.girisButton_Click);
            // 
            // uyeButton
            // 
            this.uyeButton.BackColor = System.Drawing.Color.Transparent;
            this.uyeButton.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.uyeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.uyeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uyeButton.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uyeButton.ForeColor = System.Drawing.Color.Gold;
            this.uyeButton.Location = new System.Drawing.Point(383, 184);
            this.uyeButton.Name = "uyeButton";
            this.uyeButton.Size = new System.Drawing.Size(134, 51);
            this.uyeButton.TabIndex = 5;
            this.uyeButton.Text = "Uye Ol";
            this.uyeButton.UseVisualStyleBackColor = false;
            this.uyeButton.Click += new System.EventHandler(this.uyeButton_Click);
            // 
            // enRadioButton
            // 
            this.enRadioButton.AutoSize = true;
            this.enRadioButton.ForeColor = System.Drawing.Color.Gold;
            this.enRadioButton.Location = new System.Drawing.Point(429, 13);
            this.enRadioButton.Name = "enRadioButton";
            this.enRadioButton.Size = new System.Drawing.Size(40, 17);
            this.enRadioButton.TabIndex = 8;
            this.enRadioButton.Text = "EN";
            this.enRadioButton.UseVisualStyleBackColor = true;
            this.enRadioButton.CheckedChanged += new System.EventHandler(this.enRadioButton_CheckedChanged);
            // 
            // trRadioButton
            // 
            this.trRadioButton.AutoSize = true;
            this.trRadioButton.Checked = true;
            this.trRadioButton.ForeColor = System.Drawing.Color.Gold;
            this.trRadioButton.Location = new System.Drawing.Point(477, 13);
            this.trRadioButton.Name = "trRadioButton";
            this.trRadioButton.Size = new System.Drawing.Size(40, 17);
            this.trRadioButton.TabIndex = 9;
            this.trRadioButton.TabStop = true;
            this.trRadioButton.Text = "TR";
            this.trRadioButton.UseVisualStyleBackColor = true;
            this.trRadioButton.CheckedChanged += new System.EventHandler(this.trRadioButton_CheckedChanged);
            // 
            // digitalClockControl1
            // 
            this.digitalClockControl1.BackColor = System.Drawing.Color.Transparent;
            this.digitalClockControl1.Location = new System.Drawing.Point(273, 12);
            this.digitalClockControl1.Name = "digitalClockControl1";
            this.digitalClockControl1.Size = new System.Drawing.Size(104, 38);
            this.digitalClockControl1.TabIndex = 10;
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(527, 359);
            this.Controls.Add(this.digitalClockControl1);
            this.Controls.Add(this.trRadioButton);
            this.Controls.Add(this.enRadioButton);
            this.Controls.Add(this.misafirButton);
            this.Controls.Add(this.girisButton);
            this.Controls.Add(this.uyeButton);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yemekhane Takip Programi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button misafirButton;
        private System.Windows.Forms.Button girisButton;
        private System.Windows.Forms.Button uyeButton;
        private System.Windows.Forms.RadioButton enRadioButton;
        private System.Windows.Forms.RadioButton trRadioButton;
        private DigitalClockControl digitalClockControl1;
    }
}


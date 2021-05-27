namespace Yetkili
{
    partial class YetkilininGirisSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YetkilininGirisSayfasi));
            this.girisButton = new System.Windows.Forms.Button();
            this.sifreLabel = new System.Windows.Forms.Label();
            this.yetkiliLabel = new System.Windows.Forms.Label();
            this.kartTextBox = new System.Windows.Forms.TextBox();
            this.sifreTextBox = new System.Windows.Forms.TextBox();
            this.enRadioButton = new System.Windows.Forms.RadioButton();
            this.trRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // girisButton
            // 
            this.girisButton.BackColor = System.Drawing.Color.Transparent;
            this.girisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girisButton.ForeColor = System.Drawing.Color.Transparent;
            this.girisButton.Location = new System.Drawing.Point(413, 184);
            this.girisButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.girisButton.Name = "girisButton";
            this.girisButton.Size = new System.Drawing.Size(141, 45);
            this.girisButton.TabIndex = 0;
            this.girisButton.Text = "G I R I S";
            this.girisButton.UseVisualStyleBackColor = false;
            this.girisButton.Click += new System.EventHandler(this.girisButton_Click);
            // 
            // sifreLabel
            // 
            this.sifreLabel.AutoSize = true;
            this.sifreLabel.BackColor = System.Drawing.Color.Transparent;
            this.sifreLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.sifreLabel.Location = new System.Drawing.Point(280, 142);
            this.sifreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sifreLabel.Name = "sifreLabel";
            this.sifreLabel.Size = new System.Drawing.Size(50, 20);
            this.sifreLabel.TabIndex = 1;
            this.sifreLabel.Text = "Sifre :";
            // 
            // yetkiliLabel
            // 
            this.yetkiliLabel.AutoSize = true;
            this.yetkiliLabel.BackColor = System.Drawing.Color.Transparent;
            this.yetkiliLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.yetkiliLabel.Location = new System.Drawing.Point(260, 94);
            this.yetkiliLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yetkiliLabel.Name = "yetkiliLabel";
            this.yetkiliLabel.Size = new System.Drawing.Size(69, 20);
            this.yetkiliLabel.TabIndex = 2;
            this.yetkiliLabel.Text = "Kart ID :";
            // 
            // kartTextBox
            // 
            this.kartTextBox.BackColor = System.Drawing.Color.SaddleBrown;
            this.kartTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kartTextBox.Location = new System.Drawing.Point(338, 89);
            this.kartTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kartTextBox.MaxLength = 11;
            this.kartTextBox.Name = "kartTextBox";
            this.kartTextBox.Size = new System.Drawing.Size(216, 28);
            this.kartTextBox.TabIndex = 3;
            this.kartTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kartTextBox_KeyPress);
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.BackColor = System.Drawing.Color.SaddleBrown;
            this.sifreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sifreTextBox.Location = new System.Drawing.Point(338, 140);
            this.sifreTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.Size = new System.Drawing.Size(216, 28);
            this.sifreTextBox.TabIndex = 4;
            this.sifreTextBox.UseSystemPasswordChar = true;
            // 
            // enRadioButton
            // 
            this.enRadioButton.AutoSize = true;
            this.enRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.enRadioButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.enRadioButton.Location = new System.Drawing.Point(439, 55);
            this.enRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enRadioButton.Name = "enRadioButton";
            this.enRadioButton.Size = new System.Drawing.Size(47, 24);
            this.enRadioButton.TabIndex = 5;
            this.enRadioButton.Text = "EN";
            this.enRadioButton.UseVisualStyleBackColor = false;
            this.enRadioButton.CheckedChanged += new System.EventHandler(this.enRadioButton_CheckedChanged_1);
            // 
            // trRadioButton
            // 
            this.trRadioButton.AutoSize = true;
            this.trRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.trRadioButton.Checked = true;
            this.trRadioButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.trRadioButton.Location = new System.Drawing.Point(507, 55);
            this.trRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trRadioButton.Name = "trRadioButton";
            this.trRadioButton.Size = new System.Drawing.Size(47, 24);
            this.trRadioButton.TabIndex = 6;
            this.trRadioButton.TabStop = true;
            this.trRadioButton.Text = "TR";
            this.trRadioButton.UseVisualStyleBackColor = false;
            this.trRadioButton.CheckedChanged += new System.EventHandler(this.trRadioButton_CheckedChanged_1);
            // 
            // YetkilininGirisSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(573, 243);
            this.Controls.Add(this.trRadioButton);
            this.Controls.Add(this.enRadioButton);
            this.Controls.Add(this.sifreTextBox);
            this.Controls.Add(this.kartTextBox);
            this.Controls.Add(this.yetkiliLabel);
            this.Controls.Add(this.sifreLabel);
            this.Controls.Add(this.girisButton);
            this.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "YetkilininGirisSayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YetkilininGirisSayfasi";
            this.Load += new System.EventHandler(this.YetkilininGirisSayfasi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button girisButton;
        private System.Windows.Forms.Label sifreLabel;
        private System.Windows.Forms.Label yetkiliLabel;
        private System.Windows.Forms.TextBox kartTextBox;
        private System.Windows.Forms.TextBox sifreTextBox;
        private System.Windows.Forms.RadioButton enRadioButton;
        private System.Windows.Forms.RadioButton trRadioButton;
    }
}
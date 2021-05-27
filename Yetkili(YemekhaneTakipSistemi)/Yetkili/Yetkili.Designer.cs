namespace Yetkili
{
    partial class Yetkili
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
            this.yetkiliButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yetkiliButton
            // 
            this.yetkiliButton.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.yetkiliButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.yetkiliButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yetkiliButton.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yetkiliButton.ForeColor = System.Drawing.Color.Blue;
            this.yetkiliButton.Location = new System.Drawing.Point(384, 60);
            this.yetkiliButton.Name = "yetkiliButton";
            this.yetkiliButton.Size = new System.Drawing.Size(133, 43);
            this.yetkiliButton.TabIndex = 10;
            this.yetkiliButton.Text = "Admin";
            this.yetkiliButton.UseVisualStyleBackColor = true;
            this.yetkiliButton.Click += new System.EventHandler(this.yetkiliButton_Click);
            // 
            // Yetkili
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 359);
            this.Controls.Add(this.yetkiliButton);
            this.Name = "Yetkili";
            this.Text = "";
            this.Controls.SetChildIndex(this.yetkiliButton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button yetkiliButton;
    }
}


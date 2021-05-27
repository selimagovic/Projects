namespace Yetkili
{
    partial class YetkiliAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YetkiliAnaSayfa));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bakiyelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bakiyeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bakiyeSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bakiyelerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(984, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bakiyelerToolStripMenuItem
            // 
            this.bakiyelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bakiyeEkleToolStripMenuItem,
            this.bakiyeSilToolStripMenuItem});
            this.bakiyelerToolStripMenuItem.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bakiyelerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bakiyelerToolStripMenuItem.Name = "bakiyelerToolStripMenuItem";
            this.bakiyelerToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.bakiyelerToolStripMenuItem.Text = "Bakiyeler";
            // 
            // bakiyeEkleToolStripMenuItem
            // 
            this.bakiyeEkleToolStripMenuItem.Name = "bakiyeEkleToolStripMenuItem";
            this.bakiyeEkleToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.bakiyeEkleToolStripMenuItem.Text = "Bakiye Ekle";
            this.bakiyeEkleToolStripMenuItem.Click += new System.EventHandler(this.bakiyeEkleToolStripMenuItem_Click);
            // 
            // bakiyeSilToolStripMenuItem
            // 
            this.bakiyeSilToolStripMenuItem.Name = "bakiyeSilToolStripMenuItem";
            this.bakiyeSilToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.bakiyeSilToolStripMenuItem.Text = "Bakiye Sil";
            this.bakiyeSilToolStripMenuItem.Click += new System.EventHandler(this.bakiyeSilToolStripMenuItem_Click);
            // 
            // YetkiliAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "YetkiliAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yetkili Ana Sayfa";
            this.Load += new System.EventHandler(this.YetkiliAnaSayfa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bakiyelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bakiyeEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bakiyeSilToolStripMenuItem;
    }
}
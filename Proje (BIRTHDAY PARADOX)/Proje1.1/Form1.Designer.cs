namespace Proje1._1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxBirthday = new System.Windows.Forms.TextBox();
            this.textBoxSeries = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelAverages = new System.Windows.Forms.Label();
            this.labelBirthdays = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelMatches = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Day = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Month = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonResset = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.labelM = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Location = new System.Drawing.Point(528, 460);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(100, 28);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStartClick);
            // 
            // textBoxBirthday
            // 
            this.textBoxBirthday.Location = new System.Drawing.Point(157, 47);
            this.textBoxBirthday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBirthday.MaxLength = 4;
            this.textBoxBirthday.Name = "textBoxBirthday";
            this.textBoxBirthday.Size = new System.Drawing.Size(55, 22);
            this.textBoxBirthday.TabIndex = 4;
            // 
            // textBoxSeries
            // 
            this.textBoxSeries.Location = new System.Drawing.Point(157, 78);
            this.textBoxSeries.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSeries.MaxLength = 4;
            this.textBoxSeries.Name = "textBoxSeries";
            this.textBoxSeries.Size = new System.Drawing.Size(55, 22);
            this.textBoxSeries.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "BIRTHDAYS :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "SERIES :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(228, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "%";
            // 
            // labelAverages
            // 
            this.labelAverages.AutoSize = true;
            this.labelAverages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAverages.Location = new System.Drawing.Point(153, 265);
            this.labelAverages.Name = "labelAverages";
            this.labelAverages.Size = new System.Drawing.Size(19, 20);
            this.labelAverages.TabIndex = 19;
            this.labelAverages.Text = "0";
            // 
            // labelBirthdays
            // 
            this.labelBirthdays.AutoSize = true;
            this.labelBirthdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthdays.Location = new System.Drawing.Point(153, 238);
            this.labelBirthdays.Name = "labelBirthdays";
            this.labelBirthdays.Size = new System.Drawing.Size(19, 20);
            this.labelBirthdays.TabIndex = 18;
            this.labelBirthdays.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Averages :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Total Birthdays :";
            // 
            // labelMatches
            // 
            this.labelMatches.AutoSize = true;
            this.labelMatches.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMatches.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatches.Location = new System.Drawing.Point(153, 207);
            this.labelMatches.Name = "labelMatches";
            this.labelMatches.Size = new System.Drawing.Size(19, 20);
            this.labelMatches.TabIndex = 15;
            this.labelMatches.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Total Matches :";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Day,
            this.Month,
            this.Year,
            this.Sex});
            this.listView1.Location = new System.Drawing.Point(257, 33);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(371, 419);
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Day
            // 
            this.Day.Text = "Gun";
            this.Day.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Day.Width = 56;
            // 
            // Month
            // 
            this.Month.Text = "Ay";
            this.Month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Month.Width = 80;
            // 
            // Year
            // 
            this.Year.Text = "Yil";
            this.Year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Year.Width = 50;
            // 
            // Sex
            // 
            this.Sex.Text = "Cinsiyet";
            this.Sex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Sex.Width = 70;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(645, 28);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
            // 
            // buttonResset
            // 
            this.buttonResset.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonResset.FlatAppearance.BorderSize = 2;
            this.buttonResset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonResset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.buttonResset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResset.Image = ((System.Drawing.Image)(resources.GetObject("buttonResset.Image")));
            this.buttonResset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonResset.Location = new System.Drawing.Point(257, 460);
            this.buttonResset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonResset.Name = "buttonResset";
            this.buttonResset.Size = new System.Drawing.Size(100, 30);
            this.buttonResset.TabIndex = 23;
            this.buttonResset.Text = "RESET";
            this.buttonResset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonResset.UseVisualStyleBackColor = true;
            this.buttonResset.Click += new System.EventHandler(this.ButtonRessetClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 180);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Matches :";
            // 
            // labelM
            // 
            this.labelM.AutoSize = true;
            this.labelM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelM.Location = new System.Drawing.Point(153, 180);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(19, 20);
            this.labelM.TabIndex = 25;
            this.labelM.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 503);
            this.Controls.Add(this.labelM);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonResset);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelAverages);
            this.Controls.Add(this.labelBirthdays);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelMatches);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSeries);
            this.Controls.Add(this.textBoxBirthday);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BIRTHDAY PARADOX";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxBirthday;
        private System.Windows.Forms.TextBox textBoxSeries;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelAverages;
        private System.Windows.Forms.Label labelBirthdays;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelMatches;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button buttonResset;
        private System.Windows.Forms.ColumnHeader Day;
        private System.Windows.Forms.ColumnHeader Month;
        private System.Windows.Forms.ColumnHeader Year;
        private System.Windows.Forms.ColumnHeader Sex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelM;
    }
}


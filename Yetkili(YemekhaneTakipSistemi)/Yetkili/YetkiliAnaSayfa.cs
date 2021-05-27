using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Yetkili
{
    public partial class YetkiliAnaSayfa : Form
    {
        private char _dil;
        public YetkiliAnaSayfa()
        {
            InitializeComponent();
        }
        public void GetDil(char dil)
        {
            _dil = dil;
        } 

        private void bakiyeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BakiyeEkle bak = new BakiyeEkle();
            bak.getDil(_dil);
            bak.Show();
            bak.MdiParent = this;
        }

        private void bakiyeSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BakiyeSil bak = new BakiyeSil();
            bak.getDil(_dil);
            bak.Show();
            bak.MdiParent = this;
        }

        private void YetkiliAnaSayfa_Load(object sender, EventArgs e)
        {
            DiliDegistir();
        }
        private void DiliDegistir()
        {
            if(_dil=='T')
            {
                this.Text = "Yetkili Ana Sayfasi";
                bakiyelerToolStripMenuItem.Text = "Bakiyeler";
                bakiyeEkleToolStripMenuItem.Text = "Bakiye Ekle";
                bakiyeSilToolStripMenuItem.Text = "Bakiye Sil";
            }
            else
            {
                this.Text = "Admin Main Page";
                bakiyelerToolStripMenuItem.Text = "Balance";
                bakiyeEkleToolStripMenuItem.Text = "Insert Balance";
                bakiyeSilToolStripMenuItem.Text = "Delete Balance";
            }
        }
    }
}

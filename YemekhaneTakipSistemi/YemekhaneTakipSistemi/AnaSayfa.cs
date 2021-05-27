using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YemekhaneTakipSistemi
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void uyeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (enRadioButton.Checked == true)
                dil = 'E';
            else
                dil = 'T';
            UyeForm uyeForm = new UyeForm();
            uyeForm.setDil(dil);
            
            uyeForm.ShowDialog();
            this.Show();
        }
        public char dil;
        private void girisButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (enRadioButton.Checked == true)
                dil = 'E';
            else
                dil = 'T';
            GirisForm gf = new GirisForm();
            gf.GetRadio(dil);
            gf.ShowDialog();
            this.Show();
        }

        private void misafirButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (enRadioButton.Checked == true)
                dil = 'E';
            else
                dil = 'T';
            MisafirForm mis = new MisafirForm();
            mis.getDil(dil);
            mis.ShowDialog();
            this.Show();
        }

        private void enRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            DiliDegistir();

        }

        private void DiliDegistir()
        {
            if (enRadioButton.Checked == true)
            {
                this.Text = "Cafeteria Tracking Program";
                misafirButton.Text = "Guest";
                uyeButton.Text = "Sign in";
                girisButton.Text = "Log in";
            }
            else
            {
                this.Text = "Yemekhane Takip Programi";
                misafirButton.Text = "Misafir";
                uyeButton.Text = "Uye OL";
                girisButton.Text = "Giris";
            }


        }

        private void trRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            DiliDegistir();
        }
    }
}

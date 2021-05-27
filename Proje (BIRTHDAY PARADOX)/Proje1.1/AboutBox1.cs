using System;
using System.Linq;
using System.Windows.Forms;

namespace Proje1._1
{
    partial class AboutBox1 : Form
    {
        public AboutBox1()
        {
            InitializeComponent();
            this.Text = String.Format("About BIRTHDAY PARADOX");
            this.label1.Text = "Product : BIRTHDAY PARADOX";
            this.label2.Text = "Version : 1.0";
            this.label3.Text = "Copyright 2014";
            this.label4.Text = "Programming and Design:";
            this.label5.Text = "Selim Agovic      - 05-11-797";
            this.label6.Text = "Eroll Ramaxhik   - 05-10-901";
            this.label7.Text = "Onur Pala          - 05-10-871"; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

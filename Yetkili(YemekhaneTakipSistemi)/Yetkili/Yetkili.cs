using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yetkili
{
    public partial class Yetkili : YemekhaneTakipSistemi.AnaSayfa
    {
        public Yetkili()
        {
            InitializeComponent();
        }
        private void yetkiliButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            YetkilininGirisSayfasi ygs = new YetkilininGirisSayfasi();
            ygs.ShowDialog();
            this.Show();
        }
    }
}

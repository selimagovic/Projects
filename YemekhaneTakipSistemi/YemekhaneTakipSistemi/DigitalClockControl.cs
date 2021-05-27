using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YemekhaneTakipSistemi
{
    public partial class DigitalClockControl : UserControl
    {
        public DigitalClockControl()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            displayLabel.Text = DateTime.Now.ToLongTimeString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev_777
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double bakiye = 200;


            if (rb1.Checked)
            {
                lblBakiye.Text =(200-15).ToString();
            }
            else if (rb2.Checked)
            {
                lblBakiye.Text = (185 - 12.20).ToString();
            }
            else if (rb3.Checked)
            {
                lblBakiye.Text = (172.80 - 9.60).ToString();
            }
            else if (rb4.Checked)
            {
                lblBakiye.Text = (163.20 - 8).ToString();
            }
        }
    }
}

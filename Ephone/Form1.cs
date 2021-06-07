using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ephone
{
    public partial class Form1 : Form
    {
        pricelistS10 sten = new pricelistS10();
        pricelistS20 sdua = new pricelistS20();
        pricelistS21 s1 = new pricelistS21();

        public Form1()
        {
            InitializeComponent();
        }

        private void s10_Click(object sender, EventArgs e)
        {

        }

        private void btS10_Click(object sender, EventArgs e)
        {
            if (sten.IsDisposed == true)
            {
                sten = new pricelistS10();
            }
            var a = new smartphone();
            a.priceList_S10(3);
            sten.Show();
        }

        private void bts20_Click(object sender, EventArgs e)
        {
            if (sdua.IsDisposed == true)
            {
                sdua = new pricelistS20();
            }
            var b = new smartphone();
            b.priceList_S20(2);
            sdua.Show();
        }

        private void bts21_Click(object sender, EventArgs e)
        {
            if (s1.IsDisposed == true)
            {
                s1 = new pricelistS21();
            }
            var c = new smartphone();
            c.priceList_S21(1);
            s1.Show();
        }
    }
}

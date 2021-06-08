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
    public partial class pricelistS20 : Form
    {

        public pricelistS20()
        {
            InitializeComponent();
        }

        private void bt20_Click(object sender, EventArgs e)
        {
            formatOrder formor = new formatOrder("s20", 10999999);
            if (formor.IsDisposed == true)
            {
                formor = new formatOrder("s20", 10999999);
            }
            MessageBox.Show("Harga S20: Rp 10.999.999");
            formor.Show();
        }

        private void bt20fe_Click(object sender, EventArgs e)
        {
            formatOrder formor = new formatOrder("s20fe", 9999999);
            if (formor.IsDisposed == true)
            {
                formor = new formatOrder("s20fe", 9999999);
            }
            MessageBox.Show("Harga S20 FE: Rp 9.999.999");
            formor.Show();
        }

        private void bt20p_Click(object sender, EventArgs e)
        {
            formatOrder formor = new formatOrder("s20+", 11999999);
            if (formor.IsDisposed == true)
            {
                formor = new formatOrder("s20+", 11999999);
            }
            MessageBox.Show("Harga S20+: Rp Rp 11.999.999");
            formor.Show();
        }

        private void bt20u_Click(object sender, EventArgs e)
        {
            formatOrder formor = new formatOrder("s20 Ultra", 12999999);
            if (formor.IsDisposed == true)
            {
                formor = new formatOrder("s20 Ultra", 12999999);
            }
            MessageBox.Show("Harga S20 Ultra: Rp 12.999.999");
            formor.Show();
        }
    }
}

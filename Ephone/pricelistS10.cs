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
    public partial class pricelistS10 : Form
    {
        formatOrder formor = new formatOrder();

        public pricelistS10()
        {
            InitializeComponent();
        }

        private void bt10_Click(object sender, EventArgs e)
        {

        }

        private void bt10p_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Harga S10+: Rp 11.499.999");
            formor.Show();
        }

        private void bt10e_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Harga S10e: Rp 9.999.999");
            formor.Show(); 
        }

        private void bt10_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Harga S10: Rp 10.499.999");
            formor.Show();
        }
    }
}

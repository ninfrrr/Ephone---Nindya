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
    public partial class pricelistS21 : Form
    {
        formatOrder formor = new formatOrder();

        public pricelistS21()
        {
            InitializeComponent();
        }

        private void bt21_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Harga S21: Rp 12.999.999");
            formor.Show();
        }

        private void bt21p_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Harga S21+: Rp 14.999.999");
            formor.Show();
        }

        private void bt21u_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Harga S21 Ultra: Rp 16.999.999");
            formor.Show();
        }
    }
}

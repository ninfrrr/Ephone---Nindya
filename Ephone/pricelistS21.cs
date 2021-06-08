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

        public pricelistS21()
        {
            InitializeComponent();
        }

        private void bt21_Click(object sender, EventArgs e)
        {
            formatOrder formor = new formatOrder("s21", 12999999);
            if (formor.IsDisposed == true)
            {
                formor = new formatOrder("s21", 12999999);
            }
            MessageBox.Show("Harga S21: Rp 12.999.999");
            formor.Show();
        }

        private void bt21p_Click(object sender, EventArgs e)
        {
            formatOrder formor = new formatOrder("s21+", 14999999);
            if (formor.IsDisposed == true)
            {
                formor = new formatOrder("s21+", 14999999);
            }
            MessageBox.Show("Harga S21+: Rp 14.999.999");
            formor.Show();
        }

        private void bt21u_Click(object sender, EventArgs e)
        {
            formatOrder formor = new formatOrder("s21 Ultra", 16999999);
            if (formor.IsDisposed == true)
            {
                formor = new formatOrder("s21 Ultra", 16999999);
            }
            MessageBox.Show("Harga S21 Ultra: Rp 16.999.999");
            formor.Show();
        }

        private void pricelistS21_Load(object sender, EventArgs e)
        {

        }
    }
}

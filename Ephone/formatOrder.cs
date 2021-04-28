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
    public partial class formatOrder : Form
    {
        public formatOrder()
        {
            InitializeComponent();
        }

        private void formatOrder_Load(object sender, EventArgs e)
        {

        }

        private void btorder_Click(object sender, EventArgs e)
        {
            string namauser = txtnama.Text;
            string nohape = txtno.Text;
            string namajalan = txtjalan.Text;
            string erte = txtrt.Text;
            string erwe = txtrw.Text;
            string kelur = txtkel.Text;
            string kecam = txtkec.Text;
            string kabup = txtkab.Text;
            string prov = txtprov.Text;
            string pos = txtkode.Text;

            lbldisplay.Text = "Konfirmasi format order \nNama: " + namauser + "\nNo. Handphone: " + nohape + "\nNama Jalan: " +
                               namajalan + "\nRT: " + erte + "\t RW: " + erwe + " \nKelurahan: " + kelur + "\nKecamatan: " + kecam + "\nKabupaten: "
                               + kabup + "\nProvinsi: " + prov + "\nKode Pos: " + pos;
        }

        private void lbldisplay_Click(object sender, EventArgs e)
        {

        }

        private void btcod_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("PRODUK AKAN SAMPAI MAKSIMAL 7 HARI SETELAH PEMESANAN \nANDA DAPAT MEMBAYARKAN LANGSUNG KEPADA KURIR KAMI YANG MENGANTARKAN");
        }
    }
}

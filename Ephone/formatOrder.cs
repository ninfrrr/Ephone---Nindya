using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ephone
{
    public partial class formatOrder : Form
    {
        //string connection
        string path = @"Data Source=LAPTOP-5A221LF3;Initial Catalog=orderfrmt;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        int ID;
        string namaproduk;
        int hargaproduk;
        int jumlahproduk = 1;

        public formatOrder(string produkname, int price)
        {
            InitializeComponent();
            namaproduk = produkname;
            hargaproduk = price;
            con = new SqlConnection(path);
            txtjumlah.Text = "1";
            int hargatotal = hargaproduk * jumlahproduk;
            txttotal.Text = hargatotal.ToString();
            txtProduk.Text = namaproduk;
            display();
        }

        private void formatOrder_Load(object sender, EventArgs e)
        {

        }

        private void btorder_Click(object sender, EventArgs e)
        {

            if (txtnama.Text=="" || txtno.Text == "" || txtjalan.Text=="" || txtrt.Text=="" || txtrw.Text=="" || txtkel.Text=="" || txtkec.Text==""||txtkab.Text==""||txtprov.Text==""||txtkode.Text==""|| txttotal.Text==""|| txtProduk.Text=="")
            {
                MessageBox.Show("Please fill in the blanks!!!"); 
            }
            else
            {
                try
                {
                    string bayar;
                    if (btcod.Checked)
                    {
                        bayar = "COD";
                    }
                    else
                    {
                        bayar = "e-Money";
                    }
                    con.Open();
                    cmd = new SqlCommand("insert into beli (namauser, nohp, namajalan, erte, erwe, kelur, kecam, kabup, prov, kodpos, bayar, harga, produk)values('" + txtnama.Text + "', '" + txtno.Text + "', '" + txtjalan.Text + "', '" + txtrt.Text + "', '" + txtrw.Text + "', '" + txtkel.Text + "', '" + txtkec.Text + "', '" + txtkab.Text + "', '" + txtprov.Text + "', '" + txtkode.Text + "', '" + bayar + "', '"+ txttotal.Text +"', '"+ txtProduk.Text +"')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Your data has been saved in the database!");
                    clear();
                    display();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //biar kalo udah ngisi trs jd kosong lagi boxnya
        public void clear()
        {
            txtnama.Text = "";
            txtno.Text = "";
            txtjalan.Text = "";
            txtrt.Text = "";
            txtrw.Text = "";
            txtkel.Text = "";
            txtkec.Text = "";
            txtkab.Text = "";
            txtprov.Text = "";
            txtkode.Text = "";
        }

        public void display()
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("select * from beli", con);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbldisplay_Click(object sender, EventArgs e)
        {

        }

        private void btcod_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("PRODUK AKAN SAMPAI MAKSIMAL 7 HARI SETELAH PEMESANAN \nANDA DAPAT MEMBAYARKAN LANGSUNG KEPADA KURIR KAMI YANG MENGANTARKAN");
        }

        private void btmbank_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("MOHON MAAF SAAT INI LAYANAN INI BELUM TERSEDIA :(");
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string bayar;
                if (btcod.Checked)
                {
                    bayar = "COD";
                }
                else
                {
                    bayar = "e-Money";
                }
                con.Open();
                cmd = new SqlCommand("update beli set namauser ='" + txtnama.Text + "', nohp = '" + txtno.Text + "', namajalan= '" + txtjalan.Text + "', erte='" + txtrt.Text + "', erwe='" + txtrw.Text + "', kelur='" + txtkel.Text + "', kecam='" + txtkec.Text + "', kabup='" + txtkab.Text + "', prov='" + txtprov.Text + "', kodpos='" + txtkode.Text + "', bayar='" + bayar + "' where Format_id='" + ID + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(" Your data has been updated!");
                display();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtnama.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtno.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtjalan.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtrt.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtrw.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtkel.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtkec.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtkab.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtprov.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtkode.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            
            btcod.Checked = true;
            btmbank.Checked = false;
            if(dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString() == "e-Money")
            {
                btcod.Checked = false;
                btmbank.Checked = true;
            }
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("delete from beli where Format_id='" + ID + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(" DELETED!");
                display();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateproduk_Click(object sender, EventArgs e)
        {
            jumlahproduk = Convert.ToInt32(txtjumlah.Text);
            int hargatotal = hargaproduk * jumlahproduk;
            txttotal.Text = hargatotal.ToString();
        }

        public static int testhitung(int count)
        {
            int harga = 10499999;
            int jumlahproduk = count;
            int rumus = harga * jumlahproduk;
            return rumus;
        }
    }
}

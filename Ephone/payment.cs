using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ephone
{
    public class payment
    {
        public void all_methods()
        {
            Console.WriteLine("Pilih sistem pembayaran yang anda inginkan: \n1. Cash on Delivery \n2. Digital");
            int byr = Convert.ToInt32(Console.ReadLine());
            if (byr == 1)
            {
                cod();
            }
            else if (byr == 2)
            {
                digital();
            }
        }
        public void digital()
        {
            Console.WriteLine("***MOHON MAAF SAAT INI LAYANAN INI BELUM TERSEDIA :(***");
        }
        public void cod()
        {
            Console.WriteLine("PRODUK AKAN SAMPAI MAKSIMAL 7 HARI SETELAH PEMESANAN \nANDA DAPAT MEMBAYARKAN LANGSUNG KEPADA KURIR KAMI YANG MENGANTARKAN");
            Console.WriteLine("\n---TERIMA KASIH TELAH MEMBELI DARI KAMI---");
        }
    }
}

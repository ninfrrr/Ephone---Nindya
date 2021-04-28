using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ephone
{
    public class order
    {
        //deklarasi variabel-variabel yang digunakan dalam class ini
        //field
        string nama;
        string nomorhp;
        string alamat1;
        string alamat2;
        string alamat3;
        string alamat4;
        string alamat5;
        string alamat6;
        string alamat7;


        public void format_order() //method untuk memanggil semua method dalam class order ini ketika dipanggil dalam class lain 
        {
            name();
            nohp();
            alamat();
            add_data();
        }
        public void name() //method untuk input nama lengkap customer 
        {
            Console.Write("\nMasukkan nama lengkap anda: ");
            nama = Console.ReadLine();
        }
        private void nohp() //method untuk input nomor handphone customer
        {
            Console.Write("\nMasukkan nomor handphone anda: ");
            nomorhp = Console.ReadLine();
        }
        public void alamat() //method untuk input alamat customer
        {
            Console.WriteLine("\n\t###Mohon masukkan alamat lengkap Anda###");
            Console.Write("\nNama Jalan: \t\t");
            alamat1 = Console.ReadLine();
            Console.Write("RT/RW: \t\t\t");
            alamat2 = Console.ReadLine();
            Console.Write("Kelurahan: \t\t");
            alamat3 = Console.ReadLine();
            Console.Write("Kecamatan: \t\t");
            alamat4 = Console.ReadLine();
            Console.Write("Kabupaten/Kota: \t");
            alamat5 = Console.ReadLine();
            Console.Write("Provinsi: \t\t");
            alamat6 = Console.ReadLine();
            Console.Write("Kode pos: \t\t");
            alamat7 = Console.ReadLine();

        }

        public void add_data()
        { //method untuk menambahkan data dan ditampilkan sebagai pesan akhir
            var tambah = new data(nama, nomorhp, alamat1, alamat2, alamat3, alamat4, alamat5, alamat6, alamat7); //memanggil class data sebagai tambah
            Console.WriteLine("\nPRODUK MEMILIKI GARANSI SELAMA 7 HARI SETELAH PRODUK DITERIMA.");
            Console.Write("\n\t^^^PRODUK AKAN DIKIRIMKAN ATAS NAMA: " + tambah.get_nama());
            Console.WriteLine("\tDENGAN NOMOR HP: " + tambah.get_nohp());
            Console.WriteLine("\tPRODUK AKAN DIKIRIMKAN KE ALAMAT: " + tambah.get_alamat1() + ", " + tambah.get_alamat2() + ", " + tambah.get_alamat3() + ", " + tambah.get_alamat4() + ", " + tambah.get_alamat5() + ", " + tambah.get_alamat6() + ", " + tambah.get_alamat7() + ".\n");
            Console.WriteLine("JIKA PRODUK BELUM SAMPAI PADA ANDA DALAM 7 HARI, SILAKAN HUBUNGI NOMOR: 088134792579");
        }
    }
}

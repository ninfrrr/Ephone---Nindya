using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ephone
{
    //S=single responsibility
    //class ini hanya berisi tentang list varian dan harga smartphone yang tersedia
    public class smartphone
    {

        public void displayList() //method untuk menampilkan varian seri yang ada
        {
            Console.WriteLine("\n1. S21 \n2. S20 \n3. S10");
        }
        public void pilihan(int milih) //method untuk menampilkan pilihan apa saja yang tersedia
        {
            int pilihan = milih;
            //switch untuk tiap pilihan yang dipilih customer
            switch (pilihan)
            {
                case 1:
                    Console.WriteLine("\n1. S21 \n2. S21+ \n3. S21 Ultra\n"); //menampilkan hasil pilihan nomor 1
                    Console.Write("\nPilih tipe untuk melihat harga: ");
                    string pilihanTemp1 = Console.ReadLine();
                    int choose1 = Convert.ToInt32(pilihanTemp1);
                    priceList_S21(choose1); //panggil method ini untuk menampilkan daftar harganya
                    break;
                case 2:
                    Console.WriteLine("\n1. S20 \n2. S20+ \n3. S20 FE \n4. S20 Ultra \n"); //menampilkan hasil pilihan nomor 2
                    Console.Write("\nPilih tipe untuk melihat harga: ");
                    string pilihanTemp2 = Console.ReadLine();
                    int choose2 = Convert.ToInt32(pilihanTemp2);
                    priceList_S20(choose2); //panggil method ini untuk menampilkan daftar harganya
                    break;
                case 3:
                    Console.WriteLine("\n1. S10 \n2. S10+ \n3. S10e"); //menampilkan hasil pilihan nomor 3
                    Console.Write("\nPilih tipe untuk melihat harga: ");
                    string pilihanTemp3 = Console.ReadLine();
                    int choose3 = Convert.ToInt32(pilihanTemp3);
                    priceList_S10(choose3); //panggil method ini untuk menampilkan daftar harganya
                    break;
                default:
                    Console.WriteLine("\nTidak ada!");
                    break;
            }
        }
        public void priceList_S21(int harga) //method untuk menampilkan harga tiap pilihan seri s21 yang dipilih oleh customer
        {
            switch (harga)
            {
                case 1:
                    Console.WriteLine("\nHarga S21: Rp 12.999.999");
                    break;
                case 2:
                    Console.WriteLine("\nHarga S21+: Rp 14.999.999");
                    break;
                case 3:
                    Console.WriteLine("\nHarga S21 Ultra: Rp 16.999.999");
                    break;
                default:
                    Console.WriteLine("\nTIDAK ADA!");
                    break;
            }
        }
        public void priceList_S20(int harga) //method untuk menampilkan harga tiap pilihan seri s20 yang dipilih customer
        {
            switch (harga)
            {
                case 1:
                    Console.WriteLine("\nHarga S20: Rp 10.999.999");
                    break;
                case 2:
                    Console.WriteLine("\nHarga S20+: Rp Rp 11.999.999");
                    break;
                case 3:
                    Console.WriteLine("\nHarga S20 FE: Rp 9.999.999");
                    break;
                case 4:
                    Console.WriteLine("\nHarga S20 Ultra: Rp 12.999.999");
                    break;
                default:
                    Console.WriteLine("\nTIDAK ADA!");
                    break;
            }
        }
        public void priceList_S10(int harga) //method untuk menampilkan harga tiap pilihan seri s10 
        {
            switch (harga)
            {
                case 1:
                    Console.WriteLine("\nHarga S10: Rp 10.499.999");
                    break;
                case 2:
                    Console.WriteLine("\nHarga S10+: Rp 11.499.999");
                    break;
                case 3:
                    Console.WriteLine("\nHarga S10e: Rp 9.999.999");
                    break;
                default:
                    Console.WriteLine("\nTIDAK ADA!");
                    break;
            }
        }

    }
}

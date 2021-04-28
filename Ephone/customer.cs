using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ephone
{
    public class customer
    {
        public void searchPhone()
        {
            Console.WriteLine("=====Galaxy S Series apa yang anda cari?=====");
            var phone = new smartphone();
            phone.displayList(); //memanggil method displayList dari class smartphone
            Console.Write("\nMasukkan pilihan anda: ");
            string pilihanTemp = Console.ReadLine();
            int choose = Convert.ToInt32(pilihanTemp);
            phone.pilihan(choose); //memanggil method pilihan dari class smartphone
            Console.Write("\nApakah anda yakin ingin memesan ini? (ya/tidak) ");
            string yakin = Console.ReadLine();
            if (yakin == "ya" || yakin == "Ya" || yakin == "YA" || yakin == "yA")
            {
                var pesen = new order();
                pesen.format_order();
            }
            else if (yakin == "tidak" || yakin == "Tidak" || yakin == "TIDAK")
            {
                searchPhone();
            }
            var pay = new payment();
            pay.all_methods();
            var lain = new otherVar();
            lain.other();
        }
    }
}

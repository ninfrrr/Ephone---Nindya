using System;

namespace Ephone
{
    public class data
    {
        //field
        private string nama;
        private string nohp;
        private string alamat1;
        private string alamat2;
        private string alamat3;
        private string alamat4;
        private string alamat5;
        private string alamat6;
        private string alamat7;

        /*        public data() //polymorphism static
                {

                }*/

        public data(string nama, string nohp, string alamat1, string alamat2, string alamat3, string alamat4, string alamat5, string alamat6, string alamat7) //polymorphism static
        {
            this.nama = nama;
            this.nohp = nohp;
            this.alamat1 = alamat1;
            this.alamat2 = alamat2;
            this.alamat3 = alamat3;
            this.alamat4 = alamat4;
            this.alamat5 = alamat5;
            this.alamat6 = alamat6;
            this.alamat7 = alamat7;
        }

        public void add_nama(string nama)
        {
            this.nama = nama;
        }
        public void add_nohp(string nohp)
        {
            this.nohp = nohp;
        }
        public void add_alamat(string alamat1, string alamat2, string alamat3, string alamat4, string alamat5, string alamat6, string alamat7)
        {
            this.alamat1 = alamat1;
            this.alamat2 = alamat2;
            this.alamat3 = alamat3;
            this.alamat4 = alamat4;
            this.alamat5 = alamat5;
            this.alamat6 = alamat6;
            this.alamat7 = alamat7;
        }
        public string get_nama()
        {
            return nama;
        }
        public string get_nohp()
        {
            return nohp;
        }
        public string get_alamat1()
        {
            return alamat1;
        }

        public string get_alamat2()
        {
            return alamat2;
        }

        public string get_alamat3()
        {
            return alamat3;
        }

        public string get_alamat4()
        {
            return alamat4;
        }

        public string get_alamat5()
        {
            return alamat5;
        }

        public string get_alamat6()
        {
            return alamat6;
        }

        public string get_alamat7()
        {
            return alamat7;
        }
    }
}
using System;

namespace Exercise2
{
    class InsertionSort
    {
        //Deklarasi array integer dengan ukuran 30 + 20 - 2 x 15 + 10 + 20
        private int[] osi = new int[50];

        //Deklarasi variabel untuk menyimpan banyaknya data pada array
        private int n;

        //Method untuk menerima input dari user
        public void input()
        {
            //Menerima angka untuk menentukan banyaknya data yang disimpan pada array
            while (true)
            {
                Console.Write("Masukkan banyaknya elemen pada array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 50)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 50 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Masukkan elemen array");
            Console.WriteLine("--------------------------");

            //User memasukkan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + " > ");
                string s1 = Console.ReadLine();
                osi[i] = Int32.Parse(s1);
            }
        }

        public void display()
        {
            //Menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Masukkan elemen array yang telah tersusun");
            Console.WriteLine("-----------------------------------------");
            for (int FR = 0; FR < n; FR++)
            {
                Console.WriteLine(osi[FR]);
            }
            Console.WriteLine("");
        }

        public void insertionsort()
        {
            for (int i = 1; i < n; i++)
            {
                int temp = osi[i];
                int FR = i - 1;
                while (FR >= 0 && osi[FR] > temp)
                {
                    osi[FR + 1] = osi[FR];
                    FR = FR - 1;
                }
                osi[FR + 1] = temp;
            }
        }
    }

    class MergeSort
    {
        //Deklarasi array integer dengan ukuran 30 + 20 - 2 x 15 + 10 + 20
        private int[] osi = new int[50];
        private int[] a = new int[50];
        //Deklarasi variabel untuk menyimpan banyaknya data pada array
        private int n;

        public void input()
        {
            while (true)
            {
                Console.Write("Masukkan banyaknya elemen pada array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 50)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 50 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Masukkan elemen array");
            Console.WriteLine("--------------------------");

            //User memasukkan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + " > ");
                string s1 = Console.ReadLine();
                osi[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            //Menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Masukkan elemen array yang telah tersusun");
            Console.WriteLine("-----------------------------------------");
            for (int FR = 0; FR < n; FR++)
            {
                Console.WriteLine(osi[FR]);
            }
            Console.WriteLine("");
        }

    }

    class Program
    { 
        static void Main(string[] args)
        {

        }
    }
}

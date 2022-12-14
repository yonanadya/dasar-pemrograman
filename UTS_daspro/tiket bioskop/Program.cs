// Yona Nadya Fadila - 2207112585
// Teknik Informatika - B

using System;

namespace tiket_bioskop
{
    class Program
    {
        static string nama;
        static int tahun;
        static int umur;
        static decimal harga;

        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Nama : ");
            nama = Console.ReadLine();
            Console.WriteLine("Tahun Kelahiran : ");
            tahun = Convert.ToInt32(Console.ReadLine());
            Init();
            tiketBioskop();
            
        }

        static void Init()
        {
            umur = 2022 - tahun;
            if(umur < 10 || umur > 60)
            {
                harga = 10000.00m;
            }
            else
            {
                harga = 25000.00m;
            }
                
        }

        static void tiketBioskop()
        {
            Console.WriteLine("|*************************|");
            Console.WriteLine("|      -- Studio 1 --     |");
            Console.WriteLine("|Nama:{0,20}|", nama);
            Console.WriteLine("|Harga:  Rp{0,15}|", harga);
            Console.WriteLine("|-------------------------|");

        }
    }
}


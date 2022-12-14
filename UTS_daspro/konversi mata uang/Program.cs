// Yona Nadya Fadila - 2207112585
// Teknik Informatika - B

using System;

namespace konversi_mata_uang
{
    class Program
    {
        static decimal rateUSD = 15355.00m;
        static decimal jumlahUSD;
        static decimal hasilKonversi;

        
        static void Init()
        {
            hasilKonversi = rateUSD*jumlahUSD;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Rate USD ke Rp: ");
            Console.WriteLine(rateUSD);
            Console.WriteLine("Jumlah USD: ");
            jumlahUSD = decimal.Parse(Console.ReadLine());
            Init();
            Console.WriteLine("Hasil Konversi: "+ hasilKonversi);
        }
    }
}

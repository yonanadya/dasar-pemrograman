//Created by Yona Nadya Fadila - 2207112585
//Teknik Informatika - B

using System;
using System.Collections.Generic;

namespace Tebak_Kata
{
    class Program
    {
        static int kesempatan = 5;
        static String kataMisteri = "PARIS SAINT GERMAIN";
        static List<string> listTebakan = new List<String>{};

        static void Main(string[] args)
        {
            Intro();
            PlayGame();
        }

        static void Intro()
        {
            Console.WriteLine("Selamat Datang, hari ini kita akan bermain tebak kata");
            Console.WriteLine($"Kamu punya {kesempatan} kesempatan untuk menebak kata misteri hari ini");
            Console.WriteLine("Petunjuknya adalah kata ini merupakan nama klub sepakbola");
            Console.WriteLine("Kata ini menggunakan huruf kapital");
            Console.WriteLine($"Kata tersebut terdiri dari {kataMisteri.Length} huruf");
            Console.WriteLine("Klub apakah yang dimaksud?");
            Console.ReadKey();
            Console.WriteLine();
        }

        static void PlayGame()
        {
            while(kesempatan>0)
            {
                Console.Write("Apa huruf tebakanmu?(pilih a-z) :");
                string input = Console.ReadLine();
                listTebakan.Add(input);
                if(CekJawaban(kataMisteri, listTebakan))
                {
                    Console.WriteLine("Selamat anda berhasil menebak katanya");
                    Console.WriteLine($"Kata misteri hari ini adalah {kataMisteri}");
                    break;
                }
                else if(kataMisteri.Contains(input))
                {
                    Console.WriteLine("Huruf itu ada di dalam kata ini");
                    Console.WriteLine("Silahkan tebak huruf lainnya...");
                    //Menampilkan huruf yang sudah tertebak
                    Console.WriteLine(CekHuruf(kataMisteri, listTebakan));
                }
                else
                {
                    Console.WriteLine("Huruf itu tidak ada dalam kata ini");
                    kesempatan--;//kesempatan = kesempatan -1;
                    Console.WriteLine($"Kesempatan anda tinggal {kesempatan}");
                }

                if(kesempatan==0)
                {
                    EndGame();
                    break;
                }
            }
        }

        static bool CekJawaban(string kataRahasia, List<string> list)
        {
            bool status = false;

            for(int i = 0; i < kataRahasia.Length; i++)
            {
                string c = Convert.ToString(kataRahasia[i]);
                if(list.Contains(c))
                {
                    status = true;
                }
                else
                {
                    return status = false;
                }
            }

            return status;
        }

        static string CekHuruf(string kataRahasia, List<string> list)
        {
            string x = "";

            for(int i = 0; i < kataRahasia.Length; i++)
            {
                string c = Convert.ToString(kataRahasia[i]);
                if(list.Contains(c))
                {
                    x = x + c;
                }
                else
                {
                    x = x + "-";
                }
            }

            return x;
        }

        static void EndGame()
        {
            Console.WriteLine("Permainan berakhir.");
            Console.WriteLine($"Kata misteri sebenarnya adalah {kataMisteri}");
            Console.WriteLine("Bye...");
        }
    }
}

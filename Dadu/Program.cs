/*
Created by Yona Nadya Fadila - 2207112585
Teknik Informatika - B
*/

using System;

namespace Dadu
{
    class Program
    {
        //Deklarasi variabel
        static Random rng = new Random();
        static int nilaiKomputer;
        static int nilaiAnda;
        static int skorAnda = 0;
        static int skorKomputer = 0;
        static int i = 1;

        static void Main(string[] args)
        {
            Intro();
            for(int i = 1; i <=10; i++)
            {
                playGame();
            }
            ShowEnd();
            Console.Write("Bye!");
            Console.ReadKey();
        }

        static void Intro()
        {
            Console.WriteLine("Pada game ini anda dan komputer akan bermain 10 ronde");
            Console.WriteLine("Setiap putaran dadu akan dilempar menghasilkan nilai tertentu");
            Console.WriteLine("Nilai dadu tertinggi akan menjadi pemenang ronde tersebut");
            Console.WriteLine("Siapa yang akan menang? Selamat berjuang");
            Console.WriteLine("\nMulai main..");
            Console.ReadLine();
        }

        static void Init()
        {
            //Inisialisasi variabel
            nilaiKomputer = rng.Next(1,6);
            nilaiAnda = rng.Next(1,6);
        }

        static void playGame()
        {
            Init();
            Console.WriteLine("Ronde "+i++);
            Console.WriteLine("Nilai Komputer : "+nilaiKomputer);
            Console.WriteLine("Lempar dadu anda...");  
            Console.WriteLine("Nilai anda : "+nilaiAnda);
            Console.ReadLine();
            if(nilaiKomputer > nilaiAnda)
            {
                skorKomputer ++;
                Console.WriteLine("Komputer memenangkan ronde ini.");
            }
            else if(nilaiAnda > nilaiKomputer)
            {
                skorAnda++;
                Console.WriteLine("Anda memenangkan ronde ini.");
            }
            else
            {
                Console.WriteLine("Nilai dadu seri, tidak ada yang mendapatkan skor");
            }
            Console.WriteLine("Skor - Anda : "+skorAnda+" Komputer : "+skorKomputer+".");
            Console.WriteLine("Lanjutkan ke ronde berikutnya...");
            Console.ReadLine();
        }

        static void ShowEnd()
        {
            Console.WriteLine("Permainan selesai.");
            Console.WriteLine("Skor Akhir - Anda : "+skorAnda+" Komputer : "+skorKomputer+".");
            if(skorAnda > skorKomputer)
            {
                Console.WriteLine("Selamat, Anda Menang!");
            }
            else if (skorKomputer > skorAnda)
            {
                Console.WriteLine("Sayang sekali, komputer memenangkan permainan ini.\nAnda kalah!!");
            }
            else
            {
                Console.WriteLine("Permainan ini seri!!");
            }
        }
    }
}

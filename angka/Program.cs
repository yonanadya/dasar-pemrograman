/*
Created by Yona Nadya Fadila - 2207112585
Teknik Informatika - B
*/

using System;

namespace daspro
{
    class Program
    {
        //Deklarasi variabel
        public static int kodeA;
        public static int kodeB;
        public static int kodeC;
        public static int hasilTambah;
        public static int hasilTambah2;
        public static int hasilTambah3;
        public static int hasilTambah4;
        public static int hasilKali;
        public static int jumlahKode = 3;
        public static int kesempatan = 3;
        public static int level = 1;
        public static int tebakanA;
        public static int tebakanB;
        public static int tebakanC;
        public static Random rng = new Random();
        public static bool bGameStart;

        //Main Method
        static void Main(string[] args)
        {
            bGameStart = true;
            while(bGameStart)
            {
                if(kesempatan >0)
                {
                    if(bGameStart==true)
                    {
                    PlayGame();
                    }
                    if(level ==6)
                    {
                        Menang();
                    }
                    Console.Clear();
                }
                else
                {
                    ShowEnd();
                    Console.Clear();
                }
            }
            Console.Write("\nTekan Enter untuk kembali..."); Console.ReadKey();
        }

        static void Init()
        {
            //Inisialisasi Variabel
            kodeA = rng.Next(1,2*level);
            kodeB = rng.Next(1,2*level);
            kodeC = rng.Next(1,2*level);

            //Operasi Aritmatika
            hasilTambah = kodeA+kodeB+kodeC;
            hasilTambah2 = kodeA+kodeB;
            hasilTambah3 = kodeA+kodeC;
            hasilTambah4 = kodeB+kodeC;
            hasilKali = kodeA*kodeB*kodeC;
        }        
        
        static void Intro()
        {
            Init();
            //Intro
            Console.WriteLine("Anda adalah agen rahasia yang bertugas mendapatkan data dari server");
            Console.WriteLine("Akses ke server membutuhkan password yang tidak diketahui...");
            Console.WriteLine("Anda berada di level "+ level);
            Console.WriteLine("Password terdiri dari "+jumlahKode+" angka");
            Console.WriteLine("Jika semua kode ditambahkan hasilnya "+hasilTambah);
            Console.WriteLine("Jika semua kode dikalikan hasilnya "+hasilKali);
            Console.WriteLine("Jika kode 1 dan 2 ditambahkan hasilnya "+hasilTambah2);
            Console.WriteLine("Jika kode 1 dan 3 ditambahkan hasilnya "+hasilTambah3);
            Console.WriteLine("Jika kode 2 dan 3 ditambahkan hasilnya "+hasilTambah4);
        }

        static void PlayGame()
        {
            Intro();
            Console.Write("Masukan Kode Pertama : ");
            tebakanA = Convert.ToInt32 (Console.ReadLine());
            Console.Write("Masukan Kode Kedua : ");
            tebakanB = Convert.ToInt32 (Console.ReadLine());
            Console.Write("Masukan Kode Ketiga : ");
            tebakanC = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("\nTebakan anda "+tebakanA+" "+tebakanB+" "+tebakanC+" ?");

            if(tebakanA == kodeA && tebakanB == kodeB && tebakanC == kodeC)
            {
                Console.WriteLine("\nTebakan anda benar...");
                level ++;
                Console.WriteLine("\nTekan Enter untuk lanjut");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                kesempatan--;
                Console.WriteLine("Tebakan anda salah...\nSilahkan coba lagi!");
                Console.WriteLine("Kesempatan menjawab sisa : " +kesempatan);
                Console.WriteLine("Tekan Enter untuk lanjut");
                Console.ReadLine();
                Console.Clear();
            }
        }
            
        static void ShowEnd()
        {
            Console.Clear();
            if(kesempatan ==0)
            {
                Console.WriteLine("Sayang Sekali...\nKesempatan anda habis!!\n\nThis Game is Over!!");
                Console.ReadLine();
                Console.Clear();
                bGameStart = false;
            }
        }

        static void Menang()
        {
            Console.WriteLine("Selamat!!\nJawaban anda benarr!!");
            Console.WriteLine("Anda sudah menyelesaikan semua level...");
            Console.WriteLine("You Have Win This Game!!");
            Console.ReadLine();
            Console.Clear();
            bGameStart = false;
        }
    }
}
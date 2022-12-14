//Yona Nadya Fadila - 2207112585

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hangman_game
{
    class Program
    {
        static void Main(string[] args)
        {
            int kesalahan = 0;
            String jawaban = "";
            bool salah = false, menang = false, kalah = false, benar = false;

            Console.Clear();
            string[] soal = new string[5];
            soal[0] = "informatika";
            soal[1] = "indonesia";
            soal[2] = "bebek";
            soal[3] = "politik";
            soal[4] = "metamorfosis";
            Random randGen = new Random();
            var random = randGen.Next(0,4);
            string soalGame = soal[random];
            char[]guess = new char[soalGame.Length];

            for (int p = 0; p < soalGame.Length; p++)
            {
                guess[p]='_';
            }

            while(menang == false && kalah == false)
            {
                Console.Write("Huruf Tebakan: ");
                char playerGuess = char.Parse(Console.ReadLine());
                for (int j = 0; j < soalGame.Length; j++)
                {
                    if(playerGuess == soalGame[j])
                    {
                        benar = true;
                        guess[j] = playerGuess;
                    }
                    else if(j==soalGame.Length - 1 && benar == false)
                    {
                        salah = true;
                    }
                }
                Console.Clear();
                jawaban = new String(guess);
                if(salah == true)
                {
                    Console.WriteLine("Tebakan anda salah!");
                    salah = false;
                }
                benar = false;
                Console.WriteLine(guess);
                Console.WriteLine();

                switch(kesalahan)
                {
                    case 1:
                    Console.WriteLine("_|__");
                    break;
                    
                    case 2:
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                    Console.WriteLine("_|__");
                    break;

                    case 3:
                    Console.WriteLine(" |/");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                    Console.WriteLine("_|__");
                    break;

                    case 4:
                    Console.WriteLine("__________");
                    Console.WriteLine(" |/");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                    Console.WriteLine("_|__");
                    break;

                    case 5:
                    Console.WriteLine("__________");
                    Console.WriteLine(" |/      |");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                    Console.WriteLine("_|__");
                    break;

                    case 6:
                    Console.WriteLine("__________");
                    Console.WriteLine(" |/      |");
                    Console.WriteLine(" |      (_)");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                    Console.WriteLine("_|__");
                    break;

                    case 7:
                    Console.WriteLine("__________");
                    Console.WriteLine(" |/      |");
                    Console.WriteLine(" |      (_)");
                    Console.WriteLine(" |     \\|/");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                    Console.WriteLine("_|__");
                    break;

                    case 8:
                    Console.WriteLine("__________");
                    Console.WriteLine(" |/      |");
                    Console.WriteLine(" |      (_)");
                    Console.WriteLine(" |     \\|/");
                    Console.WriteLine(" |       |");
                    Console.WriteLine(" |");
                    Console.WriteLine("_|__");
                    break;

                    case 9:
                    Console.WriteLine("__________");
                    Console.WriteLine(" |/      |");
                    Console.WriteLine(" |      (_)");
                    Console.WriteLine(" |     \\|/");
                    Console.WriteLine(" |       |");
                    Console.WriteLine(" |      / \\ ");
                    Console.WriteLine("_|__");
                    break;

                    case 10: 
                    Console.WriteLine("__________");
                    Console.WriteLine(" |/      |");
                    Console.WriteLine(" |      (_)");
                    Console.WriteLine(" |     \\|/");
                    Console.WriteLine(" |       |");
                    Console.WriteLine(" |      / \\ ");
                    Console.WriteLine("_|__");
                    break;

                    default:
                     break;
                }

                if(jawaban == soalGame)
                {
                    Console.WriteLine("Selamat, anda menang");
                }
                else if(kesalahan==10 && jawaban != soalGame)
                {
                    Console.WriteLine("Anda kurang beruntung");
                    kalah = true;
                }
            }
        }
    }
}

// Yona Nadya Fadila - 2207112585
// Teknik Informatika - B
using System;

namespace Name_Tag
{
    class Program
    {
        static string nama;
        static string nim;
        static string konsentrasi;

        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Nama : "); 
            nama = Console.ReadLine();
            Console.WriteLine("Nim : ");
            nim = Console.ReadLine();
            Console.WriteLine("Konsentrasi : ");
            konsentrasi = Console.ReadLine();
            nameTag();
        }

        static void nameTag()
        {
            Console.WriteLine("|*******************************|");
            Console.WriteLine("|Nama: {0,25}|", nama); 
            Console.WriteLine("| {0,30}|", nim); 
            Console.WriteLine("|-------------------------------|");
            Console.WriteLine("| {0,30}|", konsentrasi); 
            Console.WriteLine("|*******************************|");
        }
    }
}

//Yona Nadya Fadila - 2207112585
// Teknik Informatika - B

using System;
using System.Text.RegularExpressions;

namespace enkripsi
{
    class Program
    {
        public static void Main(string[] args)
        {
            String huruf = "abcdefghijklmnopqrstuvwxyzabcABCDEFGHIJKLMNOPQRSTUVWXYZABC";
            String teks = "";
            String enkripsi = "";
            Regex rgx = new Regex("[^A-Za-z ]");
            do
            {
                Console.Write("Teks : ");  teks = Console.ReadLine();
            } 
            while (String.IsNullOrEmpty(teks) || rgx.IsMatch(teks));

            foreach (Char t in teks)
            {
                Char temp = ' ';
                for (int i = 0; i < huruf.Length; i++)
                {
                    Char c = huruf[i];
                    if(t.Equals(c))
                    {
                        temp = huruf[i+3];
                        break;
                    }
                    else if(t.Equals(' '))
                    {
                        temp = ' ';
                        break;
                    }
                }
                enkripsi = enkripsi + temp;
            }
            Console.Write("Hasil Enkripsi : " + enkripsi);
        }
    }
}

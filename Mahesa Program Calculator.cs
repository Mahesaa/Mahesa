using System;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculator Program";
            Console.WriteLine("Pilih menu kalkulator :");
            Console.WriteLine();

            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");

            Console.WriteLine();
            Console.Write("Input nomor menu [1-4] : ");
            int masukan = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (masukan > 4 || masukan < 1)
            {
                Console.WriteLine("NOT ALLOWED");
                pesan();
            }
            else
            {
                Console.Write("Input nilai a : ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input nilai b : ");
                int b = int.Parse(Console.ReadLine());

                if(masukan == 1)
                {
                    Console.WriteLine("Hasil penjumlahan {0} + {1} = {2}", a, b, penambahan(a, b));
                }
                else if(masukan == 2)
                {
                    Console.WriteLine("Hasil pengurangan {0} - {1} = {2}", a, b, pengurangan(a, b));
                }
                else if (masukan == 3)
                {
                    Console.WriteLine("Hasil perkalian {0} * {1} = {2}", a, b, perkalian(a, b));
                }
                else if (masukan == 4)
                {
                    Console.WriteLine("Hasil pembagian {0} / {1} = {2}", a, b, pembagian(a, b));
                }
                pesan();
            }
        }

        static int penambahan(int a, int b)
        {
            return a + b;
        }
        static int pengurangan(int a, int b)
        {
            return a - b;
        }
        static int perkalian(int a, int b)
        {
            return a * b;
        }
        static float pembagian(float a, float b)
        {
            return a / b;
        }
        static void pesan()
        {
            Console.WriteLine();
            Console.Write("Press any to Quit . . .");
            Console.ReadKey();
        }
    }
}
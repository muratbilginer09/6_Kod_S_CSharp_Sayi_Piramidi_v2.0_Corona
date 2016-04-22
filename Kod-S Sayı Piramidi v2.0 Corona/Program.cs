using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kod_S_Sayı_Piramidi_v2._0_Corona
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n;
            char karakter;

        tekrarbaşla:

            Console.Write("Piramit Basamak Değerini Giriniz:");
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************************");



            Console.Write("Devam Etmek İçin E/e Çıkmak için H/h basınız: ");
            karakter = Convert.ToChar(Console.ReadLine());

            if (karakter == 'E' || karakter == 'e')
            {
                goto tekrarbaşla;
            }

            else if (karakter == 'H' || karakter == 'h')
            {

            }

        }

    }
}


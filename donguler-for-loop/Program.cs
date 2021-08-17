using System;

namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // int i=0: dongunun sayacinin tanimlandigi atamasinin yapildigi yer
            // i<length : dongunun sayacinin devam etme kosulu
            // i++ : dongunun sayacinin arttirim ya da azaltim sekli
            // for(;;) : sonsuz dongu

            //ekrandan girilen sayiya kadar olan tek sayilari yazdir
            Console.WriteLine("Bir sayı giriniz");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayac; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i%2 ==1 )
                    tekToplam += i;
                else
                    ciftToplam += i;
            }
            Console.WriteLine("Tek sayıların toplamı: " + tekToplam);
            Console.WriteLine("Cift sayıların toplamı: "+ ciftToplam);

            // break, continue
            // break: donguden cikmak istenildiginde kullanilir
            for (int i = 1; i < 10; i++)
            {
                if (i ==4)
                    break;
                Console.WriteLine(i);
            }
            // continue: sadece mevcut iterasyonu atlar sonrakinden devam eder
            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}

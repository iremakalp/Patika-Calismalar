using System;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi tanimlama

            string[] renkler = new string[5];
            string[] hayvanlar = { "kuş", "kedi", "kanarya" };

            int[] dizi;
            dizi = new int [4];

            // dizilere erisim ve atama
            renkler[0] = "Kırmızı";  
            dizi[3] = 10;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            string[] renkler2 = { "Mavi", "Kırmızı", "Sarı", "Yeşil" };
            string renk = renkler2[1]; // Kırmızı rengi getirir.

            //Dongulerle dizi kullanimi
            // klavyeden girilen n tane sayının ortalamasını alan program

            Console.Write("dDizinin elaman sayısını giriniz: ");
            int elemanSayisi = int.Parse(Console.ReadLine());
            int[] sayilar = new int[elemanSayisi];
            int toplam = 0;

            for (int i = 0; i < elemanSayisi; i++)
            {
                Console.WriteLine("Lütfen {0}. sayiyi giriniz: ", i+1);
                int sayi = int.Parse(Console.ReadLine());
                sayilar[i] = sayi;
            }
            foreach (var sayi in sayilar)
            {
                toplam += sayi;
            }
            Console.WriteLine("Ortalama: "+toplam/elemanSayisi);

            //********************************************//
            int[] sayiDizisi = new int[20];
            int toplam2 = 0;
            for (int i = 0; i < sayiDizisi.Length; i++)
            {
                Console.Write("Lütfen {0}. sayıyı girin:", i + 1);
                sayiDizisi[i] = Convert.ToInt32(Console.ReadLine());
                toplam += sayiDizisi[i];
            }
            double ortalama = toplam / 20;
            Console.WriteLine("Sayıların ortalaması: " + ortalama);
            Console.ReadLine();
        }
    }
}

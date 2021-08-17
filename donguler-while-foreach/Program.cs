using System;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // while : kosullar saglandikca komutlarin calistirilmasini saglar
            int sayac = 1;
            // 1den baslayarak console dan girilen sayidan
            // sayi dahil ortalama hesaplama
            Console.WriteLine("sayıyı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int toplam = 0;
            while (sayac<=sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine("Toplam: "+ toplam/sayi);

            // a dan zye kadar tum harfleri console a yazdir
            char character = 'a';
            while (character < 'z')
            {
                Console.Write(character);
                character++;
            }

            //foreach
            //
            string[] arabalar =  {"bmv","ford","Toyota" };
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}

﻿using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;
            // switch: expression yani kontrol edilmesi istenen kosul yazilir
            // default: hicbir case uyulmazsa calisacak ifade
            // break: kontrol sonlandirilir
            // case: kontrol edilen ifadenin veri tipine bagli kontroller
            // bir switch-case yapisinde yalnizca bir case calisir

            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak ayındasınız");
                    break;
                case 2:
                    Console.WriteLine("Şubat ayındasınız");
                    break;
                case 4:
                    Console.WriteLine("Nisan ayındasınız");
                    break;
                case 3:
                    Console.WriteLine("Mart ayındasınız");
                    break;
                case 8:
                    Console.WriteLine("Ağustos ayındasınız");
                    break;
                default:
                    // kullanici giriyor olsaydi
                    Console.WriteLine("Yanlış veri girişi");
                    break;
            }
            // birden fazla kosulda ayni kod calisacaksa 
            // asagidaki sekilde yapilir
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış mevsimindesiniz");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar mevsimindesiniz");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz mevsimindesiniz");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar mevsimindesiniz");
                    break;
                default:
                    break;
            }

        }
    }
}
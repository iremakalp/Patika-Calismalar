using System;

namespace TipDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {

            // Implicit Conversion : Bilincsiz Donusum
            //dusuk kapasiteli bir degiskenin kendinden daha yuksek
            // kapasiteli baska bir degiskene atanma islemi
            Console.WriteLine("*** Implicit Conversion ****");

            byte b = 5;
            sbyte s = 30;
            short sh = 10;

            int degisken = b + s + sh;
            Console.WriteLine("degisken: " + degisken);//cikti->45

            long long1 = degisken;
            Console.WriteLine("long: " + long1);//cikti->45

            float float1 = long1;
            Console.WriteLine("float: " + float1);//cikti->45

            string str = "irem";
            char ch = 'i';
            object obj = str + ch + degisken;
            Console.WriteLine("object: " + obj);

            //Explicit Conversion : Bilincli Donusum
            //c#'in kendi kendine yapamadigi donusumler
            // convert,parse,tostring() kullanarak yapilir
            //cevrimlerde veri kaybi olabilir
            Console.WriteLine("*** Explicit Conversion ****");
            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y: " + y); //cikti ->4

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t: " + t);//cikti ->100

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v: " + v);//cikti ->10

            // ToString metodu
            Console.WriteLine("*** ToString ****");
            int int1 = 6;
            string str2 = int1.ToString();
            Console.WriteLine(str2); // cikti->6

            string str3 = 12.5f.ToString();
            Console.WriteLine(str3); // cikti->12,5

            // System.Convert
            Console.WriteLine("*** System.Convert ****");
            string str4 = "10", str5 = "20";
            int int2, int3, toplam;
            int2 = Convert.ToInt32(str4);
            int3 = Convert.ToInt32(str5);
            toplam = int2 + int3;
            Console.WriteLine("int2: " + int2); //cikti->10
            Console.WriteLine("int3: " + int3);//cikti->20
            Console.WriteLine("Toplam: " + toplam);//cikti->30

            //Parse
            Console.WriteLine("*** Parse ****");
            ParseMethod();

        }

        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;
            rakam1 = Int32.Parse(metin1);
            Console.WriteLine("rakam1: " + rakam1);//cikti->10
            double1 = double.Parse(metin2);
            Console.WriteLine("double1: " + double1);//cikti->1025

        }
    }
}

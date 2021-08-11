using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Atama ve İşlemli Atama Operatörleri *****");

            // atama ve islemli atama
            int x = 3;
            int y = 3;
            //islemli atama
            y += 2; //y=y+2;
            y /= 1;
            x *= 2;

            Console.WriteLine("***** Mantıksal Operatörler *****");
            //mantıksal operatorler
            // && || !
            bool isSuccess = true;
            bool isCompleted = false;
            if (isSuccess && isCompleted)// ture &&false
                Console.WriteLine("Perfect");

            if (isSuccess || isCompleted)// true || false
                Console.WriteLine("Great");

            /* !isCompeted-> true */
            if (isSuccess && !isCompleted) //true && true
                Console.WriteLine("Fine");

            Console.WriteLine("***** İlişkisel Operatörler *****");

            // iliskisel operatorler
            // < , > ,<= ,>=, == ,!=
            int a = 5;
            int b = 3;
            bool sonuc = a < b; // cikti ->false
            Console.WriteLine(sonuc);
            sonuc = a > b;
            Console.WriteLine(sonuc); //cikti ->true
            sonuc = a >= b;
            Console.WriteLine(sonuc);//true
            sonuc = a <= b;
            Console.WriteLine(sonuc);//false
            sonuc = a == b;
            Console.WriteLine(sonuc);//false
            sonuc = a != b;
            Console.WriteLine(sonuc);//true

            Console.WriteLine("*****Aritmatik Operatörler*****");
            // /,*,+,-
            int sayi1 = 10;
            int sayi2 = 5;
            int toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);//cikti ->15
            int cikarma = sayi1 - sayi2;
            Console.WriteLine(cikarma);//cikti ->5
            int bolu = sayi1 / sayi2;
            Console.WriteLine(bolu);//cikti ->2
            int carpi = sayi1 * sayi2;
            Console.WriteLine(carpi);//cikti ->50
            sayi1++;
            Console.WriteLine(sayi1);//cikti ->11

            // % :mod alir -> kalani alir
            int mod = 20 % 3;
            Console.WriteLine(mod); // cikti ->2


        }
    }
}

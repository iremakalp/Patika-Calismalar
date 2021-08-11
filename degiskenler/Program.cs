using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            // degisken isimleri case sensitive:buyuk kucuk harf duyarli
            // degisken ismi sayi ile baslayamaz
            // degisken ismi class olamaz
            // degisken isminde bosluk olamaz (_ olabilir)
            //
            string degisken = " ";
            // byte,sbyte: bellekte 1 byte yer kaplar
            // byte 0-255 arasi deger
            // sbyte -128 127 arasi deger
            byte b = 5;
            sbyte c = 5;
            // short,ushort: bellekte 2 byte yer kaplar 
            //short : -32768 +32768e kadar deher alir
            // ushort: 0-65365 arasi deger alir
            short s = 5;
            ushort us = 5;
            // int16:bellekte 2 byte yer kaplar
            // int bellekte 4byte yer kaplar
            // int32 bellekte 4byte yer kaplar
            //int64 bellekte 8byte yer kaplar
            // uint bellekte 4byte yer kaplar
            Int16 i16 = 2;
            int i = 2;
            Int32 i32 = 2;
            Int64 i64 = 2;
            uint ui = 2;
            // long: bellekte 8byte yer kaplar
            // ulong: bellekte byte yer kaplar
            long l = 4;
            ulong ul = 4;
            // float,double,decimal:reel sayilar icin kullanilir
            // float: bellekte 4byte yer kaplar
            // double: bellekte 8byte yer kaplar
            // decimal : bellekte 16byte yer kaplar
            float f = 5;
            double d = 5;
            decimal de = 5;
            // char: tek karakter tutulmasi isteniyorsa
            // char: bellekte 2byte yer kaplar
            // string: sinirsizdir
            char ch = 'a';
            char ch2 = '2';
            string str = "irem";
            // bool: true/false tutar
            bool bl = true;
            //datetime : tarih ve saat getirir
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            // karmasik tipler
            // tum degisken tipleri birer objecttir
            // her turlu veri object turde tutulabilir
            object o1 = "x";
            object o2 = 'c';
            object o3 = 5;
            object o4 = 4.3;
            object o5 = true;
            // var : tur belirtmeden degisken tanimlamada kullanilir
            //objectten farki referans tip degiskenler degil
            // deger atanirken tipi belirlenen degiskenlerdir
            var v1 = true;
            var v2 = "ürün eklendi";
            var v3 = 'a';

            // string ifadeler
            string str1 = string.Empty;
            //string str=null;
            //string str1="";
            str1 = "irem";

            string ad = "irem";
            string soyad = "akalp";
            string tamIsım = ad + " " + soyad;

            //integer tanimlama sekilleri
            int int1 = 5;
            int int2 = 3;
            int carpim = int1 * int2;

            //boolean
            bool b1 = 10 < 2;
            bool b2 = 5 % 2 == 0;

            // degisken donusumu
            string str2 = "20";
            int int3 = 20;
            string yeniDeger = str2 + int3;
            Console.WriteLine(yeniDeger);//ciksti->2020

            int int4 = int3 + Convert.ToInt32(str2);
            Console.WriteLine(int4);//cikti->40
            // int.parse() : string bir ifadeyi integer haline cevirir
            // string ifade de sayi degil karakter olursa parse isleminde hata alinir
            int int5 = int3 + int.Parse(str2);
            Console.WriteLine(int5); //cikti-->40

            //datetime
            // tostring(): datettime'i istedigimiz sekilde formatlar
            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);//cikti->11.08.2021

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);//cikti->14:08

        }
    }
}

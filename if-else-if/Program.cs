using System;

namespace if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            if (time >= 6 && time < 11)
                Console.WriteLine("Günaydın");
            else if (time <= 18)
                Console.WriteLine("İyi günler");
            else
                Console.WriteLine("İyi geceler");

            //ternary if
            // ?'den sonraki kisim if
            // :'den sonraki kisim else
            string sonuc = time <= 18 ? "iyi günler" : "iyi geceler";
            Console.WriteLine(sonuc);

            //2 ternary if yani if-else if-else yapisi
            sonuc = time >= 6 && time <= 11 ? "Günaydın"
            : time <= 18 ? "İyi günler" : "İyi geceler";

            bool condition = true;
            if (condition)
            {
                Console.WriteLine("Değişken: true");
            }
            else
            {
                Console.WriteLine("Değişken: false");
            }
        }
    }
}

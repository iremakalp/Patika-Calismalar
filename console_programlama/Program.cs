using System;

namespace console_programlama
{
    class Program
    {
        // main metot bir programin basladigi ve bittigi yer
        // public : metot heryerden erisilebilir 
        // static: bir nesnesi yaratilmadan main metoduna ulasilabilir
        // void : geri donus degerinin olmadigi anlamina gelir
        // string [] args : komut satirindaki argumanlarini almak icin

        public static void Main(string[] args)
        {
            Console.WriteLine("İsminizi Giriniz:");
            string name = Console.ReadLine();
            Console.WriteLine("Soyisminizi Giriniz:");
            string surname = Console.ReadLine();

            Console.WriteLine("Merhaba" + " " + name + " " + surname);

        }
    }
}

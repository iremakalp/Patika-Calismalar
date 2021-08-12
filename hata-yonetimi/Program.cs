using System;

namespace hata_yonetimi
{
    class Program
    {
        //Exception Handling: Hata Yonetimi 
        // hatalar 2ye ayrilir
        //1->compiler time: kod yazilirken derleyicinin firlattigi hatalar
        // 2-> run time: buradaki hatalari kontrol etmek gerekir
        // kontrol edilmezse beklenmedik bir anda programi calisirken kirar

        static void Main(string[] args)
        {
            // try : hataya sebebiyet verme ihtimali olan kod blogu
            // catch : hata ile karsilasildiginde ne yapilacagi kod blogu
            // finally: hata olsun olmasin mutlaka yapilmasi gereken islem blogu

            try
            {
                Console.WriteLine("Bir sayi giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girilen sayi: " + sayi);
            }
            catch (Exception ex)
            {
                // TODO 
                // sayi yerine string bir ifade girilirse calisir
                Console.WriteLine("Hata: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı");
            }

            // ArgumanNullException hatasi
            try
            {
                int a = int.Parse(null);
            }
            catch (ArgumentNullException ex)
            {
                // TODO
                Console.WriteLine("Boş değer girdiniz");
                Console.WriteLine(ex);
            }
            // FormatException hatasi
            try
            {
                int a = int.Parse("test");
            }
            catch (FormatException ex)
            {
                // TODO
                Console.WriteLine("Veri tipi uygun değil");
                Console.WriteLine(ex);
            }
            // OverflowException hatasi
            try
            {
                int a = int.Parse("-20000000000");
            }
            catch (OverflowException ex)
            {
                // TODO
                Console.WriteLine("Çok küçük ya da çok büyük bir değer girdiniz");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("işlem başarıyla tamamlandı");
            }

            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = a + b;
                Console.WriteLine(c);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bir Hata Oluştu: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı.");
            }
        }
    }
}

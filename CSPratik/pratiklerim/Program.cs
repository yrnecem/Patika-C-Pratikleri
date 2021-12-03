using System;

namespace hata
{
    class Program
    {
        static void Main(string[] args)
        {
             try
            {

            Console.WriteLine("Bir Sayı Giriniz!");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girmiş Olduğunuz Sayı:" + sayi );

            }

            catch(Exception ex)

            {

            Console.WriteLine("Hata!" + ex.Message.ToString());  

            }

           // finally
           // {

           // Console.WriteLine("İşlem Tamamlandı");

           // } 


           try
           {

               int a = int.Parse(null);
           }

           catch (ArgumentNullException ex) 
           {
            Console.WriteLine("Boş Sayı Girdiniz");
            Console.WriteLine(ex);
                           
           }

           catch (FormatException ex)

           { 

           Console.WriteLine("Veri Tipi Uygun Değil");
           Console.WriteLine(ex);

           }

           catch (OverflowException ex)
           {
           Console.WriteLine("Çok küçük veya Çok büyük bir veri girdiniz");
           Console.WriteLine(ex);
           }
        }
    }
}

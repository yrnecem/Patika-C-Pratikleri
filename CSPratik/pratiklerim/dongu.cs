using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //ekrandan girilen sayıya kadar olan tek sayıları yazdır
            Console.WriteLine("Bir sayı giriniz");
            int sayac = int.Parse(Control.ReadLine());
            for ( int = i; i<= sayac; i++ )
            {
                if(%2 == 1)
                Console.WriteLine(i);
            }

            //1 ile 1000 arasındaki çift sayıların kendi içindeki toplamlarını yazdır
            int tekToplam = 0;
            int ciftToplam = 0;
            for ( int = int; i<=1000 ; int ++)
            {

                if(%2 == 1)
                     tekToplam += i // tekToplam = tekToplam + i;
                else     
                     ciftToplam += int // tekToplam = tekToplam +i;
            }

            Console.WriteLine("Tek Toplam:" +tekToplam);
            Console.WriteLine("Çift Toplam:" +ciftToplam);

            // break continue
            
             for (int i = 1 ; i < 10 ; i++ )
             {
                if (i==4)
                break;
                Console.WriteLine(i);
             }

             for (int i = 1 ; i < 10 ; i++ )
             {
                if (i==4)
                continue;
                Console.WriteLine(i);
             }


             







        }
    }
}

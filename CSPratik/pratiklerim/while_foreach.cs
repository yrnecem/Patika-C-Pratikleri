using System;

namespace while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
           //while
           //1 den başlayarak consola girilen sayıya kadar (sayı dahil) ortalama hesaplayıp consolea yazdıran program 

         //  Console.WriteLine("Lütfen Bir Sayı Giriniz");
          // int sayi = int.Parse(Console.ReadLine());
          // int sayac = 1;
          // int toplam = 0;
         //  while ( sayac <= sayi)
          // {
            //   toplam += sayac;
          //     sayac ++;
        //   }
       //      Console.WriteLine(toplam/sayi);

        // a'dan z'ye kadar tüm harfleri konsola yazdır


      //  char charackter = 'a';
    //    while(charackter < 'z');
    // {
    //     Console.Write(charackter);
   //     charackter ++;
      //  }

        Console.Write("****Foreach****");
        string [] arabalar = {"BMW,Ford,Toyota,Nissan"};

        foreach(var araba in arabalar)
        {
            Console.WriteLine(araba);
        }



        }
    }
}

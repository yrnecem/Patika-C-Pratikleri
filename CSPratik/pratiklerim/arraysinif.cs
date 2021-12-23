using System;

namespace arraysinif
{
    class Program
    {
        static void Main(string[] args)
        {
         
         //Sort

         int[] sayiDizisi = {12,23,45,34,67,87,65};
         
         Console.WriteLine("****Sırasız Dizi*******");
         foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);

         Console.WriteLine("*****Sıralı Dizi*******");
         Array.Sort(sayiDizisi);    
  
         foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);


            //Clear

           Console.WriteLine("****Array Clear*****");
           //sayıDizisi elemanlarını kullanarak 2. indexten itibaren 0'lar.

           Array.Clear(sayiDizisi,2,2);

           
         foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);

            //Reverse
            Console.WriteLine("****Array Reverse*****");
            Array.Reverse(sayiDizisi);

         foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);   
         
         
         
         
         
         
         
         
         
            
        }
    }
}

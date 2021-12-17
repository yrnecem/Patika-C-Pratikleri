using System;

namespace generic_koleksiyon
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<t> class
            // System.Collections.Generic
            // T-> object türündedir.

            List<int> sayiListesi = new List<int> ();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string> ();

            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Mor");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count


            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);


            foreach (var sayi in sayiListesi)
                 Console.WriteLine(sayi);
            foreach (var renk in renkListesi);
                 Console.WriteLine(renk);       



            sayiListesi.foreach (sayi=> Console.WriteLine(sayi));
            renkListesi.foreach (renk=> Console.WriteLine(renk));

          //Listeden eleman çıkarma


            sayiListesi.Remove(4);
            renkListesi.Remove("Kırmızı");


           sayiListesi.RemoveAt(0);
           renkListesi.RemoveAt(1);

           sayiListesi.foreach (sayi=> Console.WriteLine(sayi));
           renkListesi.foreach (renk=> Console.WriteLine(renk));



           //Liste içeriside arama

           if(sayiListesi.Contains(10))
           Console.WriteLine("10 Liste içerisinde bulundu!");

           //Eleman ile index'e erişme

           Console.WriteLine(renkListesi.BinarySearch("Sarı"));

           //Diziyi List'e çevirme

           string[] hayvanlar = {"Kedi,Köpek,Kuş"};
           List<string> hayvanListesi = new List<string> (hayvanlar);


           //Listeyi nasıl temizleriz

           hayvanListesi.Clear();






























            {
                
            }
            {
                
            }
















        }
    }
}

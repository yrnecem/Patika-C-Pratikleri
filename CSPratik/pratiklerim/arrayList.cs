using System;

namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collections namespace

            ArrayList liste = new ArrayList();
            //liste.Add("Ecem");
            //liste.Add(2);
            //liste.Add(true);
            //liste.Add('E');


            //içerisinde verilere erişim
            //Console.WriteLine(liste[1]);

            //foreach ( var in item liste)
           //  Console.WriteLine(liste);


           //AddRange

            Console.WriteLine("*****Add Range*****");
            // string[] renkler = {"kırmızı,sarı,mavi"};
            List<int> sayılar = new List<int>() {1,2,3,6,77,16,59}; 
            // liste.AddRange(renkler);
            liste.AddRange(sayılar);

            foreach (var item in liste)
                Console.WriteLine(item);

            
            //Sort

            Console.WriteLine("****Sort****");
            liste.Sort();


            
            foreach (var item in liste)
                Console.WriteLine(item);



            //Reverse


            Console.WriteLine("***Reverse***");
            liste.Reverse();

            foreach (var item in liste)
                Console.WriteLine(item);


            //Clear

            liste.Clear();


            foreach (var item in liste)
                Console.WriteLine(item);






               





             
                  











        }
    }
}

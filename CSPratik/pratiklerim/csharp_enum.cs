using System;

namespace csharp_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);

            int sıcaklık = 32;
            if (sıcaklık <= (int)HavaSicakligi.Normal)
            
                Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekleyelim");
            
            else if (sıcaklık >= (int)HavaSicakligi.Sıcak)
                
                Console.WriteLine("Dışarıya çıkmak için sıcak bir gün.");

            else if (sıcaklık >= (int)HavaSicakligi.Normal && sıcaklık < (int)HavaSicakligi.CokSıcak)

                Console.WriteLine("Hadi dışarıya çıkalım!");



        }
    }

    enum Gunler
    {
     
     Pazartesi=1,

     Salı,

     Çarşamba,

     Perşembe,

     Cuma = 23,

     Cumartesi,

     Pazar


    }


    enum HavaSicakligi
    {

     Soguk = 5,


     Normal = 15,


     Sıcak =25,


     CokSıcak = 30









    }





}


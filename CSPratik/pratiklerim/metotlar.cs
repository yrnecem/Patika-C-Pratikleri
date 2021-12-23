using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b =3;
            
            Console.WriteLine(a+b);

            int sonuc = Topla(a,b);
            Console.WriteLine(sonuc);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));


        }


        static int Topla (int deger1, int deger2)
        {

            return (deger1 + deger2);
        }


    }


   class Metotlar

    {
          public void EkranaYazdir(string veri)
          {
              Console.WriteLine(veri);
          }


    }
}

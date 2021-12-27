using System;

namespace sinif_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
           //Söz dizimi
           //class sınıfAdı
           // {
           //    [Erişim Belirleyici]  [Veri Tipi] özellikAdı;
           //    [Erişim Belirleyici]  [Geri Dönüş Tipi]  MetotAdı([Parametre Listesi])

           //         {
           //              Metot Komutları
           //          } 


            //Erişim Belirleyiciler
            // *Public
            // *Private
            // *Internal
            // *Protected

            Calisan calisan1 = new Calisan();
            calisan1.Ad= "Yaren Ecem";
            calisan1.soyAd= "Terzioğlu";
            calisan1.No= 1905;
            calisan1.Departman= "İnsan Kaynakları";

            calisan1.CalisanBilgileri();


            Calisan calisan2 = new Calisan();
            calisan2.Ad= "Şevval";
            calisan2.soyAd= "İzgördü";
            calisan2.No= 2001;
            calisan2.Departman= "İnsan Kaynakları";
            
            calisan2.CalisanBilgileri();
          
        }
    }

    class Calisan

    {
        public string Ad;

        public string soyAd;

        public int No;

        public string Departman;


        public void CalisanBilgileri()
         {
        Console.WriteLine("Çalışan Adı:{0}", Ad);
        Console.WriteLine("Çalışan Soyadı:{0}", soyAd);
        Console.WriteLine("Çalışsan No:{0}", No);
        Console.WriteLine("Çalışan Departmanı:{0}", Departman);
         }
    }



    
}



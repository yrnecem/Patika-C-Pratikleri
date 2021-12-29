﻿using System;

namespace static_sinif_ve_uyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan sayısı     :{0}", Calisan.CalisanSayisi);
            
            Calisan calisan = new Calisan("Yaren Ecem","Terzioğlu", "IK");
            Console.WriteLine("Çalışan sayısı     :{0}", Calisan.CalisanSayisi);
            Calisan calisan1 = new Calisan ("Şevval","İzgördü", "IK");
            Calisan calisan2 = new Calisan ("Ceren", "Tarı", "IK");

            Console.WriteLine("Çalışan sayısı     :{0}", Calisan.CalisanSayisi);


            Console.WriteLine("Toplama işleminin sonucu      :{0}", Islemler.Topla(100,200));
            Console.WriteLine("Çıkarma İşleminin sonucu      :{0}", Islemler.Cikar(400,50));



        }
    }

    class Calisan
    {
      private static int calisanSayisi;

      private static int CalisanSayisi {get => calisanSayisi;}


      private string Isim;

      private string Soyisim;

      private string Departman;


      static Calisan () {}



      public Calisan(string isim, string soyisim, string departman)
      {

        this.Isim = isim;
        this.Soyisim = soyisim;
        this.Departman = departman;
        calisanSayisi ++;
      }

    }

      static class Islemler
      {
        public static long Topla ( int sayi1, int sayi2)
        {

           return sayi1 + sayi2;

        }
        public static long Cikar ( int sayi1, int sayi2)
        {

           return sayi1 - sayi2;

        }


      }







}

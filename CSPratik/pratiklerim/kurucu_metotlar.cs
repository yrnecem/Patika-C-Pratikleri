using System;

namespace kurucu_metotlar
{
    class kurucu_metotlar
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

            Calisan calisan1 = new Calisan("Yaren Ecem" , "Terzioğlu", 1905 , "İnsan Kaynakları");
            calisan1.CalisanBilgileri();


            Calisan calisan2 = new Calisan("Şevval", "izgördü", 2001, "İnsan Kaynakları");
            calisan2.CalisanBilgileri();
          
        }
    }

    class Calisan

    {
        public string Ad;

        public string soyAd;

        public int No;

        public string Departman;

        public Calisan(string Ad, string soyAd, int No, string Departman)
        {
        this.Ad= Ad;
        this.soyAd = soyAd;
        this.No = No;
        this.Departman = Departman;
        }


        public void CalisanBilgileri()
         {
        Console.WriteLine("Çalışan Adı:{0}", Ad);
        Console.WriteLine("Çalışan Soyadı:{0}", soyAd);
        Console.WriteLine("Çalışsan No:{0}", No);
        Console.WriteLine("Çalışan Departmanı:{0}", Departman);
         }
    }



    
}

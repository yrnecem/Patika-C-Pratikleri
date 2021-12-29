using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Yaren Ecem";
            ogrenci.Soyisim = "Terzioğlu";
            ogrenci.OgrenciNo = 1905;
            ogrenci.Sınıf= 3;
            ogrenci.OgrenciBilgileriniGetir();
        
            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();

        }

    }

   class Ogrenci
   {

     private string isim;

     private string soyisim;

     private int ogrenciNo;

     private int sınıf;


     public string Isim 
     {
      get { return isim; } 
      set { isim = value; }
      }

     public string Soyisim { get => soyisim; set=> soyisim = value; }

     public int OgrenciNo { get => ogrenciNo; set=> ogrenciNo = value; }


     public int Sınıf { get => sınıf; set=> sınıf = value; }


     public Ogrenci(string isim, string soyisim, int ogrenciNo, int sınıf)

     {
       Isim = isim;
       Soyisim = soyisim;
       OgrenciNo = ogrenciNo;
       Sınıf = sınıf;
      }

     public Ogrenci() {}

     public void OgrenciBilgileriniGetir()

     {

       Console.WriteLine("*******Öğrenci Bilgileri*******");
       Console.WriteLine("Öğrenci Adı         :{0}", this.Isim);
       Console.WriteLine("Öğrenci Soyisim     :{0}", this.Soyisim);
       Console.WriteLine("Öğrenci No          :{0}", this.OgrenciNo);
       Console.WriteLine("Öğrenci Sınıfı      :{0}", this.Sınıf);

     } 



       public void SinifAtlat()
       {

         this.Sınıf = this.Sınıf +1;   

       }
      
       public void SinifDusur()
       {


        this.Sınıf = this.Sınıf -1;


       }    
       


     }




   









}


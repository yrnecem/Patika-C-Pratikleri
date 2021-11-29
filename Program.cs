using System;

namespace tipler
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("******Implict Conversion*******");
           //Implict Conversion (Bilinçsiz Dönüşüm)

           byte a = 5;
           sbyte b = 10;
           short c = 20;

           int d = a+b+c;
           Console.WriteLine("d:" + d);

           long h = d;
           Console.WriteLine("h:" + h);

           float i = h;
           Console.WriteLine("i:" + i);

           string e = "Ecem";
           char f = 'k';
           object g = e+f+d;
           Console.WriteLine("g:" + g);

           //Explicit Conversion (Bilinçli Dönüşüm)

           Console.WriteLine("*****Explicit Conversion*****");

           int x = 4;
           byte y = (byte)x;
           Console.WriteLine("y:" + y);

           int z = 100 ;
           byte t = (byte)z;
           Console.WriteLine("t:" + t);

           float w = 10.3f;
           byte v = (byte)w;
           Console.WriteLine("v:" + v);


           //toString Methodu

           Console.WriteLine("****toString Methodu****");

           int xx = 6;
           string yy = xx.ToString();
           Console.WriteLine("yy:" + y);

           string zz = yy.ToString();
           Console.WriteLine("zz:" + z);

           //System.Convert 

           Console.WriteLine("*****System.Convert Sınıfı*****");

        string s1 = "10" , s2 = "20";
        int sayi1, sayi2;
        int Toplam;

        sayi1 = Convert.ToInt32(s1);
        sayi2 = Convert.ToInt32(s2);

        Toplam = sayi1 + sayi2;
        Console.WriteLine("Toplam:" + Toplam);



           








        }
    }
}

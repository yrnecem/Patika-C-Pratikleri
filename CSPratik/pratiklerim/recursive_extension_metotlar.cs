using System;

namespace recursive_extension_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //rekürsif özyinelemeli

            int result = 1;
            for (int i = 1; i < 5; i++)
                result = result * 3;
             Console.WriteLine(result);

             Islemler instance = new();
             Console.WriteLine(instance.Expo(3,4));

             //Extansion Metotlar

             string ifade = "Yaren Ecem Terzioğlu";
             bool sonuc = ifade.CheckSpaces();
             Console.WriteLine(sonuc);
             
             if(sonuc)
             {
               Console.WriteLine(RemoveWhiteSpaces());

             }




        }
    }


   public class Islemler{

      public int Expo(int sayi, int üs)
      {

        if (üs <2)
            return sayi;
         return Expo(sayi, üs-1)* sayi;   

      }

         public static class Extension{


    

         public static bool CheckSpaces(this string param)
         {
             return param.Contains(" ");
         }


         public static string RemoveWhiteSpaces(this string param)
         {
           string[] dizi = param.Split(" ");
           return string.Join("",dizi);


         }
   }


}

using System;
namespace ConsoleApp10
{
    class Program
    {
       static void Main(string[] args)
        {
            Ogrenci ogr1 = new Ogrenci();
            ogr1.ad = "Yavuz";
            ogr1.no = "701";
            ogr1.sube = "7/E";

            Ogrenci ogr2 = new Ogrenci();
            ogr2.ad = "Sevgi";
            ogr2.no = "123";
            ogr2.sube = "7/E";

            Ogrenci ogr3 = new Ogrenci();
            ogr3.ad = "Yigit";
            ogr3.no = "456";
            ogr3.sube = "5/A";

            Ogrenci[] ogrenciler = new Ogrenci[3];
            ogrenciler[0]=ogr1;
            ogrenciler[1]=ogr2;
            ogrenciler[2]=ogr3;

            foreach (var ogrenci in ogrenciler)
            {
                Console.WriteLine($"{ogrenci.ad} isimli öğrencinin şubesi:{ogrenci.sube} numarası{ogrenci.no}");
            }
        } 
    }
    class Ogrenci
    {
        public string ad {get; set;}
        public string no {get; set;}
        public string sube {get; set;}
    }
}
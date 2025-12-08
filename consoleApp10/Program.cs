using System;
namespace consoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr1 = new Ogrenci();
            ogr1.Ad = "Yavuz";
            ogr1.No = "701";
            ogr1.Sube = "7/E";

            Ogrenci ogr2 = new Ogrenci();
            ogr2.Ad = "Sevgi";
            ogr2.No = "123";
            ogr2.Sube = "7/A";

            Ogrenci ogr3 = new Ogrenci();
            ogr3.Ad = "Yiğit";
            ogr3.No = "456";
            ogr3.Sube = "5/A";

            Ogrenci[] ogrenciler = new Ogrenci[3];
            ogrenciler[0]= ogr1;
            ogrenciler[1]= ogr2;
            ogrenciler[2]= ogr3;

            foreach(var ogrenci in ogrenciler)
            {
                Console.WriteLine($"{ogrenci.Ad} isimli öğrencinin şubesi {ogrenci.Sube} ve numarası {ogrenci.No}");
            }
        }
    }
    class Ogrenci
    {
        public string Ad { get; set;}
        public string No { get; set;}
        public string Sube { get; set;}
    }
}
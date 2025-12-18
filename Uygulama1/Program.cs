using System;
using System.Collections.Generic;
using System.Linq;
namespace consoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constructor
            Ogrenci ogrenci1 = new Ogrenci("Yavuz Beydoğan","220912006","Hukuk");
            ogrenci1.TC = "1111111111111";
            ogrenci1.OgrenimDuzeyi = "Lisans";
            ogrenci1.Fakulte = "Mühendislik-Mimarlık";
            
            Ogrenci ogrenci2 = new Ogrenci("Sevgi Kanık","123123123","Hukuk");
            ogrenci2.TC = "2222222222222";
            ogrenci2.OgrenimDuzeyi = "Lisans";
            ogrenci2.Fakulte = "Hukuk Fakültesi ";
            
            List<Ogrenci> ogrenciListesi = new List<Ogrenci>();
            ogrenciListesi.Add(ogrenci1);
            ogrenciListesi.Add(ogrenci2);
            //Dictionary
            Dictionary<string, Ogrenci> ogrenciSozlugu = new Dictionary<string, Ogrenci>();
            ogrenciSozlugu.Add(ogrenci1.OkulNo, ogrenci1);
            ogrenciSozlugu.Add(ogrenci2.OkulNo, ogrenci2);

            string arananNo = "220912006";
            if (ogrenciSozlugu.ContainsKey(arananNo))
            {
                var bulunanOgrenci = ogrenciSozlugu[arananNo];
                Console.WriteLine($"Öğrenci Bulundu->{bulunanOgrenci.AdSoyad}");
            }
            else
            {
                Console.WriteLine($"Öğrenci Bulunamadı");
            }

            
            foreach (var hukukcular in ogrenciListesi.Where(ogrenci => ogrenci.Bolum == "Hukuk").OrderBy(ogrenci => ogrenci.AdSoyad))
            {
                Console.WriteLine($"Öğrencinin Adı: {hukukcular.AdSoyad}");
            }


        }
    }
    class Ogrenci
    {
        //properties
        public string TC {get; set;}
        public string AdSoyad{get; set;}
        public string OkulNo {get; set;}
        public string OgrenimDuzeyi {get; set;}
        public string Fakulte {get; set;} 
        public string Bolum {get; set;}
        public Ogrenci ( 
        string gelenAdSoyad, 
        string gelenOkulNo,
        string gelenBolum)
        {
            AdSoyad = gelenAdSoyad;
            OkulNo = gelenOkulNo;
            Bolum = gelenBolum;
        }


    }
     
}
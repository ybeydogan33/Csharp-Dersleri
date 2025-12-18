using System;
using System.Collections.Generic;
using System.Linq;
namespace consoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constructor Öğrenci
            Ogrenci ogrenci1 = new Ogrenci("Yavuz Beydoğan","220912006","Hukuk");
            ogrenci1.TC = "1111111111111";
            ogrenci1.OgrenimDuzeyi = "Lisans";
            ogrenci1.Fakulte = "Mühendislik-Mimarlık";

            Ogrenci ogrenci2 = new Ogrenci("Sevgi Kanık","123123123","Hukuk");
            ogrenci2.TC = "2222222222222";
            ogrenci2.OgrenimDuzeyi = "Lisans";
            ogrenci2.Fakulte = "Hukuk Fakültesi ";
            //Constructor Akademisyen
            Akademisyen akademisyen1 = new Akademisyen();
            akademisyen1.TC="12312312323";
            akademisyen1.AdSoyad="İbrahim Halil";
            akademisyen1.Bolum="Fizik";
            akademisyen1.Cinsiyet="Erkek";
            akademisyen1.Fakulte="Fizik Fakültesi";
            akademisyen1.Unvan="Profesör";
            
            List<Kisi> kisiListesi = new List<Kisi>();
            kisiListesi.Add(ogrenci1);
            kisiListesi.Add(ogrenci2);
            kisiListesi.Add(akademisyen1);

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

            foreach (var hukukcular in kisiListesi.Where(ogrenci => ogrenci.Bolum == "Hukuk").OrderBy(ogrenci => ogrenci.AdSoyad))
            {
                Console.WriteLine($"Öğrencinin Adı: {hukukcular.AdSoyad}");
            }

            foreach (var kisiler in kisiListesi)
            {
                kisiler.KendiniTanit();
                kisiler.DersIsle();
            }            
                ogrenci1.sarkiSoyle();
                ogrenci2.sporYap();
                
        }
    }
    abstract class Kisi
    {
        private string _tc;
        public string TC
        {
            get{return _tc;}
            set {
                if (value.Length == 11)
                {
                    _tc = value; // 11 hane ise kasaya koy
                }
                else
                {
                    Console.WriteLine("⚠️ HATA: TC Kimlik No 11 haneli olmalıdır! Değer atanmadı.");
                }
                }
        }
        public string AdSoyad{get; set;}
        public string Cinsiyet {get; set;}
        public string Fakulte{get; set;}
        public string Bolum {get; set;}
        public virtual void KendiniTanit()
        {
            Console.WriteLine($"Merhaba ben {this.AdSoyad}. {this.Bolum} bölümündeyim.");
        }
        public abstract void DersIsle();
    }
    interface IMuzisyen
    {
        void sarkiSoyle();
    }
    interface ISporcu
    {
        void sporYap();
    }
    class Ogrenci : Kisi , IMuzisyen, ISporcu
    {
        //properties
        public string OkulNo {get; set;}
        public string OgrenimDuzeyi {get; set;}
        public Ogrenci ( 
        string gelenAdSoyad, 
        string gelenOkulNo,
        string gelenBolum)
        {
            AdSoyad = gelenAdSoyad;
            OkulNo = gelenOkulNo;
            Bolum = gelenBolum;
        }
        public override void DersIsle()
        {
            Console.WriteLine("Ben öğrenciyim, dersi can kulağıyla dinliyorum. 👂");
        }
        public void sarkiSoyle()
        {
            Console.WriteLine($"Merhaba ben {this.AdSoyad}. Ders aralarında gitar çalıyorum! 🎸");
        }
        public void sporYap()
        {
            Console.WriteLine($"Merhaba ben {this.AdSoyad}. Hafta sonları koşuya çıkıyorum! 🏃");
        }



    }
    class Akademisyen : Kisi
    {
        public string Unvan{get; set;}
        public override void KendiniTanit()
        {
            Console.WriteLine($"Merhaba ben {this.Unvan} {this.AdSoyad}. {this.Bolum} bölümündeyim.");
        }
        public override void DersIsle()
        {
            Console.WriteLine("Ben akademisyenim, dersi anlatıyorum. 👨‍🏫");
        }

    }
}
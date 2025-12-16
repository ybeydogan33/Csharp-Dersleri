using System;
namespace consoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Soru soru1 = new Soru(1,"Hangisi programlama dili değildir?", new string[4] {"Python", "Java", "C#", "html"},"html");
            Soru soru2 = new Soru(1,"Hangisi en popüler programlama dilidir?", new string[4] {"Python", "Java", "C#", "html"},"C#");
            Soru soru3 = new Soru(1,"Hangisi en popüler web programlama platformudur?", new string[4] {"Python", "Java", "C#", "html"},"Python");
            Soru soru4 = new Soru(1,"Hangisi en zor programlama dilidir?", new string[4] {"Python", "Java", "C#", "html"},"java");
            Soru[] sorular = new Soru[4];
            sorular[0]= soru1;
            sorular[1]= soru2;
            sorular[2]= soru3;
            sorular[3]= soru4;
            var sayac = 1;
            var dogru =0;
            var yanlis =0;
            foreach(var soru in sorular)
            {
                Console.WriteLine($"Soru:{sayac}) {soru.SoruMetni} ");
                foreach(var secenek in soru.Secenekler)
                {
                    Console.WriteLine($"{secenek}");
                }
                Console.Write("Cevabınız:");
                var cevap = Console.ReadLine();
                if (soru.cevapKontrol(cevap))
                {
                    Console.WriteLine("-Cevabınız doğru-");
                    dogru++;
                }
                else
                {
                    Console.WriteLine("-Cevabınız yanlış-");
                    yanlis++;
                }
                sayac++;
            }
                Console.WriteLine($"Test Sonuçları");
                Console.WriteLine($"Doğru:{dogru}");
                Console.WriteLine($"Yanlış:{yanlis}");
        }

        
    }
    class Soru
    {
        public int SoruID {get;set;}
        public string SoruMetni {get; set;}
        public string[] Secenekler {get; set;}
        public string Cevap {get; set;}
        public Soru(int soruID, string soruMetni, string[] secenekler, string cevap)
        {
            this.SoruID = soruID;
            this.SoruMetni = soruMetni;
            this.Secenekler = secenekler;
            this.Cevap = cevap;
        }
        public bool cevapKontrol(string cevap)
        {
            return this.Cevap.ToLower()==cevap.ToLower();
        }

    }
}
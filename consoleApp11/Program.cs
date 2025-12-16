using System;
namespace consoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Soru soru1 = new Soru()
            {
                SoruMetni = "Hangisi programlama dili değildir?",
                Secenekler = new string[4] {"Python", "Java", "C#", "html"},
                Cevap = "html"
            };
            Soru soru2 = new Soru()
            {
                SoruMetni = "Hangisi en popüler programlama dilidir?",
                Secenekler = new string[4] {"Python", "Java", "C#", "html"},
                Cevap = "C#"
            };
            Soru soru3 = new Soru()
            {
                SoruMetni = "Hangisi en popüler web programlama platformudur?",
                Secenekler = new string[4] {"Python", "Java", "C#", "html"},
                Cevap = "python"
            };
            
            Soru[] sorular = new Soru[3];
            sorular[0]= soru1;
            sorular[1]= soru2;
            sorular[2]= soru3;
            var sayac = 1;
            var dogru = 0;
            var yanlıs = 0;
            foreach (var soru in sorular)
            {
                Console.WriteLine($"Soru:{sayac}) {soru.SoruMetni}");
                foreach (var secenek in soru.Secenekler)
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
                    Console.WriteLine("-Cevabınız Yanlış-");
                    yanlıs++;
                }
                sayac++;

            }
                Console.WriteLine($"Test Sonuçları");
                Console.WriteLine($"Doğru:{dogru}");
                Console.WriteLine($"Yanlış:{yanlıs}");
        }
    }
    class Soru
    {
        public string SoruMetni {get; set;}
        public string[] Secenekler {get; set;}
        public string Cevap {get; set;}
        public bool cevapKontrol(string cevap)
        {
            return this.Cevap.ToLower() == cevap.ToLower();
        }
    }
}
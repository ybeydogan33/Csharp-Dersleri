using System;
namespace consoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Soru soru1 = new Soru(1,"Hangisi programlama dili değildir?", new string[4] {"Python", "Java", "C#", "html"},"html");
            Soru soru2 = new Soru(1,"Hangisi en popüler programlama dilidir?", new string[4] {"Python", "Java", "C#", "html"},"C#");
            Soru soru3 = new Soru(1,"Hangisi en popüler web programlama platformudur?", new string[4] {"Python", "Java", "C#", "html"},"Python");
            Soru soru4 = new Soru(1,"Hangisi en zor programlama dilidir?", new string[4] {"Python", "Java", "C#", "html"},"Java");       
            Console.WriteLine(soru1.SoruYazdir());
            Console.WriteLine(soru2.SoruYazdir());
            Console.WriteLine(soru3.SoruYazdir());
            Console.WriteLine(soru4.SoruYazdir());
        }
    }
    class Soru
    {
        public Soru (int soruID, string soruMetni, string[] secenekler, string cevaplar)
        {
            this.SoruID=soruID;
            this.SoruMetni=soruMetni;
            this.Secenekler=secenekler;
            this.Cevaplar=cevaplar;
        }
        public int SoruID {get; set;}
        public string SoruMetni{get; set;}
        public string[] Secenekler{get; set;}
        public string Cevaplar{get; set;}
        public string SoruYazdir()
        {
            string soru ="";
            soru += this.SoruMetni +"\n";
            foreach(var secenek in this.Secenekler)
            {
                soru += secenek +"\n";
            }

            return soru;
        }
        public bool cevapKontrol(string cevap)
        {
            return this.Cevaplar.ToLower() == cevap.ToLower();
        }
    }
}
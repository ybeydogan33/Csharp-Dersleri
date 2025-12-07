var toplam = 0;
for (var i = 1;i<=100;i++)
{
    toplam = toplam + i;
}
Console.WriteLine(toplam);


Console.Write("Başlangıç değerini girin:");
int baslangic = int.Parse(Console.ReadLine()??"0");
Console.Write("Son değeri giriniz:");
int son = int.Parse(Console.ReadLine()??"0");
var Toplam = 0;
for (var i = baslangic ; i<=son ; i++)
{
    Toplam = Toplam + i;
}
Console.WriteLine(Toplam);


string[] isimler = {"sevgi","kanik","yavuz","alp","beydoğan"};
for(var i = 0; i < isimler.Length; i++)
{
    Console.WriteLine(isimler[i]);
}


int[] sayilar = {1,3,4,34,41,56,89,99};
for (var i = 0; i<sayilar.Length; i++)
{
    if(sayilar[i]%3==0)
    Console.WriteLine(sayilar[i]);
}
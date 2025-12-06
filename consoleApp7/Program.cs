Console.Write("Yapmak İstediğiniz İşlemi Seçin:(+ - * /):");
char secim = char.Parse(Console.ReadLine() ?? "!");
Console.Write("1. Sayıyı Giriniz:");
int Sayi1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("2. Sayıyı Giriniz:");
int Sayi2 = int.Parse(Console.ReadLine() ?? "0");
double sonuc = 0;
if (secim == '+')
{
     sonuc = Sayi1 + Sayi2;
}
else if (secim == '-')
{
     sonuc = Sayi1- Sayi2;
}
else if (secim == '*')
{
     sonuc = Sayi1 * Sayi2;
}
else
{
     sonuc = (double)Sayi1 / (double)Sayi2; 
}
Console.WriteLine(sonuc);

Console.Write("1.Yazılı:");
int not1 = int.Parse(Console.ReadLine()??"0");
Console.Write("2.Yazılı:");
int not2 =int.Parse(Console.ReadLine()??"0");
Console.Write("Sözlü:");
int sozlu = int.Parse(Console.ReadLine()??"0");

int ortalama = (not1+not2+sozlu)/3;

if (ortalama>=0 && ortalama < 24)
{
    Console.WriteLine("Alınan Not: 0");
}
else if (ortalama>=25 && ortalama < 44)
{
    Console.WriteLine("Alınan Not: 1");
}
else if (ortalama>=45 && ortalama < 54)
{
    Console.WriteLine("Alınan Not: 2");
}
else if (ortalama>=55 && ortalama < 69)
{
    Console.WriteLine("Alınan Not: 3");
}
else if (ortalama>=70 && ortalama < 84)
{
    Console.WriteLine("Alınan Not: 4");
}
else
{
    Console.WriteLine("Alınan Not: 5");
}

Console.Write("1.Sayıyı Giriniz:");
int sayi1 = int.Parse(Console.ReadLine()??"0");
Console.Write("1.Sayıyı Giriniz:");
int sayi2 = int.Parse(Console.ReadLine()??"0");
Console.Write("1.Sayıyı Giriniz:");
int sayi3 = int.Parse(Console.ReadLine()??"0");

int enbuyuk = sayi1;

if (sayi1>sayi2 && sayi1>sayi3)
{
    enbuyuk=sayi1;
}
else if (sayi2>sayi1 && sayi2 > sayi3)
{
    enbuyuk=sayi2;
}
else
{
    enbuyuk=sayi3;
}
Console.WriteLine($"En büyük sayı: {enbuyuk}");
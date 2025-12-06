var oyKullanma = 18;
Console.Write("Yaşınız:");
var yas = int.Parse(Console.ReadLine() ?? "0");
var sonuc = (yas >=oyKullanma )? "Oy Kullanabilir." : "Oy Kullanamaz.";
Console.WriteLine(sonuc);

Console.Write("Sayı giriniz:");
var sayi2 = int.Parse(Console.ReadLine() ?? "0");
var sonuc2 = sayi2<0 ? "İşareti: -" : sayi2==0 ? "Sayı 0": "İşareti +";
Console.WriteLine(sonuc2);

Console.Write("Sayı Giriniz:");
var sayi3 = int.Parse(Console.ReadLine() ?? "0");
var sonuc3 = (sayi3%2 ==0) ? "Sayı Çift": "Sayı Tek";
Console.WriteLine(sonuc3);

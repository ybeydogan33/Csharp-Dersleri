string[] ogrenciAd = new string[3];
int[] ogrenciNot = new int[3];

Console.Write("1. Öğrencinin İsmini Giriniz: ");
ogrenciAd[0] = Console.ReadLine() ?? "";
Console.Write("1. Öğrencinin Notunu Giriniz: ");
ogrenciNot[0] = Convert.ToInt32(Console.ReadLine());

Console.Write("2. Öğrencinin İsmini Giriniz: ");
ogrenciAd[1] = Console.ReadLine() ?? "";
Console.Write("2. Öğrencinin Notunu Giriniz: ");
ogrenciNot[1] = Convert.ToInt32(Console.ReadLine());

Console.Write("3. Öğrencinin İsmini Giriniz: ");
ogrenciAd[2] = Console.ReadLine() ?? "";
Console.Write("3. Öğrencinin Notunu Giriniz: ");
ogrenciNot[2] = Convert.ToInt32(Console.ReadLine());


int sira = 1;
foreach(var isim in ogrenciAd[..2])
{
    Console.WriteLine($"{sira}. öğrencinin Adı: {isim}");
    sira++;
}
int sira1 = 1;
foreach(var not in ogrenciNot[..2])
{
    Console.WriteLine($"{sira1}. öğrencinin notu: {not}");
    sira1++;
}

Console.WriteLine($"Dizinin uzunluğu: {ogrenciAd.Length}");

var not1 = ogrenciNot[0];
var not2 = ogrenciNot[1];
var not3 = ogrenciNot[2];

var ortalama = (not1+not2+not3)/3;
Console.WriteLine($"Not Ortalaması: {(ortalama)}");
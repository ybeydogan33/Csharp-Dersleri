int a = 10;
int b = 5;
int c = 20;
var sonuc = (c-a)*b;
Console.WriteLine(sonuc);

int? a1 = null ;
int b1 = 20;
var sonuc1 = (a1 ?? 0)+b1;
Console.WriteLine(sonuc1);

int a2 = 10;
int b2 = 20;
a2=b2--;
Console.WriteLine(a2);
Console.WriteLine(b2);

Console.Write("Sayı:");
int sayi = int.Parse(Console.ReadLine() ?? "0");
int sonuc2 = sayi % 2; 
if (sonuc2 == 1){
    Console.WriteLine("Tek");
}
else{
    Console.WriteLine("Çift");
}






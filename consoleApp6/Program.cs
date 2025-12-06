Console.Write("Yaşınız:");
int yas = int.Parse(Console.ReadLine()?? "0");
bool veli_izni = true;
bool yasKontrol = (yas>=18);
bool veliKontol = (veli_izni);
var sonuc = (yasKontrol==true) || (veliKontol==true) ? "İşte Çalışabilir":"İşte Çalışamaz" ;
Console.WriteLine(sonuc);

Console.Write("Notunuzu Girin:");
int not = int.Parse(Console.ReadLine()??"0");
bool gecmeNotu = (50<=not && not<=100);
var sonuc1 = (gecmeNotu==true) ? "Geçti":"Kaldı";
Console.WriteLine(sonuc1);

Console.Write("Ortalamanız:");
int ort = int.Parse(Console.ReadLine()??"0");
bool zayif = true;
bool kosul = (ort>=70);
bool kosul2 = zayif;
var sonuc2 = kosul2==false && kosul==true ?"Teşekkür alabilir." : "Teşekkür alamaz.";
Console.WriteLine(sonuc2);

Console.Write("Eğitim Durumunuz:");
string egitim = Console.ReadLine() ?? "lise";
Console.Write("Sigara Kullanıyor musunuz:");
string sigara = Console.ReadLine() ?? "yok";
var sonuc3 = ((egitim=="lisans" || egitim=="önlisans") && sigara=="hayır") ? "Çalışabilirsiniz": "Çalışamazsınız";
Console.WriteLine(sonuc3);
string email = "yavuzalp@gmail.com";
string username = "yavuz123";
string password = "123456";
var sonuc4 = ((username=="yavuz123")||(email=="yavuzalp@gmail.com")) && (password=="123456")? "Giriş Yapıldı.": "Yanlış Şifre veya kullanıcı adı.";
Console.WriteLine(sonuc4); 

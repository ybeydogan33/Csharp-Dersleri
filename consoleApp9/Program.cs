var rnd = new Random();
var tutulan = rnd.Next(1,100);
Console.WriteLine($"Tutulan sayı: {tutulan}");
for (var hak =5; hak>0; hak--){
    Console.Write($"{hak}. hak: ");
    int tahmin = int.Parse(Console.ReadLine()??"0");
    if(tahmin <tutulan){
        Console.WriteLine($"daha yukarı tahmin et.");
        continue;
    }
    else if (tahmin > tutulan){
        Console.WriteLine($"daha aşağı tahmin et.");
        continue;
    }
    else if (hak ==0){
        Console.WriteLine("Hakkınız bitti kaybettiniz.");
        break;
    }
    else{
        Console.WriteLine("Tebrikler doğru bildiniz.");
        break;
    }
}

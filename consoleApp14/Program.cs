using System;
namespace consoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            var yazdir = HelperMethod.karakterDuzelt("ölçme ve değerlendirme");
            Console.WriteLine(yazdir);
        }
    }
    class HelperMethod
    {
        public static string karakterDuzelt(string str)
        {
            return str.Replace("ö","o")
            .Replace("ü","u")
            .Replace("ı","i")
            .Replace("ğ","g")
            .Replace("ç","c")
            .Replace(" ","-");
        }
    }
}
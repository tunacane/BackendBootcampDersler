using System.Linq.Expressions;
using CalculatorDivide;


// Calculator hesapMakinesi = new Calculator();
// ScientificCalculator bilimselHesapMakinesi = new ScientificCalculator();


// Console.WriteLine("Hesap Makinesi");
// Console.WriteLine("1 - Toplama");
// Console.WriteLine("2 - Çıkarma");
// Console.WriteLine("3 - Çarpma");
// Console.WriteLine("4 - Bölme");
// Console.WriteLine("5 - Sinüs");
// Console.WriteLine("6 - Kosinüs");
// Console.WriteLine("Çıkmak için 'q' tuşuna basın.");

// while (true)
// {
//     System.Console.WriteLine("Seçiminizi yapınız: ");
//     string secim = Console.ReadLine();
//     if (secim.ToLower() == "q")
//     {
//         break;
//     }

//     double sayi1;
//     double sayi2; 
//     double sonuc;

//     switch (secim)
//     {
//         case "1":
//             bilimselHesapMakinesi.Topla();

//         default:
//     }

// }


class Program
{
    static void Main(string[] args)
    {

Calculator basicCalc = new Calculator();
Console.WriteLine("Toplama: " + basicCalc.Topla(5, 3));
Console.WriteLine("Çıkarma: " + basicCalc.Cikar(5, 3));
Console.WriteLine("Çarpma: " + basicCalc.Carpma(5, 3));
Console.WriteLine("Bölme: " + basicCalc.Bolme(5, 3));

ScientificCalculator sciCalc = new ScientificCalculator();
Console.WriteLine("Sin(30 derece): " + sciCalc.Sin(Math.PI / 6)); // 30 derece
Console.WriteLine("Cos(60 derece): " + sciCalc.Cos(Math.PI / 3)); // 60 derece
    }
}
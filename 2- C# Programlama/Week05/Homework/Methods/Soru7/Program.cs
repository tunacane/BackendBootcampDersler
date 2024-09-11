using System.Runtime.Serialization;

namespace Soru7;
/*Saat, dakika ve saniye alan bir metot yazın. Bu metot zamanı "HH:MM:SS" formatında döndürsün.*/


class Program
{

    static string TimeTempt(int hour, int min, int sec){
    
    return $"{hour}: {min}: {sec}";

     


    }


    static void Main(string[] args)
    {
        Console.Write("Saati giriniz: ");
        int hour = int.Parse(Console.ReadLine());

        Console.Write("Dakikayı giriniz: ");
        int min = int.Parse(Console.ReadLine());

        Console.Write("Saniyeyi giriniz: ");
        int sec = int.Parse(Console.ReadLine());

        string formattedTime = TimeTempt(hour, min, sec);

        System.Console.WriteLine($"Saat {formattedTime}");


    }
}

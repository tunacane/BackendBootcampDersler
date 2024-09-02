using System.Dynamic;
using System.Xml.Schema;

namespace Project13_GuessNumberGame;
/*uygulamanın rastgele üreteceği 1-100 arasındaki sayıyı tahmin ederek bulmasını sağlayan bir kod yazacağız
* kullanıcının tahmini üretilen sayıdan küçükse ya da büyükse buna göre yönlendire yapılsın
* kullanıcının 5 hakkı olsun
* kullanıcı doğru tahmin yaptıysa ya da tahmin hakkı dolduysa uygun mesajı vererek oyun sona ersin*/

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int generatedNumber = rnd.Next(1,101);
        System.Console.WriteLine($"HİLE --> {generatedNumber}");
        System.Console.WriteLine("**********************");
        System.Console.WriteLine();
        int guessNumber;
        int live = 1;
        int liveLimit = 5;
        string resultMessage="";
        string answer ="";


        do
        {
            Console.Write($"{live}.Hak(1-10): ");
            guessNumber = int.Parse(Console.ReadLine());

            if (guessNumber < generatedNumber)
            {
                resultMessage = "Daha büyük bir sayı giriniz.";
            }
            else if(guessNumber > generatedNumber)
            {
                resultMessage = "Daha küçük bir sayı giriniz.";
            }
            if (guessNumber != generatedNumber)
            {
                live++;   
            }
            if ((live <= liveLimit) && (guessNumber != generatedNumber))
            {
                System.Console.WriteLine(resultMessage);

            }

        } while (guessNumber != generatedNumber && live <= liveLimit );
        resultMessage = guessNumber == generatedNumber ? "Kazandın :) \nPuanın: {(liveLimit - live +1) *10}" : "Kaybettin";
        
        System.Console.WriteLine(resultMessage);
        Console.Write("Devam etmek ister misiniz? (E/H)");
        
        
        







    }
}

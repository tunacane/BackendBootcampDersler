namespace Soru5;
/*Bir string dizisindeki tüm isimleri büyük harfe çeviren bir metot yazın.*/


class Program
{
    static string UpperCase(string word ="tunacan"){

        string newWord = word.ToUpper();
        return newWord;

    }

    static void Main(string[] args)
    {
        string newWord = UpperCase();
        System.Console.WriteLine(newWord);
    }
}

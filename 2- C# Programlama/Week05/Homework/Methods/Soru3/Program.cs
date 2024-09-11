namespace Soru3;
/* Parametre olarak bir kelime alıp, bu kelimeyi tersine çevirerek geri döndüren bir metot yazın.**/

class Program
{

    static string Reversed(string word){
      
        char[] array = word.ToCharArray();
        Array.Reverse(array);

        return  new string(array);
    }



    static void Main(string[] args)
    {
        string word = "tunacan";

     System.Console.WriteLine(Reversed(word));

        

    }
}

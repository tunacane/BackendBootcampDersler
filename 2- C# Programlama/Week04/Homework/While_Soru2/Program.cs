using System.Reflection;
using System.Reflection.PortableExecutable;

namespace While_Soru2;

class Program
{
    static void Main(string[] args)
    {
      
      System.Console.WriteLine("Bir metin giriniz: ");

        string text = Console.ReadLine();

        string result="";
        int i =0;

        while (i < text.Length)
        {
          char karakter = text[i];

          if (char.IsLetter(karakter))
          {
            result +=char.ToUpper(karakter);
          }
          else
          {
            result +=karakter;
        
      }
      i++;
    }
    System.Console.WriteLine(result);

  }
}

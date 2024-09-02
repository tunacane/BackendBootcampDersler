using System.Formats.Asn1;
using System.Reflection.Metadata;

namespace Project12_Loops;

class Program
{
    static void Main(string[] args)
    {
        // sadece sayı girişi yaptıralım

        /*   ConsoleKeyInfo character;
          string resultNumber ="";
          System.Console.Write("Bir sayı giriniz: ");

             do
             {
                 character = Console.ReadKey(true);

                 if (char.IsDigit(character.KeyChar))
                 {
                     resultNumber += character.KeyChar.ToString();
                     Console.Write(character.KeyChar.ToString());
                 }

                 else
                 {
                     if (character.Key== ConsoleKey.Backspace && resultNumber.Length >0)
                     {

                         resultNumber= resultNumber.Substring(0, resultNumber.Length -1); // 65432 6543
                         Console.Write("\b \b");
                     }
                 }


             } while (character.Key != ConsoleKey.Enter); */

        #region Asal

        /*    bool IsPrime = true;
             Console.Write("Bİr sayı giriniz: ");
             int number = int.Parse(Console.ReadLine());

             if (number <= 1)
             {
                 IsPrime =false;
             }
             else
             {

                 for (int i = 2; i <= number-1; i++)

                 {
                     if (number %i ==0)
                     {
                         IsPrime = false;
                         break;
                     }
                 }
             }

             Console.WriteLine(IsPrime==true ? "Asal" : "Asal değil");
           //  Console.WriteLine(IsPrime ? "Asal" : "Asal değil");*/



        /*    string answer;
            do
            {

                bool IsPrime = true;
                Console.Write("Bİr sayı giriniz: ");
                int number = int.Parse(Console.ReadLine());

                if (number <= 1)
                {
                    IsPrime = false;
                }
                else
                {

                    for (int i = 2; i <= number - 1; i++)
                    {
                        if (number % i == 0)
                        {
                            IsPrime = false;
                            break;
                        }
                    }
                }

                Console.WriteLine(IsPrime == true ? "Asal" : "Asal değil");
                System.Console.WriteLine();
                Console.Write("Tekrar etmek ister misiniz? (E/A)");
                answer = Console.ReadLine();

            } while (answer != "H");*/


     /*    bool IsPrime = true;
        Console.Write("Bİr sayı giriniz: ");
        int number = int.Parse(Console.ReadLine());

        if (number <= 1)
        {
            IsPrime = false;
        }
        else
        {
            int i =2;

            while (i <= number - 1)
            {
                if (number % i == 0)
                {
                    IsPrime = false;
                    i++;
                    break;
                   
                }
            }

            
        }

        Console.WriteLine(IsPrime == true ? "Asal" : "Asal değil");
        //  Console.WriteLine(IsPrime ? "Asal" : "Asal değil");*/

        #endregion
    }

}

    


















        /* System.Console.WriteLine("Bir sayı giriniz: ");
        int number = int.Parse(Console.ReadLine());
        string result="";
      
        while (number%2 ==0)
        {
           result = "asal değil ";
         
        
          
        }
 */


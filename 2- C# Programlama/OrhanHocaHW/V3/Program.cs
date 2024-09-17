using System.Xml.XPath;

namespace V3;

class Program
{
    static void Main(string[] args)
    {

        

        while (true)
        {

            Console.WriteLine("Bir sayı giriniz :");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hangi matematik işlemini yapmak istiyorsunuz :");
            string islem = Console.ReadLine();
           
            Console.WriteLine("Bir sayı giriniz :");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int result = 0;

            switch (islem)
            {       case "+":
                      result = sayi1+ sayi2; 
                        break;
                    case "-":
                        result = sayi1 - sayi2;
                        break;
                    case "*":
                        result = sayi1 * sayi2;
                        break;
                    case "/":
                    if (sayi2==0)
                    {
                        System.Console.WriteLine("Bir sayıyı sıfıra bölemezsiniz!");
                    }
                    else
                    {
                        result = sayi1 / sayi2;
                        
                    }
                    break;

                default:
                       System.Console.WriteLine("Geçersiz veri girdiniz!");
                       break;
            }

System.Console.WriteLine();
            System.Console.WriteLine($"Sonuç: {result}");

            if (islem == "e")
            {
                break;
            }
           
            
          
        }

        

    }
}

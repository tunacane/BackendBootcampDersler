using System.Net.WebSockets;

namespace Project17_MethodOverloadinf;

class Program
{


   // static int Sum(int a, int b)
    // {
    //     return a + b;

    // }

    // static int Sum(int a, int b, int c)
    // {
    //     return a + b + c;

    // }

    // static int Sum(int a, int b, int c, int d)
    // {
    //     return a + b + c+ d;

    // }

    // static void Greet(string name, byte age){
    //     System.Console.WriteLine($"Merhaba {age} yaşındaki {name}");
    // }

   /*  static string(overload olmasını etkilemez) Greet(string name, byte age)
    {
        System.Console.WriteLine($"Merhaba {age} yaşındaki {name}");
    } */


    static string GetCoffee(string coffeType, int quantitySugar=0, bool withMilk=true){// varsayılan değer atanakca ondan sonrakilerde de değer ataması olacak int a, inta =2, int c=5, int d; olmaz
        string coffee = $"{coffeType} kahve";
        coffee += quantitySugar >0 ? $", {quantitySugar} şekerli" : ", şekersiz";


        coffee += $"{quantitySugar} şekerli";

        if (withMilk)
        {
            coffee+= ", sütlü";
        }
        else
        {
            coffee += ", sade";
        }

        coffee+="\nKahveniz hazır, afiyet olsun";
        return coffee;

    }



    static void Main(string[] args)
    {
        // System.Console.WriteLine(Sum(18,5,5,8));
        // System.Console.WriteLine(Sum(18, 5, 5));
        // System.Console.WriteLine(Sum(18, 5));
        // Greet("engin", 49);
        System.Console.WriteLine(GetCoffee("Americano"));
        System.Console.WriteLine(GetCoffee("Americano", 2));
        System.Console.WriteLine(GetCoffee("Americano", 5, true));

      
    }
}

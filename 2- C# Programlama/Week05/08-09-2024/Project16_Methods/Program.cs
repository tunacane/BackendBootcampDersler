using System.ComponentModel.Design.Serialization;
using System.Security.Principal;

namespace Project16_Methods;

class Program
{


    /*

        <Erişim Belirleyici> <Geri Dönüş Veri Tipi> MetodAdı(paramete1_tipi, parametre1_adi, paramete1_tipi , parametre2_adi..)
        {

        Metot gövdesi
        İşlemler burada gerçekleşiyor
        return;  -----geri döndürülecek değer; sadece metot geriye bir değer döndürecekse kullanılır.
        }


    */


    static void Greet()
    {
        Console.WriteLine("Merhaba Drogba");
    }

    static string Greet2(string name, bool gender){
        if (gender){
            return $"Merhaba {name} hanım :) "; // return sonrasında yazılan satırlar çalıştırılmaz
        }
          return $"Merhaba {name} bey :) ";
        



    }

  /*  static void Sum1(){                       
          int a =40;
         int b= 50;
         int c = a+b;
         System.Console.WriteLine(c); 
    }*/

    static int Sum1()
    {
        int a =40;
        int b= 50;
        int c = a+b;
        return c;

    }

    static int Sum2(int number1, int number2){
        int result = number1 + number2;
        return result;
    }


    static double SumSqrt(double number1, double number2){
        double total = number1 + number2;
        double result = Math.Sqrt(total);
        return result;

    }

static void SampleNumberValue(ref int originalNumber){ //burda ref kullanılırsa blok dışında kullanıldığında buradan referans alır ve burayı kullanabilir
    originalNumber+=3;
    System.Console.WriteLine($"MEtodun içindeki yazdırma satırı: {originalNumber}");
}

    static void Bolme(int bolunen, int bolen, out int bolum, out int kalan){
         bolum = bolunen / bolen;
         kalan = bolunen%bolen;
      
    }

    static void Main(string[] args)
    {

        int bolum; // buradaki bölüm ile metotda açıklana bölüm aynı değişken değil
        int kalan;
        Bolme(8, 2, out bolum, out kalan);
        System.Console.WriteLine($"8/3= {bolum}\n8/3 işleminden kalan= {kalan}");


       





















    // Greet();
    //    int x = Sum1();
    //    int y = Sum2(50, 70);
    //    int z = Sum2(90, 250);
    //    System.Console.WriteLine(x+y+z);

    // double result1 = SumSqrt(4,12);
    // double result2 = SumSqrt(5, 11);
    // double result3 = SumSqrt(5, 20);
    // double result4 = SumSqrt(7, 42);

    // System.Console.WriteLine(Greet2("Tuna", true));
    // System.Console.WriteLine(Greet2("Burhan", false));

    // int originalNumber = 15;
    // System.Console.WriteLine($"Metod çağrılmadan önceki originalNumber değeri: {originalNumber}");

    // SampleNumberValue(ref originalNumber);

    //     System.Console.WriteLine($"Metod çalıştıktan sonraki originalNumber değeri: {originalNumber}");

    




    }
}

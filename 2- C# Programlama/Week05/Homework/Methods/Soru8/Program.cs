namespace Soru8;
/*Santigrat cinsinden verilen sıcaklığı Fahrenheit'e çeviren bir metot yazın.  °C × 1.8 + 32*/

class Program
{

    static double Convert(double santigrat =30){

       //santigrat = 30;
        double fahrenheit = (santigrat *1.8)+32;
        return fahrenheit;


    }
    static void Main(string[] args)
    {
        double fahrenheit= Convert();
        System.Console.WriteLine($"30 Santigrat: {fahrenheit} F");
    }
}

namespace Soru2;
/* İki sayıyı karşılaştıran ve en büyüğünü döndüren bir metot yazın.*/


class Program
{
    static int MinMax(int sayi1, int sayi2){

        if (sayi1 > sayi2)
        {
            return sayi1;
        }
        else
        {
            return sayi2;
        }

    }
    static void Main(string[] args)
    {
        System.Console.WriteLine(MinMax(20, 10));
    }
}

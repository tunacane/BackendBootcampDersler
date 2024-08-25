namespace Project07_NumberMethods;

class Program
{
    static void Main(string[] args)
    {
    #region Aritmetik Operatörler
    int a = 10;
    int b = 4;

    int result;
    result = a+b;
    result = a-b;
    result = a*b;
    result = a/b;
    result = a%b;

    result = Math.Abs(-10);
    result = (int)Math.Pow(4,2);
    double result2;

    result2 = Math.Sqrt(16);
    result2 = Math.Round(7.51);
    result2 = Math.Ceiling(7,25); // her zaman yukarı yuvarlar
    result2 = Math.Floor(7.99); // her zaman tabana yuvarlar
    

    System.Console.WriteLine(result);
    System.Console.WriteLine(result2);
 
    #endregion
    }
}

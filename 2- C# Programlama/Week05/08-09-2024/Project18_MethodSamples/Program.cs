namespace Project18_MethodSamples;

class Program
{
    // kendisine gönderilen int tipindeki sayı listesinde yer alan negatif sayıları geridöndüren bir metot hazırlayalım.

    static List<int> GetNegativeNumbers(List<int> numbers){

        List<int> negativeNumbers = new List<int>(0);
        foreach (int number in numbers)
        {
            if(number < 0){
                negativeNumbers.Add(number);
            }
        }
        return negativeNumbers;


    }

// İki sayının karesini bulup toplayan metod
    static double TotalOfSquares(double a, double b){

        double aSquare = Math.Pow(a , 2 );
        double bSquare = Math.Pow(b, 2);

        return aSquare+ bSquare;

       //  return (a*a)+ (b*b);
    }







    static void Main(string[] args)
    {
        // List<int> numbers =[8,-5,-4,3,-12,7];
        // List<int> resultNumber= GetNegativeNumbers(numbers);

        // foreach (var number in resultNumber)
        // {
        //     System.Console.WriteLine(number);
        // }

        //TotalOfSquares(5,7); //

        System.Console.WriteLine(TotalOfSquares(3,4));

    
       
      
    }
}

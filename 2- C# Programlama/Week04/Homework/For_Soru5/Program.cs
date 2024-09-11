namespace For_Soru5;

class Program
{
    static void Main(string[] args)
    {
        
        for (int i = 2; i < 100; i++)
        {
            bool isPrime = true;
            for (int j = 2; j <= i-1; j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            System.Console.WriteLine($"{i} {(isPrime ? "asal" : "asal değil")}");
       
      
    }

    }

}


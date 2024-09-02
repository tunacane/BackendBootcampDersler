using System.Collections.Concurrent;

namespace Project10_ErrorHandling;

class Program
{
    static void Main(string[] args)
    {
         #region Try Catch Syntax

        

        // try
        // {
        // //     try{
                
        // //     }
        // // }
        // // catch (System.Exception)
        // // {
            
        // //     throw;
        // // }
            
         #endregion

        #region Try catch

        int number1= default;
        int number2= default;
        string result = default;

        try
        {

            System.Console.WriteLine("1.Sayı:");
            number1 = int.Parse(Console.ReadLine());

            System.Console.WriteLine("2.Sayı:");
            number2 = int.Parse(Console.ReadLine());

            result = (number1 / number2).ToString();

        
        }
        catch (FormatException)
        {
            result ="Lütfen geçerli bi değer giriniz" ;
        }
        catch (OverflowException){
            result = $"{int.MinValue} - {int.MaxValue} arasında bir değer giriniz";
        }
        catch (DivideByZeroException){
            result = $"0 girdiğiniz için default olarak 1'e bölündü.";
           
        }
        catch (Exception ex){
            result = ex.Message;
        }

        finally{
            System.Console.WriteLine(result);
        }
        
        System.Console.WriteLine("Program sona erdi...");


        #endregion


    }
}

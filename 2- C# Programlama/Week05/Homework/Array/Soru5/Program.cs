namespace Soru5;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Bir sayı giriniz: ");
        int number = int.Parse(Console.ReadLine());

        Random rnd = new Random();
        int[] dizi = new int[100];
        for (int i = 1; i < dizi.Length; i++)
        {

            dizi[i]= rnd.Next(1,112);
            System.Console.WriteLine(i+".eleman: " + dizi[i]+" ");
   
        }
        bool varMi = dizi.Contains(number);
        //System.Console.WriteLine(varMi);

        if (dizi.Contains(number))
        {
            int numberIndex = Array.IndexOf(dizi, number);
            System.Console.WriteLine(numberIndex);
        
        }
      
       // int[] result = Array.FindAll(dizi, n => n == number);
       

        int numberCount=0; 
     
       foreach (var sayi in dizi)
       {
        if (number == sayi)
        {
                numberCount++;
            }
       }
       System.Console.WriteLine("numberCount :" + numberCount);
    }
}

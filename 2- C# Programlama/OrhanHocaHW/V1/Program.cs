namespace V1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Kaç adet rakam toplanacağını belirtiniz: ");
        int numberCount = int.Parse(Console.ReadLine());
        int sum =0;

        for (int i = 0; i < numberCount; i++)
        {
            System.Console.WriteLine("Bir rakam giriniz: ");
            int number = int.Parse(Console.ReadLine());
            sum+= number;
        }
        int avarege = sum / numberCount;
        System.Console.WriteLine($"Sayıların toplamı : {sum} Ortalama: {avarege}");

        
        
        Console.Write("Hangi işlem yapılacağını belirtiniz: ");
        Console.Write("Kaç adet rakam toplanacağını belirtiniz: ");
        int numberCount1 = int.Parse(Console.ReadLine());

        string islem="";

        switch (islem)
        {
            case "+": 
                break;
            case "-":
                 break;
            case "/":
                break;
            case "*":
                break;



            default:
                System.Console.WriteLine("Geçerli bir veri giriniz!");
                break;

             
        }





    }
}

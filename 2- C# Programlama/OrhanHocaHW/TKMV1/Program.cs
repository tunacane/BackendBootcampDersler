namespace TKMV1;
// kazandınız yazdırılmıyor

class Program
{
    static void Main(string[] args)
    {
        string[] game = {"taş", "kağıt", "makas"};

        System.Console.WriteLine("Seçiminizi belirtiniz: ");
        string choice1 = Console.ReadLine().ToLower().Trim();
        System.Console.WriteLine("Diğer oyuncu seçimini belirtiniz: ");
        string choice2= Console.ReadLine().ToLower().Trim();


        if ((choice1 == "taş" && choice2 == "makas") || (choice1 == "makas" && choice2 == "kağıt" )|| (choice1 == "kağıt" && choice2 == "taş"))
        {
            Console.WriteLine("Kazandınız tebriklerrr");
        }
       
        else if (choice1 == choice2)
        {
            Console.WriteLine("Beraberlik!!");
        }
        else
        {
            System.Console.WriteLine("Kaybettiniz!!");
        }

    }
}

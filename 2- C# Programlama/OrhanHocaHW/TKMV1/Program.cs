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

        if (!game.Contains(choice1) || !game.Contains(choice2))
        {
            Console.WriteLine("Geçersiz seçim. Lütfen 'taş', 'kağıt' veya 'makas' yazın.");
            return;
        }


        if ((choice1 == "tas" && choice2 == "makas") || (choice1 == "makas" && choice2 == "kagit" )|| (choice1 == "kagit" && choice2 == "tas"))
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

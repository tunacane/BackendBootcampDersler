namespace Soru1;
/* Bir kişinin yaşını kontrol eden bir metot yazın. Eğer kişi 65 yaşından büyükse "Emeklilik yaşında", değilse "Çalışma yaşında" şeklinde bir mesaj döndürsün.*/


class Program
{
    static void RetireAge(int age){
        if (age > 65)
        {
            System.Console.WriteLine("Kişi emeklilik yaşında");
        }
        else {
            System.Console.WriteLine("Kişi çalışma yaşında");
        }
     

    }

    
    static void Main(string[] args)
    {
        System.Console.WriteLine("Yaşınızı giriniz: ");
        int age = int.Parse(Console.ReadLine());
        
        RetireAge(age);
        
}
}

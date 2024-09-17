namespace V2;

class Program
{
    static void Main(string[] args)
    {
        /* Console.WriteLine("Hangi matematik işlemini yapmak istersiniz?");
        Console.WriteLine("1 - Toplama");
        Console.WriteLine("2 - Çıkarma");
        Console.WriteLine("3 - Çarpma");
        Console.WriteLine("4 - Bölme");

        int islem = Convert.ToInt32(Console.ReadLine());


        Console.Write("Kaç adet Rakam Giriceksiniz : ");
        int sayilar = Convert.ToInt32(Console.ReadLine());

        int[] adet = new int[sayilar];
        int toplam = 0;

        for (int i = 0; i < sayilar; i++)
        {
            Console.WriteLine($"{i + 1} . Sayıyı Giriniz: ");
            adet[i] = Convert.ToInt32(Console.ReadLine());

        }
        int sonuc = adet[0];
        for (int i = 0; i < sayilar; i++)
        {
            switch (islem)
            {
                case 1:
                    sonuc += adet[i];
                    break;
                case 2:
                    sonuc -= adet[i];
                    break;

                case 3:
                    sonuc *= adet[i];
                    break;

                case 4:
                    sonuc /= adet[i];
                    break;


                default:
                    Console.WriteLine("Geçersiz İşlem");
                    break;
            }
        }

        Console.WriteLine($" Sayıların Toplamı: {toplam}"); */

        Console.WriteLine("Hangi matematik işlemini yapmak istiyorsunuz:");
        Console.WriteLine("1.Toplama:");
        Console.WriteLine("2.Çıkarma:");
        Console.WriteLine("3.Çarpma:");
        Console.WriteLine("4.Bölme:");

        int islem = int.Parse(Console.ReadLine());
        Console.WriteLine("Kaç adet sayı ile işlem yapmak istiyorsunuz: ");
        int numberCount= int.Parse(Console.ReadLine());

        int[] numbers= new int[numberCount];
        int output=0;
        for (int i = 0; i < numberCount; i++)
        {
          System.Console.WriteLine("Bir sayı giriniz: ");
            numbers[i] = int.Parse(Console.ReadLine());
           // numbers[numberCount]=numbers[i];
           
        }

        for (int i = 0; i < numberCount; i++)
        {
            if (islem == 1)
            {
                output += numbers[i];
            }
            else if (islem == 2)
            {
                output -= numbers[i];
            }
            else if (islem == 3)
            {
                output *= numbers[i];
            }
            else if (islem == 4)
            {
                output /= numbers[i];
            }

        }

        System.Console.WriteLine($"Sonuç: {output}");

    }
}

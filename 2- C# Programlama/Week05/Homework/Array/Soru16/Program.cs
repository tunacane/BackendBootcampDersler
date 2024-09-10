namespace Soru16;

class Program
{
    static void Main(string[] args)
    {
        
        
        int lastCount= int.MaxValue;
       
        int count=0;
        int[] dizi = new int[lastCount];

        do
        {
            System.Console.WriteLine("Bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            
            count++;

            if (sayi!=0)
            {
                dizi[count] = sayi;
                count++;
            }
            else
            {
                Console.WriteLine("Dizi doldu. Daha fazla sayı giremezsiniz.");
                break;
            }


        } while (true);


        for (int i = 0; i < dizi.Length; i++)
        {
            dizi[i] = i;
            System.Console.WriteLine(dizi[i]);
        }




    }
}



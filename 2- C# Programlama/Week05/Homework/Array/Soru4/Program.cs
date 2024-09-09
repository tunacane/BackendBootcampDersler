namespace Soru4;
//100 elemanlı rastgele değerlerden oluşan bir tam sayı dizisinde tekrar eden elemanları bulan bir program yazın. Diziyi tararken, elemanların hangi pozisyonlarda(kaçıncı indexte) tekrarlandığını ekrana yazdırın. Bu işlemi hem for hem de foreach döngüleri ile gerçekleştirin.
class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int[] numbers = new int[100];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rnd.Next(-200, 1000);
            System.Console.WriteLine(numbers[i]+" ");
            
        }

      


       




        }

            }


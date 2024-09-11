namespace Soru8;

class Program
{
    static void Main(string[] args)
    {

        System.Console.WriteLine("Bir sayı giriniz: ");
        int sayi = int.Parse(Console.ReadLine());

        Random rnd = new Random();
        int[] numbers = new int[10];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rnd.Next(1, 15);
            System.Console.Write(numbers[i] + " ");
        }

        System.Console.WriteLine();

        if (!numbers.Contains(sayi))
        {
            Array.Sort(numbers);

            foreach (var number in numbers)
            {
                System.Console.Write(number+" ");

            }
System.Console.WriteLine();
            

            int[] newNumbers = new int[numbers.Length + 1];
            Array.Copy(numbers, newNumbers, numbers.Length);
            newNumbers[newNumbers.Length-1] = sayi;

            Array.Sort(newNumbers);


            foreach (var item in newNumbers)
            {
                System.Console.Write(item + " ");
            }

        }

    }
}

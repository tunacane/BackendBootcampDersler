using System.ComponentModel;

namespace Project14_Arrays;

class Program
{
    static void Main(string[] args)
    {

        // int[] numbers;
        // numbers = new int[5];
        // numbers[0] = 45;
        // numbers[1] = 145;
        // numbers[2] = 245;
        // numbers[3] = 845;
        // numbers[4] = 345;

        // for (int i = 0; i < 5 ; i++)
        // {
        //     System.Console.WriteLine($"Dizinin {i+1}.Eleman: {numbers[i]}");
        // }

        // int[] numbers = {49 ,34, 87 ,25 ,13};
        // for (int i = 0; i < 5; i++)
        // {
        //     System.Console.WriteLine($"Dizinin {i + 1}.Eleman: {numbers[i]}");
        // }

        //     string[] studentNames = {
        //         "Ali",
        //         "Murat",
        //         "Tunacan",
        //         "Elif",
        //         "Sezej"
        // };

        //     for (int i = 0; i < studentNames.Length; i++)
        //     {
        //         System.Console.WriteLine(studentNames[i]);
        //     }

        //     for (int i = 0; i < studentNames.Length; i++)
        // {
        //     studentNames[i] += " Canoğlu";
        // }
        // System.Console.WriteLine();
        // System.Console.WriteLine("Dizinin değişmiş hali");
        // for (int i = 0; i < studentNames.Length; i++)
        // {
        //     System.Console.WriteLine(studentNames[i]);    
        // }


        //     string[] studentNames = {
        //         "Ali",
        //         "Murat",
        //         "Tunacan",
        //         "Elif",
        //         "Sezej"
        // };

        // foreach (string student in studentNames)
        // {
        //     System.Console.WriteLine(student);
        // }
        // //   HATALI YAZIM       
        //     foreach (string student in studentNames)
        //     {
        //         //student değişkeni iteration variable yani döngü değişkeni olduğundan read only özelliğe sahiptir. Yani değeri değiştirilemez.
        //         student+= "Canoğlu";
        //     }

        //????? int[] price = {40, 50, 60 ,70, 80};
        //price dizisinin içindeki fiyatlara %10 zam gelmiştir. Zamlı fiyatları içerecek şekilde price dizisini güncelleyecek kodu yazınız.

        // for (int p in prices)
        // {
        //     //System.Console.WriteLine(p);

        //     }


        // for (int i = 0; i < 5; i++)
        // {

        //     System.Console.WriteLine($"Eski fiyat: {price[i]} Zamlı fiyat: {price[i] + price[i] /10 }");
        // }


        //   ????b a=40, b=50, c=45
        //  int a=40;
        //  int b= 50;
        //  int c = 45;

        //  int max = int.MinValue;
        //  if (a > max)
        //  {
        //     max = a;
        //  }
        //  if (b> max)
        //  {
        //     max = b;
        //  }
        //  if (c> max)
        //  {
        //     max = c;
        //  }
        //  System.Console.WriteLine(max);

        // ???? 20 elemanlı bir int dizisine 1 ile 100 arasında rastgele değerler atayalım. Bu dizinin min va mex değerini yazdıralım.

        // Diziyi oluşturup içine rastgele değerler atuyoruz.

        // Random rnd = new Random();
        // int[] numbers = new int[10];

        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     numbers[i] = rnd.Next(1,101);
        //     System.Console.WriteLine(numbers[i]);
        // }

        // //min va max'ı buluyoruz.

        // int max = int.MinValue;
        // int min = int.MaxValue;

        // foreach (int number in numbers)
        // {
        //     if (number > max)  max= number;
        //     if (number < min)  min =number;    
        // }

        //     System.Console.WriteLine($"En küçük: {min}\nEn Büyük: {max}");

        // Random rnd = new Random();
        // int[] numbers = new int[10];

        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     numbers[i] = rnd.Next(1, 101);
        //     System.Console.WriteLine(numbers[i]);
        // }

        // Array.Sort(numbers);
        // System.Console.WriteLine("Dizinin küçükten büyüğe sıralı hali");

        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     System.Console.WriteLine(numbers[i]);
        // }

        // Array.Reverse(numbers);
        // System.Console.WriteLine("Dizinin büyükten küçüğe sıralı hali");

        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     System.Console.WriteLine(numbers[i]);
        // }

        // Random rnd = new Random();
        // int[] numbers = new int[10];

        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     numbers[i] = rnd.Next(1, 101);

        // }
        // numbers[5]=99;

        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     System.Console.WriteLine($"Index: {i} - Number: {numbers[i]}");
        // }
        // System.Console.WriteLine(Array.IndexOf(numbers, 99));

        // string firstName = "Alex de Souza";
        // System.Console.WriteLine(firstName[3]);

        // string text = "Macbook ile Yazılım Geliştirme Ortamının Hazırlanması";
        // string[] result = text.Split(" ");
        // System.Console.WriteLine(result[0]);

        // string text2 = "çok hava çok çok güzel";
        // string[] result2 = text2.Split("çok");
        // int wordCount = result2.Length-1;
        // System.Console.WriteLine(wordCount);

        // DİZİLERİ KOPYALAMAK

        // string[] names= {"Ayşen", "Umay", "Ceyda" ,"Begüm"};
        // string[ ]newNames= names;

        // names[0]="Heda";
        // System.Console.WriteLine(newNames);

        //     string[] names= {"Ayşen", "Umay", "Ceyda" ,"Begüm"};
        //     string[ ]newNames= new string[names.Length];
        //     Array.Copy(names, newNames, names.Length);
        //     foreach (var name in names)
        //     {
        //         System.Console.WriteLine(name);
        //     }

        //    foreach (var name in newNames)
        //    {
        //     System.Console.WriteLine(name);
        //    }


        //   DİZİDE VAR YOK KONTROLÜ YAPMAK

        //    int[] numbers = {3, 6, 7, 12};
        //    bool exists = Array.Exists(numbers, n =>n==6);
        //    System.Console.WriteLine(exists ? "Var" : "Yok");

        //  DİZİDE BELİRTİLEN KOŞULA UYGUN İLK ELEMANI GETİRMEK

        // int[] numbers = { 3, 6, 7, 12 };
        // int result = Array.Find(numbers, n=> n==6);
        // System.Console.WriteLine(result);

        //  DİZİDE BELİRTİLEN KOŞULA UYGUN İLK ELEMANI GETİRMEK

        // int[] numbers = { 3, 6, 7, 12, 6 };
        // int[] result = Array.FindAll(numbers, x => x == 6);
        
        // foreach (var n in result)
        // {
        //     System.Console.WriteLine(n);

        // }

        //DİZİNİN BOYUTUNU(ELEMAN SAYISINI) DEĞİŞTİRMEK
        // int[] numbers = {3, 6, 8};
        // System.Console.WriteLine(numbers.Length);
        // Array.Resize(ref numbers, 4);

        // numbers[3]=55;
        // System.Console.WriteLine(numbers.Length);
        
        // DİZİNİN BELİRLİ BİR BÖLÜMÜNÜ TEMİZLEMEK

        // int[] numbers = {4,5,6,12,47,36,98};
        // System.Console.WriteLine("Dizinin orijinal hali");
        // foreach (int number in numbers)
        // {
        //     System.Console.WriteLine(number);
        // }

        // Array.Clear(numbers);
        // System.Console.WriteLine();

        // System.Console.WriteLine("Dizinin temizlnenmiş hali");
        // foreach (int number in numbers)
        // {
        //     System.Console.WriteLine(number);
        // }

        // Array.Clear(numbers, 2, 2);
        // System.Console.WriteLine();

        // System.Console.WriteLine("Dizinin temizlnenmiş hali");
        // foreach (int number in numbers)
        // {
        //     System.Console.WriteLine(number);
        // }









    }
}
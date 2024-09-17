namespace Quiz;

class Program
{
    static void Main(string[] args)
    {
        string[] sorular = ["gökyüzü ne renktir?", "Türkiye'nin başkenti neresidir?"];
        //  string[] cevaplar = ["mavi", "ankara"];

       // string secenekler = ["kırmızı|Mavi|Pembe|Mor", "Ankara|İstanbul|İzmir"]

      for (int i = 0; i < sorular.Length; i++)
      {
        System.Console.WriteLine(sorular[i]);
      }

      System.Console.WriteLine("Lütfen cevabınızı giriniz: ");
      string answer1 = Console.ReadLine().ToLower();
      System.Console.WriteLine("Lütfen cevabınızı giriniz: ");
      string answer2 = Console.ReadLine().ToLower();

        if (answer1 =="mavi" && answer2== "ankara")
      {
        System.Console.WriteLine("İki sorunun cevabı da doğru");
      }
      else if ((answer1 == "mavi" && answer2 != "ankara") || answer1 != "mavi" && answer2 == "ankara")
      {
        System.Console.WriteLine("1 doğru 1 yanlış cevap");
      }

      else
      {
        System.Console.WriteLine("İki yanlış cevap");
      }

        
    }
}

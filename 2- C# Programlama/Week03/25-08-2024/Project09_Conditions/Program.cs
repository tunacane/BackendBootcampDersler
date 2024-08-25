namespace Project09_Conditions;

class Program
{
    static void Main(string[] args)
    {

        #region if
        // if(5>14){
        //     System.Console.WriteLine("işlem tamamlandı");
        // }
        // else{
        //     System.Console.WriteLine("Hata !!");
        // }

        // int x = 10;
        // if (x>15){
        //     System.Console.WriteLine("büyüktür");
        // }
        // else if (x<15){
        //     System.Console.WriteLine("küçüktür");
        // }
        // else{
        //     System.Console.WriteLine("eşittir");
        // }
        #endregion

        #region ternary if
        //l-kullanıcının klavyeden gireceği yaş bilgisini alıp reşit değilse "reşit değilsiniz, X sene sonra reşit olacaksınız" eğer reşit ise "giriş yapabilirsiniz" yazdıran kodu hazırlayınız.


        // string resultMessage;
        // System.Console.Write("Yaşınızı giriniz: ");

        // byte age = byte.Parse(Console.ReadLine());
        // string fullName = Console.ReadLine();


        // if (age >= 18){
        //     resultMessage = "giriş yapabilirsiniz";
        // }

        // else {

        // resultMessage = $"reşit değilsiniz. { 18 - age}  sene sonra reşit olacaksınız.";
        // }

        // System.Console.WriteLine($"Sevgili {fullName}, {resultMessage}");

        // System.Console.WriteLine("Adınızı giriniz: ");
        // string fullName = Console.ReadLine();

        // System.Console.WriteLine("Yaşınızı giriniz: ");
        // byte age = byte.Parse(Console.ReadLine());

        // string resultMessage = age>=18 ? $"Giriş yapabilirsin {fullName}" : $"{18 - age} yıl sonra reşit olacaksın, o zaman gel {fullName}";

        // System.Console.WriteLine(resultMessage);

      //  System.Console.WriteLine("Notunu giriniz(0-100): ");
      //  byte point = byte.Parse(Console.ReadLine());
       // string resultMessage;

        //     if (point>=50){
        //         resultMessage = "Geçtiniz";
        //     }
        //    else
        //    {
        //     resultMessage = "Kaldınız";
        //    }
        //    System.Console.WriteLine(resultMessage);

      //  resultMessage = point >= 50 ? "Geçtiniz" : "Kaldınız";

        //System.Console.WriteLine(resultMessage);
        #endregion

        #region Switch

        /* int point = 120;
        byte resultPoint = 0;

        switch(point){
            case <45:
                resultPoint = 1;
                 break;
            case <55:
                resultPoint = 2;
                break;
            case <70:
                resultPoint = 3;
                break;    
            case <85:
                resultPoint = 4;
                break;
            case <=100:
                resultPoint = 5;
                break;   

            default: 
                System.Console.WriteLine("Lütfen 0-100 arası bir puan giriniz!");
                break;     

        }

        if (point > 0 && point < 100)
        {
            System.Console.WriteLine(resultPoint);
        }
      //  ödev:  bu çalışmanın aynısını if ile yapınız. */
            
            // GİRİLEN TARİHİN HAFTAİÇİ Mİ HAFTA SONU MU OLDUĞUNU SÖYLEYEN KODU YAZINIZ

       /*      System.Console.WriteLine("Bir tarih giriniz(gg.aa.yyyy): ");
            string inputDate = Console.ReadLine();

            if (DateTime.TryParse(inputDate, out DateTime date))
            {
                DayOfWeek dayOfWeek = date.DayOfWeek; // dayOfWeek.Sunday
                System.Console.WriteLine(date.ToLongDateString());

                switch(dayOfWeek){
                    case DayOfWeek.Sunday:
                    case DayOfWeek.Saturday:
                    System.Console.WriteLine("İyi tatiller");
                    break;
                }
               
            }
            else
            {
                System.Console.WriteLine("Hatalı tarih gitdiniz");
            } */


        #endregion

    }
    }
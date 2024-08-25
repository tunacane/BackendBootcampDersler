using Microsoft.VisualBasic;

namespace Project05_VariableSamples;

class Program
{
    static void Main(string[] args)
    {
        #region Yaş hesaplama

        //kullanıcıdan doğum yılını  alıp yaşını hesaplayacak ve bunu ekrana yazdırak kodu hazırlıyoruz.

      /*   System.Console.WriteLine("Doğum yılınızı giriniz");

        string input = Console.ReadLine(); // "1975"

        int birthYear = int.Parse(input); // 1975
        int calculatedAge= DateTime.Now.Year - birthYear;
        string message = "Yaşınız : " + calculatedAge;
        System.Console.WriteLine(message);


 */

        #endregion

        #region Ürün Fiyatı Hesaplama
    // Bir ürünün fiyatı girildiğindei, onun KDV dahil fiyarını hesaplayıp hem ham hem KDV dahil fiyatını ekrana yazdıracağız.
/* 
    System.Console.Write("Ürün fiyatını giriniz: ");

    decimal productPrice = decimal.Parse(Console.ReadLine());
    double vatRate = 0.18;
    double vat = (double)productPrice * vatRate;
    double totalProductPrice = (double)productPrice + vat; */

        /* string resultMessage = $@"

        Ürün Fiyatı     : {productPrice}
        KDV             : {vat}
        KDV Dahil Fİyat : {totalProductPrice}
        "; */

        //string resultMessage = $"Ürün Fİyatı : {productPrice}\nKDV : {vat}\nKDV Dahil Fİyat : {totalProductPrice}";

    //System.Console.WriteLine(resultMessage);



            
        #endregion

        #region Sıcaklık Değiştirme
        //kullanıcıdan Calcius cinsinden alınan sıcaklık değerini Fahrenheit cinsine çevirip ekrana her ikisini alt alta yazdıran kodu hazırlıyoruz.

      /*   System.Console.Write("Celcius sıcaklık değerini giriniz :");

        double currentHeat = double.Parse(Console.ReadLine());

        double fahrenheitType = (currentHeat*1.8)+32;
        string resultMessage= $"Celcius: {Convert.ToInt32(currentHeat)}\nFahrenheitType: {Convert.ToInt32(fahrenheitType)}";

       // Console.Clear();
        System.Console.WriteLine();
        System.Console.WriteLine("sonuç : ");
        System.Console.WriteLine("--------");
        System.Console.WriteLine(resultMessage);
        
 */
            
        #endregion
    
        #region Ağırlık dönüştürme

        //kullanıcının girdiği kg cinsi ağırlığı gram'a çevirip sonucu ekrana yazdırınız. Küsüratlı değerler girilebilir. Sonuç ekranında hem kg hem gr yazılsın.

        System.Console.WriteLine("Kilonuz :");

        double currentWeight = double.Parse(Console.ReadLine());

        double gram = currentWeight *1000;

        string resultMessagemessage = $"Şuanki kilonuz: {currentWeight}\nGram cinsinden: {(int)gram}";

        System.Console.WriteLine("Sonuç: ");
        System.Console.WriteLine("-------");
        System.Console.WriteLine(resultMessagemessage);
        
    #endregion
    
    
    
    
    
    }
}

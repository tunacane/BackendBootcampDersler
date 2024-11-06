using System;
using System.Xml.Schema;

namespace Project23_InheritanceSamples.SchoolSystem;
/* öğretmen bir kişidir
    öğretmeninin ek oalrak bran ş ve maaş bilgisi olacak
    maas bilgsinin negatif değer olarak girilmesine izin verilmeyecek(sadece hata mesajı verilse yeter)
    ogretmenin bilgileri ekrana yazdırılırken branş ve maaş bilgisi de yazdırılacak*/



public class Ogretmen : Kisi
{
    public Ogretmen(string name, string soyad, DateTime dogumTarihi, string brans, int maas) : base(name, soyad, dogumTarihi)
    {
        Brans = brans;
        Maas = maas;
    }

    decimal maas; //propfull ile yazılan private decimal maas ile aynı
    public string Brans { get; set; }
    public decimal Maas { 
        
        get{
            return maas;
        } 
        
        set{

            if (value < 0 )
            {
              throw new ArgumentException("Hatalı maaş!!");
              
            }
            maas = value;
        }
        
        
        }

    public override void BilgileriEkranaYaz()
    {
        base.BilgileriEkranaYaz();
        System.Console.WriteLine($"Öğretmenin branşı: {Brans}\nÖğretmen maaş: {Maas:C0}");
    }
}

using System;

namespace Project23_InheritanceSamples.SchoolSystem;
/* öğrenci bir kişidir.
   öğrencinin ek olarak öğrenci numarası özelliği vardır
   öğrencinin bilgileri ekrana yazdırılırken öğrenci numarası da yazdırılmalıdır.*/

public class Ogrenci : Kisi
{
    public Ogrenci(string name, string soyad, DateTime dogumTarihi, int ogrenciNo) : base(name, soyad, dogumTarihi)
    {
        OgrenciNo = ogrenciNo;

    }
    public int OgrenciNo { get; set; }

    public override void BilgileriEkranaYaz()
    {
        base.BilgileriEkranaYaz(); // bunun yerine aşağıdakini de yazılabilir
       // System.Console.WriteLine($"Ad: {Name}\nSoyad: {Soyad}\nDoğum tarihi: {DogumTarihi.ToShortDateString()}");

        System.Console.WriteLine($"Öğrenci No: {OgrenciNo} ");

    }
  

}

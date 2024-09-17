using System;

namespace Project23_InheritanceSamples.SchoolSystem;

public class Kisi
{
    public Kisi(string name, string soyad, DateTime dogumTarihi)
    {
        Name = name;
        Soyad = soyad;
        DogumTarihi = dogumTarihi;
    }

    public string Name { get; set; }
    public string Soyad { get; set; }

    public DateTime DogumTarihi { get; set; }

    public byte Yas{ // salt okunur read only, get yazılır set yazılmaz
        get{
            return (byte)(DateTime.Now.Year - DogumTarihi.Year);
        }
        
    }

    public virtual void BilgileriEkranaYaz(){
        System.Console.WriteLine($"Ad: {Name}\nSoyad: {Soyad}\nDoğum tarihi: {DogumTarihi.ToShortDateString()}");

        System.Console.WriteLine($"Kişinin yaşı: {Yas}");
    }



}

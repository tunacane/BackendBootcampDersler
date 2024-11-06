

using Project23_InheritanceSamples.CarManagementSystem;
using Project23_InheritanceSamples.SchoolSystem;


namespace Project23_InheritanceSamples;


class Program
{
    static void Main(string[] args)
    {
    //    Cat cat1 = new Cat("Heda", 5, "siyah");
    //    cat1.MakeSound();

    //    Dog dog1 = new Dog("Tobi", 5, 5,"3");      
    //    dog1.MakeSound();
    //    dog1.Swimm();


    // Kisi kisi1= new Kisi("Tunacan", "Eşki", new DateTime(1992,11,13));
    // kisi1.BilgileriEkranaYaz();

    // Ogrenci ogrenci1 = new Ogrenci("Ali", "Aka", new DateTime(1950,12,12), 50);
    // ogrenci1.BilgileriEkranaYaz();

   //

     Car car1=new("Toyota", "Corolla", 2013 , 4);
    
     car1.VehicleDefine();
     car1.Start();
     car1.Stop();
     car1.OpenTrunk();
     car1.CloseTrunk();


     System.Console.WriteLine();

     MotorCycle motorCycle1= new MotorCycle("Honda", "CBR", 2010, "Su soğutmalı");
     motorCycle1.VehicleDefine();
     motorCycle1.Start();

   // Vehicle vehicle= new Vehicle(); abstract olduğu için yazılamaz
   

    








       
    }
}


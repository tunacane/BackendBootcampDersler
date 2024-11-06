namespace VehicleManagementSystem;

class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car("Toyota", "Corolla", 5, 4);
        car1.DefineVehicle();

        Bicycle bicycle1= new Bicycle("Bianchi", "aa", 4);

        Motorcycle motorcycle1 = new Motorcycle("Honda", "CBR", 5, false);
        motorcycle1.DefineVehicle();
        
        


    }
}

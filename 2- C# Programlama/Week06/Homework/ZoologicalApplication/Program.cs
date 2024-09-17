namespace ZoologicalApplication;

class Program
{
    static void Main(string[] args)
    {
       Elephant elephant1 = new Elephant("Filoş", 5, "Asya Fili");
       elephant1.DefineAnimal();
       elephant1.MakeSound();

       System.Console.WriteLine();

       Giraffe giraffe1= new Giraffe("Züroş", 3, "reticulata");
       giraffe1.MakeSound();
       giraffe1.DefineAnimal();

        System.Console.WriteLine();

        Lion lion1= new Lion("Leo", 2, "Dişi");
        lion1.DefineAnimal();
       lion1.MakeSound();
    }
}

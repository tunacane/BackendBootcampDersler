namespace EmployeeManagementSystem;

class Program
{
    static void Main(string[] args)
    {
        Developer developer1=new Developer("Tunacan", 46211, 58600, "C#, Java");
        developer1.DefineEmployee();

        System.Console.WriteLine("***********************************");

        Intern intern1= new Intern("Bedia", 78, 0);
        intern1.DefineEmployee();

        System.Console.WriteLine("***********************************");

        Manager manager1 = new Manager("Feyyaz", 96, 250000, 8);
        manager1.DefineEmployee();


    }
}

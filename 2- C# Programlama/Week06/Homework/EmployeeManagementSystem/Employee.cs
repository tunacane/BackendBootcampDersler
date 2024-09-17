using System;

namespace EmployeeManagementSystem;

public class Employee
{
    public Employee(string name, int id, double salary)
    {
        Name = name;
        Id = id;
        Salary = salary;
    }

    public string Name { get; set; }
    public int Id { get; set; }
    public double Salary { get; set; }

    public virtual void DefineEmployee(){
        System.Console.WriteLine($"Name: {Name}\nID: {Id}\nSalary: {Salary}");
    }

}

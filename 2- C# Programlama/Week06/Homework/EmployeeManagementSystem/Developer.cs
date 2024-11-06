using System;

namespace EmployeeManagementSystem;

public class Developer : Employee
{
    public Developer(string name, int ıD, double salary, string programmingLanguage) : base(name, ıD, salary)
    {
        ProgrammingLanguage = programmingLanguage;
    }

    public string ProgrammingLanguage { get; set; }

    public override void DefineEmployee()
    {
        base.DefineEmployee();
        System.Console.WriteLine($"Developer Program Language is: {ProgrammingLanguage}");
    }
}

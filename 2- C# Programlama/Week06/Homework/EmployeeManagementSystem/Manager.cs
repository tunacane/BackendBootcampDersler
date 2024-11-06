using System;

namespace EmployeeManagementSystem;

public class Manager : Employee
{
    public Manager(string name, int ıD, double salary, int numberOfTeams) : base(name, ıD, salary)
    {
        NumberOfTeams = numberOfTeams;
    }

    public int NumberOfTeams { get; set; }

    public override void DefineEmployee()
    {
        base.DefineEmployee();
        System.Console.WriteLine($"Number of Teams: {NumberOfTeams}");
    }
}

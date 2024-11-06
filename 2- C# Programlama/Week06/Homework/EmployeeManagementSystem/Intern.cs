using System;

namespace EmployeeManagementSystem;

public class Intern : Employee
{
    public Intern(string name, int ıD, double salary) : base(name, ıD, salary)
    {
    }

    public override void DefineEmployee()
    {
        base.DefineEmployee();
    }
}

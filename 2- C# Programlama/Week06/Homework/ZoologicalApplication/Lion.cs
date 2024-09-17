using System;

namespace ZoologicalApplication;

public class Lion : Animal
{
    public Lion(string name, int age, string breed) : base(name, age, breed)
    {
    }

    public override void MakeSound()
    {
        base.MakeSound();
        System.Console.WriteLine($"{Name} kükredi.");
    }
}


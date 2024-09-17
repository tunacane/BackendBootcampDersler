using System;

namespace ZoologicalApplication;

public class Giraffe : Animal
{
    public Giraffe(string name, int age, string breed) : base(name, age, breed)
    {
    }

    public override void MakeSound()
    {
        base.MakeSound();
        System.Console.WriteLine($"{Name} bağırdı.");
    }


}



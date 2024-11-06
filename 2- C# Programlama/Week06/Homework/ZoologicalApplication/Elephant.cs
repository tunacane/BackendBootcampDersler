using System;

namespace ZoologicalApplication;

public class Elephant : Animal
{
    public Elephant(string name, int age, string breed) : base(name, age, breed)
    {
    }

    public override void MakeSound()
    {
        base.MakeSound();
        System.Console.WriteLine($"{Name} uludu.");
    }
}

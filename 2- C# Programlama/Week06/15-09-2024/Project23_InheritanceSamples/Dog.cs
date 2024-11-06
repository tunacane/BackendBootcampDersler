using System;

namespace Project23_InheritanceSamples;

public class Dog : Animal
{
    public Dog(string name, int age, int OlfactionLevel, string breed ): base(name, age)
    {

        OlfactionLevel = OlfactionLevel;
        Breed = breed;
    }
    public int OlfactionLevel { get; set; }
    public string Breed { get; set; }

    public override void MakeSound()
    {
        System.Console.WriteLine($"{Name} havladı");
    }

    public void Swimm(){
        System.Console.WriteLine($"{Name} yüzdü.");
    }
}

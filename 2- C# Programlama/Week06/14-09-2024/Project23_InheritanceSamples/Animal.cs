using System;

namespace Project23_InheritanceSamples;

public class Animal
{
    public Animal(string name, int age)
    {
        Name = name;
        this.age = age;
    }

    public string Name { get; set; }
    public int age { get; set; }

    public void MakeSound(){
        System.Console.WriteLine($"{Name} sesi çıkardı.");
    }



}

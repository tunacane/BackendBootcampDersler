using System;

namespace ZoologicalApplication;

public class Animal
{
   
public Animal(string name, int age, string breed)
    {
        Name = name;
        Age = age;
        Breed = breed;
    }

    public string Name { get; set; }
    public int Age { get; set; }
    public string Breed { get; set; }

    public virtual void MakeSound(){

        System.Console.WriteLine($"{Name} ses çıkarıyor.");

    }
    }

    


using System;

namespace BlogApp.Models;

public class Categories
{
    public Categories(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public string Name { get; set; }    
public string Description { get; set; }
}

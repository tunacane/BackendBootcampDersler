using System;

namespace BlogApp.Models;

public class Resume
{
    public Resume(string name, string surname, string email, List<string> experience)
    {
        Name = name;
        Surname = surname;
        Email = email;
        Experience = experience;
    }

    public string Name { get; set; }    
public string Surname { get; set; }
public string Email { get; set; }   
public List<string> Experience { get; set; }

}

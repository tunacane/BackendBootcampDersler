using System;

namespace BlogApp.Models;

public class Blog
{
    public Blog(string title, string description, string ımage, string author)
    {
        Title = title;
        Description = description;
        Image = ımage;
        Author = author;
    }

    public string Title { get; set; }
public string Description { get; set; } 
public string Image { get; set; }
public string Author { get; set; }


}

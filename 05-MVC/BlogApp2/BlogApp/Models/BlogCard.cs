using System;

namespace BlogApp.Models;

public class BlogCard
{
    public BlogCard(string title, string ımageUrl, string description)
    {
        Title = title;
        ImageUrl = ımageUrl;
        Description = description;
    }

    public string Title { get; set; }
public string ImageUrl { get; set; }   
public string Description { get; set; }
}

using System;

namespace LibraryApplicationl;

public class Book
{
    public Book(string author, int pages, long ıSBN)
    {
        Author = author;
        Pages = pages;
        ISBN = ıSBN;
    }

    public string Author { get; set; }
    public int Pages { get; set; }
    public long ISBN { get; set; }

    public void DefineBook(){
        System.Console.WriteLine($"Book's Author: {Author}\n Pages: {Pages}\n ISBN No:{ISBN}");
    }

    public void Borrow()
    {

    }

    public void Return()
    {

    }





}

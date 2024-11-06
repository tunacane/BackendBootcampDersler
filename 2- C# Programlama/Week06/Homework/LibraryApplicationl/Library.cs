using System;
using System.Diagnostics.Contracts;

namespace LibraryApplicationl;

public class Library : Book
{

    public Book[] books;
    int count;

    public Library(int capacity)
    {
        books = new Book[capacity];
        count =0;
    }

    //string[] book = new string[5];


}

 

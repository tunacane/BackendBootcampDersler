﻿using Project24_Interface.Interfaces;

namespace Project24_Interface;

class Program
{
    static void Main(string[] args)
    {
        //  IRepo repo= new IRepo();
     IRepo repo = new Project24_Interface.Interfaces.ProductRepo();
    }
}

﻿namespace Soru9;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { -2, 4, 5, -6, 8, 7, -9, 10, -11, 15, -48, 75, 42 };
        int positiveCount=0;
        int[] positive = new int[positiveCount];


        for (int i = 0; i < numbers.Length; i++)
        {
            System.Console.Write(numbers[i] + " ");

            if (numbers[i] >0)
            {
                positiveCount++;
            }
           
        }
        Array.Reverse(numbers, positiveCount);










    }
}
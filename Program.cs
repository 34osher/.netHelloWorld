﻿namespace _netHelloWorld;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("your name is ori bolbol");
        //var name = Console.ReadLine();
        var currentDate = DateTime.Now;
        Console.WriteLine($"{Environment.NewLine}Hello, ori, on {currentDate:d} at {currentDate:t}!");
        //Console.Write($"{Environment.NewLine}Press any key to exit...");
        //Console.ReadKey(true);
    }
}

﻿using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your first name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter your last name: ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your full name is: {firstName} {lastName}");
    }
}
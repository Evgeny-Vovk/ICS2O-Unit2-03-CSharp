// Created by: Evgeny
// Created on: Mar 2022
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        //input
        string streetName;
        int streetNumber;

        Console.WriteLine("This program finds the area and perimeter of a rectangle");
        Console.WriteLine("");

        Console.Write("Enter your street number: ");
        streetNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your street name: ");
        streetName = Console.ReadLine();

      //output
        Console.WriteLine("");
        Console.WriteLine("Your street address is: " + streetNumber + " " + streetName + ".");

        Console.WriteLine("\nDone.");
  }
}
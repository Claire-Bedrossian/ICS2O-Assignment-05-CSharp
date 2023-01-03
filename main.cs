// Created by: Claire Bedrossian
// Created on: Nov 2022
//
// This program is a game to guess a random number the computer has generated.
using System;
class Program
{
    public static void Main(string[] args)
    {
        System.Random random = new System.Random();
        // This function calculates y = mx + b
        double valX;
        double valM;
        double valB;
        double counter;
        double product;
        Console.WriteLine(" This program makes a table of x and y values when given the equation of a straight line ( y = mx + b )");
        Console.WriteLine("");
        Console.Write("Enter value m: ");
        valM = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter value x: ");
        valX = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter value b: ");
        valB = Convert.ToDouble(Console.ReadLine());
        counter = 0;
        product = valB; 
        Console.WriteLine("");
        while (counter < Math.Abs(valX)) {
         counter++;
         product = product + Math.Abs(valM);
         Console.WriteLine("The X value is " + counter + ".  The Y value is " + product +".");
        }
        Console.WriteLine("");
        Console.WriteLine("\nDone.");
    }
}
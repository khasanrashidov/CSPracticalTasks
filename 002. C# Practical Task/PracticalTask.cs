// Practical Task
// Create a program that takes an integer in decimal, 
// and a new base number system (from 2 to 20) from the command line. 
// Print the original number converted to this system to the console.

using System;

namespace PracticalTask
{
    /// <summary>
    /// The PracticalTask class provides a main method that converts a number from decimal to another base number system.
    /// </summary>
    internal class PracticalTask
    {
        /// <summary>
        /// The Main method takes a number in decimal and a new base number system as input and prints the original number converted to this system.
        /// </summary>
        /// <param name="args">The number in decimal and the new base number system.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Practical Task");
            Console.WriteLine("Enter a number in decimal: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a new base number system (from 2 to 20): ");
            int newBase = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The original number converted to this system: ");
            Console.WriteLine(Convert.ToString(number, newBase));

            // To convert a number from one base to another, use the Convert.ToString method.
            // The first parameter is the number to convert, 
            // the second is the base to which it will be converted.
            // The result is a string, so you can use it as you like.~s
        }

    }
}
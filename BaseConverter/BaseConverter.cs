// Practical Task
// Create a program that takes an integer in decimal, 
// and a new base number system (from 2 to 20) from the command line. 
// Print the original number converted to this system to the console.

using System;

namespace BaseConverter
{
    /// <summary>
    /// The BaseConverter class takes an integer in decimal,
    /// and a new base number system (from 2 to 20) from the command line.
    /// </summary>
    public class BaseConverter
    {
        public static void Main(string[] args)
        {
            TryAgain:
            Console.Write("Enter a number in decimal: ");
            bool isNumber = int.TryParse(Console.ReadLine(), out int number);
            if (!isNumber)
            {
                Console.WriteLine("You entered an invalid number.");
                goto TryAgain;
            }

            TryAgain2:
            Console.Write("Enter a new base number system (from 2 to 20): ");
            bool isBase = int.TryParse(Console.ReadLine(), out int newBase);
            if (!isBase || newBase < 2 || newBase > 20)
            {
                Console.WriteLine("You entered an invalid base.");
                goto TryAgain2;
            }

            Console.WriteLine($"{number} in base {newBase} is {Convert.ToString(number, newBase)}");

            // To convert a number from one base to another, we use the Convert.ToString method.
            // The first parameter is the number to convert, 
            // the second is the base to which it will be converted.
            // The result is a string, so we can use it as we like.
        }
    }
}
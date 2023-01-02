using System;
using System.Runtime.InteropServices;

namespace PracticalTask
{
    internal class PracticalTask
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Practical Task");
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();
            Console.WriteLine("The string you entered is: " + input);

            // Initialize variables to store the maximum number of unequal consecutive characters and the current count.
            int maxCount = 0, currentCount = 1;

            // Iterate through each character in the input string.
            for (int i = 1; i < input.Length; i++)
            {
                // If the current character is equal to the next character, increment the current count.
                if (input[i] != input[i - 1])
                {
                    currentCount++;
                }
                // If the current character is not equal to the next character, reset the current count.
                else
                {
                    currentCount = 1;
                }
                // If the current count is greater than the maximum count, set the maximum count to the current count.
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                }
            }

            // Print the maximum count.
            Console.WriteLine("The maximum number of unequal consecutive characters is: " + maxCount);

        }

    }
}
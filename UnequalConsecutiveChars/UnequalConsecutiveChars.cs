// Practical Task
// Create a program that takes a sequence of symbols (string) as arguments from the command line 
// and prints the maximum number of unequal consecutive characters per line to the console.
// Example: if input is "1234156" then result should be 4

using System;

namespace UnequalConsecutiveChars
{
    /// <summary>
    /// The UnequalConsecutiveChars class provides a main method 
    /// that takes a string and prints the maximum number of unequal consecutive characters in it.
    /// </summary>
    public class UnequalConsecutiveChars
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string? input = Console.ReadLine();
            int count = 1; // count of unequal consecutive characters
            int index = 0; // index of storeResult array
            string temp = string.Empty;

            if (input != null)
            {
                // storeResult array stores the count of unequal consecutive characters
                int[] storeResult = new int[input.Length];

                for (int i = 0; i < input.Length - 1; i++)
                {
                    for (int j = i + 1; j < input.Length; j++)
                    {
                        if (input[i] != input[j])
                        {
                            if (temp != input[j].ToString())
                            {
                                count++;
                            }
                            else
                            {
                                count = 1;
                                break;
                            }
                        }
                        else if (input[i] == input[j])
                        {
                            temp = input[j].ToString();
                            break;
                        }
                    }

                    storeResult[index] = count;
                    index++;
                    count = 1; // reset count to 1
                }

                // find the maximum number of unequal consecutive characters
                // in the storeResult array
                int max = storeResult[0];
                for (int i = 0; i < storeResult.Length; i++)
                {
                    if (storeResult[i] > max)
                    {
                        max = storeResult[i];
                    }
                }

                Console.WriteLine($"Maximum number of unequal consecutive characters is {max}");
            }
        }
    }
}
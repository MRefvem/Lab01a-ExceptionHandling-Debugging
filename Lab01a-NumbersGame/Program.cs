using System;
using System.Dynamic;

namespace Lab01a_NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my game! Let's do some math!");

            try
            {
                StartSequence();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception caught in Main: {e.Message}");
            }
            finally
            {
                Console.WriteLine("The program has ended.");
            }
        }

        static void StartSequence()
        {
            try
            {
                Console.WriteLine("Enter a number greater than zero");
                int number = 0;
                // Utilize the Convert.ToInt23() method to convert the user's input to an integer.
                number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(number);
                // Instantiate a new integer array that is the size the user just inputted
                int[] array = new int[number];
                // Call the Populate method
                Populate(array);
                // Capture the sum by calling the GetSum method
                GetSum();
                // Capture the product by calling the GetProduct method
                GetProduct();
                // Capture the quotient by calling the GetQuotient method
                GetQuotient();
            }
            catch (FormatException e)
            {
                Console.WriteLine("Wrong format");
            }
            catch (OverflowException)
            {

            }

        }

        static int[] Populate(int[] array)
        {
            Console.WriteLine("I am the Populate method");
            int[] newArray = new Int32[array.Length];
            // Iterate through the array and prompt the user to enter a specific number
            for (int i = 0; i < array.Length; i++)
            {
                int number = 0;
                Console.WriteLine($"Please enter a number: {i} of {array.Length}");
                number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Your choice was {number}");
                newArray[i] = number;

            }
            Console.WriteLine(string.Join(", ", newArray));
            return newArray;
        }

        static int GetSum()
        {
            Console.WriteLine("I am the GetSum method");
            return 10;
        }

        static int GetProduct()
        {
            Console.WriteLine("I am the GetProduct method");
            return 10;
        }

        static decimal GetQuotient()
        {
            Console.WriteLine("I am the GetQuotient method");
            return 10;
        }

    }
}

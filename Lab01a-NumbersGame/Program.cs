using System;
using System.Dynamic;
using System.Linq.Expressions;

namespace Lab01a_NumbersGame
{
    class Program
    {
        // Summary - Main method = entry point of the program
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
                Console.WriteLine("Program is complete.");
            }
        }

        // Summary - StartSequence is where we call for the user to establish the length of our array gather the calls for all of the helper methods and display our final output to the console window
        static void StartSequence()
        {
            try
            {
                Console.WriteLine("Enter a number greater than zero");
                int number = 0;
                // Utilize the Convert.ToInt23() method to convert the user's input to an integer.
                number = Convert.ToInt32(Console.ReadLine());
                // Instantiate a new integer array that is the size the user just inputted
                int[] array = new int[number];
                // Call the Populate method
                int[] newArray = Populate(array);
                // Capture the sum by calling the GetSum method
                int sum = GetSum(newArray);
                // Capture the product by calling the GetProduct method
                int product = GetProduct(newArray, sum);
                // Capture the quotient by calling the GetQuotient method
                decimal quotient = GetQuotient(product);

                int x = 1;
                x = product / sum;

                decimal y = 1;
                y = product / quotient;


                Console.WriteLine($"Your array is size: {array.Length}");
                Console.WriteLine($"The numbers in the array are {string.Join(", ", newArray)}");
                Console.WriteLine($"The sum of the array is {sum}");
                Console.WriteLine($"{sum} * {x} = {product}");
                Console.WriteLine($"{product} / {y} = {quotient}");

            }
            catch (FormatException e)
            {
                Console.WriteLine("Wrong format");
            }
            catch (OverflowException)
            {

            }

        }

        // Summary - Populate is where we instruct the user to populate the array
        static int[] Populate(int[] array)
        {
            int[] newArray = new Int32[array.Length];
            // Iterate through the array and prompt the user to enter a specific number
            for (int i = 0; i < array.Length; i++)
            {
                int number = 0;
                Console.WriteLine($"Please enter a number: {i+1} of {array.Length}");
                number = Convert.ToInt32(Console.ReadLine());
                newArray[i] = number;
            }
            return newArray;
        }

        // Summary - GetSum is where we find the sum of all the array values
        static int GetSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
            if (sum < 20)
            {
                throw new Exception($"Value of {sum} is too low");
            }
            return sum;
        }

        // Summary - GetProduct is where we ask the user to select one index position and then find the product of that array position and the sum of the array
        static int GetProduct(int[] array, int sum)
        {
            try
            {
                int number = 0;
                Console.WriteLine($"Please select a random number between 1 and {array.Length}");
                number = Convert.ToInt32(Console.ReadLine());
                int index = array[number-1];
                int product = sum * index;
                return product;
            }

            catch (IndexOutOfRangeException)
            {
                throw new Exception("Index out of range");
            }
        }

        // Summary - GetQuotient is where we ask the user to provide a number by which we use to divide from the product and return a quotient
        static decimal GetQuotient(int product)
        {
            try
            {
                int number = 0;
                Console.WriteLine($"Please enter a number to divide your product {product} by");
                number = Convert.ToInt32(Console.ReadLine());
                decimal quotient = decimal.Divide(product, number);
                return quotient;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                return 0;
            }

        }

    }
}

using System;

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
                // Utilize the Convert.ToInt23() method to convert the user's input to an integer.
                // Instantiate a new integer array that is the size the user just inputted
                // Call the Populate method
                Populate();
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

        static int Populate()
        {
            Console.WriteLine("I am the Populate method");
            return 10;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to enter a number
            Console.Write("Enter a number: ");

            // Read the input number from the user
            int number = Convert.ToInt32(Console.ReadLine());

            // Display a message indicating that we are listing factors
            Console.WriteLine("Factors of " + number +":" );

            // Find and display the factors of the input number
            for (int i = 1; i <= number; i++)
            {
                // Check if 'i' is a factor of the input number
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                }
                Console.ReadKey();
            }
        }
    }
}
        
using System;
using System.Collections;

namespace Data_structures
{
    class Program
    {
        static void Main(string[] args)
        {

            // Creates a random called randomNumber
            Random randomNumber = new Random();

            // Set the min and max size for the array
            int arraySizeMax = 20;
            int arraySizeMin = 8;

            // Sets the array size to a random integer using the min and max values
            int arraySize = randomNumber.Next(arraySizeMin, arraySizeMax);

            // Creates a new stack called stack
            Stack stack = new Stack();

            // Creates 2 arrays: 
            // 1 normal order "arrayOne"
            // 1 reversed order "arrayOneReversed"
            int[] arrayOne = new int[arraySize];
            int[] arrayOneReversed = new int[arraySize];

            // Populates each place in the array with a random integer between 1 and 50
            for (int i = 0; i < arrayOne.Length; i++)
            {
                arrayOne[i] = randomNumber.Next(1, 50);
            }


            Console.WriteLine("------------------------------");
            Console.WriteLine("The size of the array is: " + arrayOne.Length);
            Console.WriteLine("------------------------------");
            Console.WriteLine("");
            Console.WriteLine("=============================");
            Console.WriteLine("The numbers in the array are: ");
            Console.WriteLine("=============================");

            // Prints the normal order array content to the console
            // Also pushes the numbers to the stack created earlier
            foreach (int number in arrayOne)
            {
                Console.Write(number.ToString() + " ");
                stack.Push(number);
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("========================================");
            Console.WriteLine("The reversed order of those numbers are: ");
            Console.WriteLine("========================================");
            Console.WriteLine("");

            // Prints the reversed order array content to the console
            foreach (int number in stack)
            {
                Console.Write(number.ToString() + " ");
            }


            // Pause the program to see output
            Console.ReadLine();
        }
    }
}

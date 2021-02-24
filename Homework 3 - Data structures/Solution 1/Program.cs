using System;
using System.Collections;
using System.Threading;

namespace DataStructureAssignment
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                // Setting a timer for a countdown used later
                int countdownTimer = 5;

                // program intro
                Console.WriteLine("========================================================================");
                Console.WriteLine(" This program will reverse the order of any string of numbers you input");
                Console.WriteLine("========================================================================");
                Console.WriteLine("");
                Console.WriteLine("How many numbers do you want in your array?");
                Console.WriteLine("(Please note that you will be asked to manually input this number in the next step, so choose wisely!");
                Console.WriteLine("");

                // Get an integer from the user in the form of a string
                string numberString = Console.ReadLine();

                Console.Clear();

                // Convert that string to integer format
                int arrayLength = Convert.ToInt32(numberString);

                // Creates the array "normalOrderArray" and sets the length of the array to the users input string
                int[] normalOrderArray = new int[arrayLength];

                // Creates a stack called "reverseOrder"
                Stack reverseOrder = new Stack();

                // Filler text
                Console.WriteLine("");
                Console.WriteLine("You chose " + arrayLength + " numbers.");
                Console.WriteLine("Please input a number and move to the next by pressing enter.");

                // Takes input from user and sends it to array and stack as integers
                for (int i = 0; i < arrayLength; i++)
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("You have " + (arrayLength - i) + " numbers to go.");
                    Console.WriteLine("");
                    Console.Write("Number: ");

                    string inputString = Console.ReadLine();

                    int inputInt = Convert.ToInt32(inputString);

                    normalOrderArray[i] = inputInt;
                    reverseOrder.Push(inputInt);
                }

                Console.Clear();

                // Summarizing the input / output over the next ~18 lines
                Console.WriteLine("");
                Console.Write("The order of the numbers you wrote is: ");

                foreach (int number in normalOrderArray)
                {
                    Console.Write(number + " ");
                }

                Console.WriteLine("");
                Console.WriteLine("");

                Console.Write("The reversed order of the numbers you wrote is: ");

                foreach (int number in reverseOrder)
                {
                    Console.Write(number + " ");
                }

                // Continue?
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("===============================");
                Console.WriteLine("Do you want try again? (y/n)");

                Console.WriteLine("");
                Console.Write("Your answer: ");

                string answer = Console.ReadLine();

                if (answer == "y" || answer == "Y")
                {
                    // Do nothing and start over
                }
                else if (answer == "n" || answer == "N")
                {
                    Environment.Exit(0);
                }

                else if (answer != "n" || answer != "N" || answer != "y" || answer != "Y")
                {
                    Console.Clear();
                    Console.WriteLine("You did not manage to input a valid option.");
                    Console.WriteLine("");
                    Console.WriteLine("");

                    Console.WriteLine("Terminating program after this message");
                    Thread.Sleep(3500);
                    Console.Clear();

                    for (int i = 0; i < countdownTimer; i++)
                    {
                        Console.WriteLine("Terminating program in " + (countdownTimer - i) + " seconds.");
                        Thread.Sleep(1000);
                        Console.Clear();

                        if (i == countdownTimer - 1)
                        {
                            Environment.Exit(0);
                        }
                    }
                }

                Console.Clear();
            }
        }
    }
}
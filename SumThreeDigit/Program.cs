using System;

namespace SumThreeDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int valueForCompare1, valueForCompare2;
            bool digitsTheSame = true, repeat = true;
            do
            {
                digitsTheSame = true;
                // while loop to repeat until the integers are of equal length
                while (digitsTheSame)
                {
                    digitsTheSame = true;
                    Console.WriteLine("Please enter your first positive integer for comparison");

                    //while loop with TryParse to find a value that can be converted into an int
                    valueForCompare1 = 0;
                    while (!int.TryParse(Console.ReadLine(), out valueForCompare1))
                    {
                        Console.WriteLine("The value could not be converted to an int!");
                        Console.WriteLine("Please enter a valid integer");
                    }

                    // Convert integer to a string to select characters for summation
                    string valueString1 = Convert.ToString(valueForCompare1);

                    //visual verification of the inputs of user
                    Console.WriteLine("Integer Length : {0}", valueString1.Length);

                    Console.WriteLine("Value 1 : {0}", valueForCompare1);

                    Console.WriteLine("Please enter your second positive integer for comparison");

                    valueForCompare2 = 0;
                    while (!int.TryParse(Console.ReadLine(), out valueForCompare2))
                    {
                        Console.WriteLine("The value could not be converted to an int!");
                        Console.WriteLine("Please enter a valid integer");
                    }

                    string valueString2 = Convert.ToString(valueForCompare2);

                    Console.WriteLine("Integer Length : {0}", valueString1.Length);
                    Console.WriteLine("Value 2 : {0}", valueForCompare2);

                    //Checks to see if the integers are the same length before comparing the sums of digits
                    if (valueString1.Length == valueString2.Length)
                    {
                        digitsTheSame = false;
                        bool answer = SumComparison(valueString1, valueString2);
                        if (answer)
                        {
                            Console.WriteLine("True. The sums of the digits are equal!");
                        }
                        else
                        {
                            Console.WriteLine("False. The sums of the digits are not equal!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Integers are not the same length!");
                    }
                }
                Console.WriteLine("Would you like to repeat (y/n)? ");
                bool validAnswer = true;
                while (validAnswer)
                {
                    string repeatPrompt = Console.ReadLine();
                    if (repeatPrompt == "y" || repeatPrompt == "Y" || repeatPrompt == "yes")
                    {
                        repeat = true;
                        validAnswer = false;
                    }
                    else if (repeatPrompt == "n" || repeatPrompt == "N" || repeatPrompt == "no")
                    {
                        Console.WriteLine("Okay exiting the program now.");
                        repeat = false;
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Didn't enter a valid answer. Would you like to test another number (y/n)?: ");
                        validAnswer = true;
                    }
                }
            } while (repeat);
        }

        //finds digit place and compares the sums returning a bool
        public static bool SumComparison(string x, string y)
        {
            int lengthofdigit = x.Length;
            int sumDigit0 = x[0] + y[0];
            for (int i = 1; i < lengthofdigit; i++)
            {
                if (sumDigit0 != (x[i] + y[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}

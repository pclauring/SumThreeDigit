using System;

namespace SumThreeDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int valueForCompare1, valueForCompare2;
            bool correctint = true;
            Console.WriteLine("Please enter your first positive three digit integer for comparison");

            //while loop with TryParse to find a value that can be converted into an int
            valueForCompare1 = 0;
            while (!int.TryParse(Console.ReadLine(), out valueForCompare1))
            {
                Console.WriteLine("The value could not be converted to an int!");
                Console.WriteLine("Please enter a valid integer");
            }

            // Loop for verifying correctly inputted variable of the first loop
            while (correctint)
            {
                if (valueForCompare1 >= 100 && valueForCompare1 <= 999)
                {
                    correctint = false;
                    Console.WriteLine("Value accepted!");
                }
                else
                {
                    Console.WriteLine("Value not in range. Please enter a positive three digit integer for comparison");
                    valueForCompare1 = Convert.ToInt32(Console.ReadLine());
                }

            }

            Console.WriteLine("Value 1 = {0}", valueForCompare1);

            Console.WriteLine("Please enter your second positive three digit integer for comparison");

            // for string entry into ReadLine still only handles first exception

            correctint = true;

            //while loop with TryParse to find a value that can be converted into an int
            valueForCompare2 = 0;
            while (!int.TryParse(Console.ReadLine(), out valueForCompare2))
            {
                Console.WriteLine("The value could not be converted to an int!");
                Console.WriteLine("Please enter a valid integer");
            }

            while (correctint)
            {
                if (valueForCompare2 >= 100 && valueForCompare2 <= 999)
                {
                    correctint = false;
                    Console.WriteLine("Value accepted!");
                }
                else
                {
                    Console.WriteLine("Value not in range. Please enter a positive three digit integer for comparison");
                    valueForCompare2 = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Value 2 = {0}", valueForCompare2);
            {
                int totalOnes = LocationOfDigit(valueForCompare1, 1) + LocationOfDigit(valueForCompare2, 1);
                int totalTens = LocationOfDigit(valueForCompare1, 10) + LocationOfDigit(valueForCompare2, 10);
                int totalHundreds = LocationOfDigit(valueForCompare1, 100) + LocationOfDigit(valueForCompare2, 100);
                Console.WriteLine("The sum of each digit place is ones {0}, tens {1} and hundreds {2}", totalOnes, totalTens, totalHundreds);

                SumComparison(totalOnes, totalTens, totalHundreds);

            }
        }
        //checks the sums equality and prints the answer
        public static void SumComparison(int x, int y, int z)
        {
            if (x == y && y == z)
            {
                Console.WriteLine("True. The sum totals of each digit place are all the same integer value.");
            }
            else
            {
                Console.WriteLine("False. The sum totals of each digit place are not all the same integer value");
            }

        }
        public static int LocationOfDigit(int newDigitValue, int place)
        {
            int desiredDigitPlace = (newDigitValue / place) % 10;
            return desiredDigitPlace;
        }

    }
}

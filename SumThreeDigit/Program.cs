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
                //pulling digits from the first value
                int onesPlaceFirstValue = LocationOfDigit(valueForCompare1, 1);
                int tensPlaceFirstValue = LocationOfDigit(valueForCompare1, 10);
                int hundredsPlaceFirstValue = LocationOfDigit(valueForCompare1, 100);

                int onesPlaceSecondValue = LocationOfDigit(valueForCompare2, 1);
                int tensPlaceSecondValue = LocationOfDigit(valueForCompare2, 10);
                int hundredsPlaceSecondValue = LocationOfDigit(valueForCompare2, 100);

                //tests for correct digit selection
                Console.WriteLine("The console found the three digits in the first value to be {2}, {1}, and {0}", onesPlaceFirstValue, tensPlaceFirstValue, hundredsPlaceFirstValue);
                Console.WriteLine("The console found the three digits in the second value to be {2}, {1}, and {0}", onesPlaceSecondValue, tensPlaceSecondValue, hundredsPlaceSecondValue);

                int totalfirstdigit = onesPlaceFirstValue + onesPlaceSecondValue;
                int totalseconddigit = tensPlaceFirstValue + tensPlaceSecondValue;
                int totalthirddigit = hundredsPlaceFirstValue + hundredsPlaceSecondValue;

                SumComparison(totalfirstdigit, totalseconddigit, totalthirddigit);

            }
        }
        public static void SumComparison(int x, int y, int z)
        {
            bool sumsAreEqual;
            if (x == y && y == z)
            {
                sumsAreEqual = true;
                Console.WriteLine("True. The sum total of each digit place are all the same integer value.");
            }
            else
            {
                sumsAreEqual = false;
                Console.WriteLine("False. The sum total of each digit place are not all the same integer value");
            }

        }
        public static int LocationOfDigit(int newDigitValue, int place)
        {
            if (place == 1)
            {
                int desiredDigitPlace = newDigitValue % 10;
                return desiredDigitPlace;
            }
            else if (place == 10)
            {
                int desiredDigitPlace = (newDigitValue / 10) % 10;
                return desiredDigitPlace;
            }
            else
            {
                int desiredDigitValue = (newDigitValue / 100) % 10;
                return desiredDigitValue;
            }

        }
    }
}
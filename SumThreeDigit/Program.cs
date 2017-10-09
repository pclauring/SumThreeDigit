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

            // need to create method for valueForCompare int - redundant code
            // for string entry into ReadLine still only handles first exception
            try
            {
                valueForCompare1 = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Entry. Please enter a positive three digit integer.");
                valueForCompare1 = Convert.ToInt32(Console.ReadLine());
            }

            // Loop for verifying correctly inputted variable of the first loop
            while (correctint)
            {
                if (valueForCompare1 >= 1 && valueForCompare1 <= 999)
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
            try
            {
                valueForCompare2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Entry. Please enter a positive three digit integer.");
                valueForCompare2 = Convert.ToInt32(Console.ReadLine());
            }

            // Loop for verifying correctly inputted variable of the first loop

            while (correctint)
            {
                if (valueForCompare2 >= 1 && valueForCompare2 <= 999)
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
                //Console.WriteLine(onesPlaceFirstValue);
                //Console.WriteLine(tensPlaceFirstValue);
                // Console.WriteLine(hundredsPlaceFirstValue);

                //Console.WriteLine(onesPlaceSecondValue);
                //Console.WriteLine(tensPlaceSecondValue);
                //Console.WriteLine(hundredsPlaceSecondValue);

                int totalfirstdigit = onesPlaceFirstValue + onesPlaceSecondValue;
                int totalseconddigit = tensPlaceFirstValue + tensPlaceSecondValue;
                int totalthirddigit = hundredsPlaceFirstValue + hundredsPlaceSecondValue;

                bool sumsAreEqual;

                if (totalfirstdigit == totalseconddigit && totalseconddigit == totalthirddigit)
                {
                    sumsAreEqual = true;
                    Console.WriteLine(sumsAreEqual);
                }
                else
                {
                    sumsAreEqual = false;
                    Console.WriteLine(sumsAreEqual);
                }
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
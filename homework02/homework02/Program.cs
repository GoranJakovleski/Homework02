using System;

namespace homework02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 03
            //You have n credits on your mobile bill.
            //One SMS costs m credits.
            //How many SMS messages you can send?
            // n = 102
            //m = 5
            //Result = ?

            //int n = 102;
            //int m = 5;
            // int result = n / m;
            //Console.WriteLine($"I can send {result} messeges");

            // Console.ReadLine();

            // Exercise 04(*BONUS)
            //Set variable from input
            // to convert it to int
            //if its converted successfully print in the console if number is odd or even
            // if its not converted, print in the console that user inserted invalid input
            //: if number / 2 has remainder 0 its even, else its odd

            Console.WriteLine("Please enter some number");
            var number = Console.ReadLine();
            int converted;
            bool isConverted = int.TryParse(number, out converted);

            if (converted % 2 == 0)
            {

                Console.WriteLine($"The number is add");

            }

            else if (converted > 0)
            {
                Console.WriteLine($"The number is even");

            }
            else
            {

                Console.WriteLine("You inserted invalid input");
            }


            Console.ReadLine();
        }
    }
}

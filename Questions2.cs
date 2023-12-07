using System;

namespace last_digit
{
    class Random_number_program 
    {
        static void Main(string[] args)
        {
            // create random object
            Random random = new Random();

            // generate random number 
            int random_number = random.Next();

            // calculate the last digit
            int last_digit = random_number % 10;

            Console.WriteLine("Random number is: " + last_digit);

        }
    }
}
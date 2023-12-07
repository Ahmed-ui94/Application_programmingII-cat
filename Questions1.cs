using System;

namespace Random_number
{
    class Random_program 
    {
        static void Main(string[] args)
        {
            // create random object
            Random random = new Random();

            // generate random number 
            int random_number = random.Next();

            Console.WriteLine("Random number is: " + random_number);

        }
    }
}
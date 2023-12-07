using System;

namespace swap_numbers 
{
    class swap_2_numbers {
        static void interchange_numbers() {
             // provide the first key
            Console.Write("Enter the first number: ");
            int first_number = Convert.ToInt32(Console.ReadLine());
            
            //provide the second number
            Console.Write("Enter the second number: ");
            int second_number = Convert.ToInt32(Console.ReadLine());

            // swap the two numbers using a third number
            int swaping_number = first_number;
            first_number = second_number;
            second_number = swaping_number;

            Console.WriteLine("first number after swapping: " + first_number);
            Console.WriteLine("second number after swapping: " + second_number);
        }
        static void Main(string[] args)
        {
            interchange_numbers();
        }
    }
}

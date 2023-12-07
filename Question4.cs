using System;

namespace print_string
{
    class string_print_program
    {   static void print_name() {

        // take value of string os ur name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            // print the name followed by new line
            Console.WriteLine(name);

    }
        static void Main(string[] arg)
        {
            print_name();
        }
    }
}
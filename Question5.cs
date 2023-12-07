using System;
using System.Text;

class Program
{
    static void Main()
    {
        // Example string
        string originalString = "Ahmed Abukar Ibrahim";

        // Reverse the string
        string reversedString = ReverseString(originalString);

        // Print the result
        Console.WriteLine("Original String: " + originalString);
        Console.WriteLine("Reversed String: " + reversedString);
    }

    // Function to reverse a string
    static string ReverseString(string input)
    {
        // Convert the string to a character array
        char[] charArray = input.ToCharArray();

        // Use a StringBuilder to efficiently build the reversed string
        StringBuilder reversedBuilder = new StringBuilder();

        // Iterate through the array in reverse order and append each character to the StringBuilder
        for (int i = charArray.Length - 1; i >= 0; i--)
        {
            reversedBuilder.Append(charArray[i]);
        }

        // Convert the StringBuilder to a string and return
        return reversedBuilder.ToString();
    }
}

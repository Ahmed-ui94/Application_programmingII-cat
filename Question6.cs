using System;

namespace prefix 
{
    class prefix_length
    {
         static void Main()
    {
        // Example strings
        string mainString = "Bsc Information Technology";
        string prefix = "Bsc";

        // Get the length of the prefix
        int prefixLength = GetPrefixLength(mainString, prefix);

        // Print the result
        Console.WriteLine("Main String: " + mainString);
        Console.WriteLine("Prefix: " + prefix);
        Console.WriteLine("Length of Prefix: " + prefixLength);
    }
        // Function to get the length of a prefix string
    static int GetPrefixLength(string mainString, string prefix)
    {
        int minLength = Math.Min(mainString.Length, prefix.Length);

        // Iterate through the characters of the prefix and main string
        for (int i = 0; i < minLength; i++)
        {
            // If a mismatch is found, return the current index
            if (mainString[i] != prefix[i])
            {
                return i;
            }
        }

        // If all characters match up to the length of the shorter string, return that length
        return minLength;
    }
    }
}
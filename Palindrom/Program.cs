using System;
using System.Text.RegularExpressions;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sentence: ");
            string str = Console.ReadLine();
            
            string strNoSpace = str.Replace(" ", "");
            Console.WriteLine($"Sentence without spaces: {strNoSpace}");
            
            string reverse = ReverceSent(strNoSpace);
            Console.WriteLine($"Reversed sentence: {reverse}");
            

            if (string.Equals(strNoSpace, reverse, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Sentence \"{str}\" is a Palindrome");
            }
            else
            {
                Console.WriteLine($"Sentence \"{str}\" is not a Palindrome");
            }

        }

        public static string ReverceSent(string s)
        {
            char[] letters = s.ToCharArray(); //display sentence as an array
            Array.Reverse(letters);
            return new string(letters);
        }
    }
}
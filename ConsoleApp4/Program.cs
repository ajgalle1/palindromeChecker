using System.Diagnostics.Metrics;
using System.Runtime.InteropServices.Marshalling;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ans = string.Empty;

            while (string.IsNullOrWhiteSpace(ans))
            {
                Console.WriteLine("Palindrome Checker:");
                ans = Console.ReadLine().ToLower();
            }

            string reversed = ReverseIt(ans);
            Console.WriteLine(reversed);
            Console.WriteLine(ans == reversed ? "Is Palindrome"
                                : "Not a palindrome");

        }
        public static string ReverseIt(string ans) { 
            ans = ans.ToLower();
            char[] toReverse = ans.ToCharArray();
            char[] reversed = new char[ans.Length];
            int counter = 0; 
            
            for(int i = reversed.Length-1; i >= 0; i--)
            {
               
                reversed[counter] = toReverse[i];
                counter++;
            }
            
            return string.Join("" , reversed);
            
        }
    }
}

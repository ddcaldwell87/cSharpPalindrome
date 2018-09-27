using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Palindrome(string check)
            {
                string parsed = check.Replace(" ", "").ToLower();
                char[] word = parsed.ToCharArray();
                var reversed = word.Reverse();
                var joined = String.Join("", reversed);
                
                if (parsed == joined)
                {
                    Console.WriteLine("true");
                    return true;
                }
                else
                {
                    Console.WriteLine("false");
                    return false;
                }
            }
            Palindrome("ufo tofu");
            Console.Read();
        }
    }
}

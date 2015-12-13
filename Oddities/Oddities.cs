using System;

namespace Oddities
{
    /// <summary>
    /// Oddities - Working
    /// 
    /// Some numbers are just, well, odd. For example, the number 3 is odd, because it is not a multiple of two. 
    /// Numbers that are a multiple of two are not odd, they are even. More precisely, if a number n can be expressed 
    /// as n=2∗k for some integer k, then n is even. For example, 6=2∗3 is even.
    /// 
    /// Some people get confused about whether numbers are odd or even.To see a common example, do an internet search 
    /// for the query “is zero even or odd?” (Don’t search for this now! You have a problem to solve!)
    /// 
    /// Write a program to help these confused people.
    /// </summary>
    
    internal class Oddities
    {
        private static void Main(string[] args)
        {
            var testcases = int.Parse(Console.ReadLine());

            for (var i = 0; i < testcases; i++)
            {
                var input = int.Parse(Console.ReadLine());

                Console.WriteLine(input % 2 == 0 ? input + " is even" : input + " is odd");
            }
        }
    }
}

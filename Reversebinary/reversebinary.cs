using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

/// <summary>
/// Reverse Binary - Working
/// 
/// Yi has moved to Sweden and now goes to school here. The first years of schooling she got in China, and the curricula do not 
/// match completely in the two countries. Yi likes mathematics, but now... The teacher explains the algorithm for subtraction on 
/// the board, and Yi is bored. Maybe it is possible to perform the same calculations on the numbers corresponding to the reversed 
/// binary representations of the numbers on the board? Yi dreams away and starts constructing a program that reverses the binary 
/// representation, in her mind. As soon as the lecture ends, she will go home and write it on her computer.
/// </summary>

namespace Kattis
{
    class reversebinary
    {
        static void Main(string[] args)
        {
            var inValue = int.Parse(Console.ReadLine());
            var binaryString = Convert.ToString(inValue, 2);
            var reversedBinary = Reverse(binaryString);
            Console.WriteLine(Convert.ToInt32(reversedBinary, 2));
        }

        private static string Reverse(string value)
        {
            var length = value.Length - 1;
            var result = new char[value.Length];
            for (int i = length; i > -1; i--)
            {
                result[length - i] = value[i];
            }
            return new string(result);
        }
    }
}

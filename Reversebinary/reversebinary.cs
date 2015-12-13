using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

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
